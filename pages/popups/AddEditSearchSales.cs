using ComponentFactory.Krypton.Toolkit;
using JetSalePro.pages;
using JetSalePro.Properties;
using JetSalePro.services;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetSalePro {
    public partial class AddEditSearchSales : KryptonForm {
        // Modal de carregamento
        Loading loadingForm = new Loading();

        public Sales CurrentSale = new Sales();

        private bool _isSearch = false;

        public AddEditSearchSales(string vendaId, bool isSearch) {
            InitializeComponent();

            CurrentSale.CodigoVenda = int.Parse(vendaId);

            if (isSearch) {
                ButtonSave.Image = Resources.search_full;
                TextBoxCod.Enabled = true;
                TextBoxCod.ReadOnly = false;
                TextBoxCod.StateCommon.Back.Color1 = Color.LightGray;
            }

            if (CurrentSale.CodigoVenda != -1) {
                ComboBoxCliente.Enabled = false;
                ComboBoxCliente.StateCommon.ComboBox.Back.Color1 = Color.Gray;
            }

            LabelCopy.Text = $"© {DateTime.Now.Year} JetSale Pro";

            if (!isSearch) {
                TextBoxCod.ReadOnly = true;
                TextBoxCod.StateCommon.Back.Color1 = Color.Gray;

                TextBoxCod.Text = vendaId != "-1" ? vendaId : "";
            }

            if (isSearch || CurrentSale.CodigoVenda == -1) {
                LabelAddProduct.Hide();
                ComboBoxProducts.Hide();
                ButtonAddProduct.Hide();
                ButtonAdd.Hide();
                ButtonMinus.Hide();
                ButtonRemove.Hide();
                ListBoxProducts.Hide();
                LabelTotalWithDiscountTitle.Hide();
                LabelTotalTitle.Hide();
                LabelTotal.Hide();
                LabelTotalWithDiscount.Hide();

                TextBoxDesconto.ReadOnly = true;
                TextBoxDesconto.StateCommon.Back.Color1 = Color.Gray;

                TextBoxObservacoes.ReadOnly = true;
                TextBoxObservacoes.StateCommon.Back.Color1 = Color.Gray;
            }

            _isSearch = isSearch;
        }


        private void GoBack(object sender, EventArgs e) {
            this.Close();
        }

        private async Task AtLoad() {
            var loadingForm = new Loading();
            loadingForm.Show();
            loadingForm.Refresh();

            var clientes = await Clients.GetClients((!_isSearch && CurrentSale.CodigoVenda == -1) ? $"WHERE situacao = 1" : "");

            ComboBoxCliente.Items.Clear();

            foreach (dynamic cliente in clientes.Rows) {
                ComboBoxCliente.Items.Add($"{cliente["codigo_cliente"]} - {cliente["nome"]}");
            }

            if (CurrentSale.CodigoVenda != -1) {
                var sale = await Sales.GetSales($"WHERE codigo_venda = {CurrentSale.CodigoVenda}");

                if (sale != null) {
                    CurrentSale.CodigoCliente = 0; // Valor padrão caso a conversão falhe
                    if (int.TryParse(sale.Rows[0]["codigo_cliente"].ToString(), out int codigoCliente)) {
                        CurrentSale.CodigoCliente = codigoCliente;
                    }

                    CurrentSale.DataVenda = DateTime.MinValue; // Valor padrão caso a conversão falhe
                    if (DateTime.TryParse(sale.Rows[0]["data_venda"].ToString(), out DateTime dataVenda)) {
                        CurrentSale.DataVenda = dataVenda;
                    }

                    CurrentSale.ValorTotal = 0.0f; // Valor padrão caso a conversão falhe
                    if (float.TryParse(sale.Rows[0]["valor_total"].ToString(), out float valorTotal)) {
                        CurrentSale.ValorTotal = valorTotal;
                    }

                    CurrentSale.Subtotal = 0.0f; // Valor padrão caso a conversão falhe
                    if (float.TryParse(sale.Rows[0]["subtotal"].ToString(), out float subtotal)) {
                        CurrentSale.Subtotal = subtotal;
                    }

                    CurrentSale.Desconto = 0.0f; // Valor padrão caso a conversão falhe
                    if (float.TryParse(sale.Rows[0]["desconto"].ToString(), out float desconto)) {
                        CurrentSale.Desconto = desconto;
                    }

                    CurrentSale.Obs = sale.Rows[0]["observacoes"].ToString();
                    CurrentSale.Situacao = sale.Rows[0]["situacao"].ToString();
                    CurrentSale.FormaPagamento = sale.Rows[0]["forma_pagamento"].ToString();

                    TextBoxCod.Text = sale.Rows[0]["codigo_venda"].ToString();

                    // Obtendo o cliente selecionado, para selecioná-lo na combobox
                    dynamic client = await Clients.GetClients($"WHERE codigo_cliente = {CurrentSale.CodigoCliente}");
                    var index = ComboBoxCliente.Items.IndexOf($"{client.Rows[0]["codigo_cliente"]} - {client.Rows[0]["nome"]}");

                    if (index != -1) {
                        ComboBoxCliente.SelectedIndex = index;
                    } else {
                        ComboBoxCliente.Items.Add($"{client[0]["codigo_cliente"]} - {client[0]["nome"]}");
                        ComboBoxCliente.SelectedIndex = ComboBoxCliente.Items.Count - 1;
                    }

                    TextBoxCod.Text = CurrentSale.CodigoVenda.ToString();
                    TextBoxDesconto.Text = CurrentSale.Desconto.ToString();
                    TextBoxObservacoes.Text = CurrentSale.Obs;

                    ComboBoxSituacao.Text = CurrentSale.Situacao;
                    ComboBoxFormaPagamento.Text = CurrentSale.FormaPagamento;

                } else {
                    new Alert("Produto", "Produto não encontrado!").ShowDialog();
                }

                // Obtendo todos os produtos
                var allProducts = await Products.GetProducts();
                ComboBoxProducts.Items.Clear();
                foreach (dynamic produto in allProducts.Rows) {
                    ComboBoxProducts.Items.Add($"{produto["codigo_produto"]} - {produto["descricao"]}");
                }

                // Obtendo os itens adicionados
                var produtos = await ItemsSales.GetItemSales($"WHERE codigo_venda = {CurrentSale.CodigoVenda}");
                ListBoxProducts.Items.Clear();
                foreach (dynamic produto in produtos.Rows) {
                    dynamic product = (await Products.GetProducts($"WHERE codigo_produto = {produto["codigo_produto"]}")).Rows[0];

                    ListBoxProducts.Items.Add($"{product["descricao"]} | {produto["quantidade"]}");
                }

                if (CurrentSale.Subtotal >= 0) {
                    LabelTotal.Text = $"R$ {CurrentSale.Subtotal}";
                }

                if (CurrentSale.Subtotal >= 0) {
                    LabelTotalWithDiscount.Text = $"R$ {CurrentSale.ValorTotal}";
                }
            }

            loadingForm.Close();
        }

        private async void AddEditSearchSales_Load(object sender, EventArgs e) {
            await AtLoad();
        }

        private void SuccessIcon_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
            // Load the transparent image with an alpha channel
            Image image = Resources.success;

            // Set the image's background color to transparent
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorKey(Color.Transparent, Color.Transparent);

            // Draw the image on the control's surface with alpha blending
            e.Graphics.DrawImage(
                image,
                new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height),
                0,
                0,
                image.Width,
                image.Height,
                GraphicsUnit.Pixel,
                imageAttributes
            );
        }

        private async void ButtonSave_Click(object sender, EventArgs e) {
            loadingForm = new Loading();
            loadingForm.Show();
            loadingForm.Refresh();

            try {
                CurrentSale.CodigoVenda = int.Parse(TextBoxCod?.Text);
            } catch { }

            if (ComboBoxCliente.SelectedIndex != -1)
                CurrentSale.CodigoCliente = int.Parse(ComboBoxCliente.SelectedItem.ToString().Split('-')[0].Trim());

            if (ComboBoxFormaPagamento.SelectedIndex != -1)
                CurrentSale.FormaPagamento = ComboBoxFormaPagamento.SelectedItem.ToString();

            if (ComboBoxSituacao.SelectedIndex != -1)
                CurrentSale.Situacao = ComboBoxSituacao.SelectedItem.ToString();

            if (_isSearch) {
                loadingForm.Close();
                DialogResult dialogResult = DialogResult.OK;
                this.DialogResult = dialogResult;
                this.Close();
                return;
            };

            dynamic user = (await services.User.GetUsers($"WHERE usuario = '{Global.CurrentUser}'")).Rows[0][0];
            CurrentSale.CodigoUsuario = user;

            if (!string.IsNullOrEmpty(TextBoxDesconto.Text))
                CurrentSale.Desconto = float.Parse(TextBoxDesconto.Text);

            if (!string.IsNullOrEmpty(TextBoxObservacoes.Text))
                CurrentSale.Obs = TextBoxObservacoes.Text;

            CurrentSale.TotalItens = 0;
            CurrentSale.Subtotal = 0;
            CurrentSale.ValorTotal = 0;

            bool sucesso;
            if (CurrentSale.CodigoVenda == -1) {
                if (ComboBoxCliente.SelectedIndex == -1) {
                    new Alert("Campo inválido!", "Selecione um cliente!").ShowDialog();
                    loadingForm.Close();
                    return;
                }

                try {
                    CurrentSale.DataVenda = DateTime.Now;
                } catch (Exception ex) {
                    try {
                        loadingForm.Close();
                    } catch { }

                    new Alert("Erro ao cadastrar venda", ex.Message).ShowDialog();
                    return;
                }

                sucesso = await Sales.CreateSale(CurrentSale);
            } else {
                var products = ListBoxProducts.Items;

                foreach (var product in products) {
                    string productName = product.ToString().Split('|')[0].Trim();
                    var productQuantity = int.Parse(product.ToString().Split('|')[1].Trim());
                    CurrentSale.TotalItens += productQuantity;

                    dynamic productPrice = (await Products.GetProducts($"WHERE descricao = '{productName}'")).Rows[0]["preco_venda"];
                    CurrentSale.Subtotal += productPrice * productQuantity;
                }

                CurrentSale.ValorTotal = CurrentSale.Subtotal - CurrentSale.Desconto;

                sucesso = await Sales.UpdateSale(CurrentSale);
            }

            loadingForm.Close();

            if (sucesso) {
                new Success("Venda", "Venda salva com sucesso!").ShowDialog();

                this.Close();
            } else {
                new Alert("Venda", "Erro ao salvar venda!").ShowDialog();
            }
        }

        private void ComboBoxCliente_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void ComboBoxProducts_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private async void ButtonAddProduct_Click(object sender, EventArgs e) {
            var selectedProductIndex = ComboBoxProducts.SelectedIndex;

            if (selectedProductIndex != -1) {
                var productId = ComboBoxProducts.Items[selectedProductIndex].ToString().Split('-')[0].Trim();
                var productName = ComboBoxProducts.Items[selectedProductIndex].ToString().Split('-')[1].Trim();

                foreach (var addedProducts in ListBoxProducts.Items) {
                    if (addedProducts.ToString().Contains(productName)) {
                        new Alert("Produto já inserido", "Este produto já foi inserido. Caso queira aumentar sua quantidade, utilize o menu ao lado.").ShowDialog();
                        return;
                    }
                }

                dynamic produto = (await Products.GetProducts($"WHERE codigo_produto = {productId}")).Rows[0];

                await ItemsSales.CreateItemSale(new ItemsSales() {
                    CodigoVenda = CurrentSale.CodigoVenda,
                    CodigoProduto = produto["codigo_produto"],
                    Quantidade = 1,
                    Descricao = produto["descricao"],
                    ValorUnitario = produto["preco_venda"],
                    SubtotalProduto = produto["preco_venda"]
                });

                await AtLoad();

                //dynamic itemSaleId = (await ItemsSales.GetItemSales($"WHERE descricao LIKE '{productName}%' AND codigo_venda = {CurrentSale.CodigoVenda}")).Rows[0][0];
                //await ItemsSales.IncrementQuantity(itemSaleId);
            }
        }

        private async void ButtonRemove_Click(object sender, EventArgs e) {
            var selectedProductIndex = ListBoxProducts.SelectedIndex;

            if (selectedProductIndex != -1) {
                var productName = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[0].Trim();
                var productQuantity = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[1].TrimStart();

                Alert dialog = new Alert("Remover produto", $"Deseja realmente remover o produto {productName}?", true);
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK) {
                    var loading = new Loading();
                    loading.Show();
                    loading.Refresh();

                    try {
                        dynamic itemSaleId = (await ItemsSales.GetItemSales($"WHERE descricao LIKE '{productName}%' AND codigo_venda = {CurrentSale.CodigoVenda}")).Rows[0][0];
                        var success = await ItemsSales.DeleteItemSale(itemSaleId.ToString(), int.Parse(productQuantity));

                        if (success == true) {
                            new Success("Produto removido!", "").ShowDialog();
                        } else {
                            new Alert("Erro ao remover produto!", "").ShowDialog();
                        }
                    } catch (Exception ex) {
                        new Alert("Erro ao remover produto!", ex.Message).ShowDialog();
                    }

                    loading.Close();

                    AddEditSearchSales_Load(sender, e);
                }
            }
        }

        private async void ButtonAdd_Click(object sender, EventArgs e) {
            var selectedProductIndex = ListBoxProducts.SelectedIndex;

            if (selectedProductIndex != -1) {
                var productName = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[0].Trim();
                //var productQuantity = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[1].TrimStart();

                //if (int.Parse(productQuantity) <= 1) {
                //    ButtonRemove_Click(sender, e);
                //    return;
                //}

                var loading = new Loading();
                loading.Show();
                loading.Refresh();

                try {
                    dynamic itemSaleId = (await ItemsSales.GetItemSales($"WHERE descricao LIKE '{productName}%' AND codigo_venda = {CurrentSale.CodigoVenda}")).Rows[0];
                    dynamic itemSaleProductId = itemSaleId[2];

                    dynamic product = (await Products.GetProducts($"WHERE codigo_produto = {itemSaleProductId.ToString()}")).Rows[0]["quantidade_estoque"];

                    if (product <= 0) {
                        new Alert("Produto sem estoque!", "Não é possível adicionar mais produtos deste tipo, pois não há mais em estoque.").ShowDialog();
                        loading.Close();
                        return;
                    }

                    var success = await ItemsSales.IncrementQuantity(itemSaleId[0]);

                    if (success == false) {
                        new Alert("Erro ao incrementar produto!", "").ShowDialog();
                    }
                } catch (Exception ex) {
                    new Alert("Erro ao incrementar produto!", ex.Message).ShowDialog();
                }

                loading.Close();

                AddEditSearchSales_Load(sender, e);
			}
        }

        private async void ButtonMinus_Click(object sender, EventArgs e) {
            var selectedProductIndex = ListBoxProducts.SelectedIndex;

            if (selectedProductIndex != -1) {
                var productName = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[0].Trim();
                var productQuantity = ListBoxProducts.Items[selectedProductIndex].ToString().Split('|')[1].TrimStart();

                if (int.Parse(productQuantity) <= 1) {
                    ButtonRemove_Click(sender, e);
                    return;
                }

                var loading = new Loading();
                loading.Show();
                loading.Refresh();

                try {
                    dynamic itemSaleId = (await ItemsSales.GetItemSales($"WHERE descricao LIKE '{productName}%' AND codigo_venda = {CurrentSale.CodigoVenda}")).Rows[0][0];
                    var success = await ItemsSales.DecrementQuantity(itemSaleId);

                    if (success == false) {
                        new Alert("Erro ao decrementar produto!", "").ShowDialog();
                    }
                } catch (Exception ex) {
                    new Alert("Erro ao decrementar produto!", ex.Message).ShowDialog();
                }

                loading.Close();

                AddEditSearchSales_Load(sender, e);
            }
        }

        private void LabelAddProduct_Click(object sender, EventArgs e) {

        }
    }
}