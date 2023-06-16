namespace JetSalePro {
    partial class Dashboard {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.AppPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LabelCopy = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.LabelLogout = new System.Windows.Forms.Label();
            this.PictureLogout = new System.Windows.Forms.PictureBox();
            this.ButtonSales = new System.Windows.Forms.PictureBox();
            this.ButtonClients = new System.Windows.Forms.PictureBox();
            this.ButtonUsers = new System.Windows.Forms.PictureBox();
            this.ButtonReports = new System.Windows.Forms.PictureBox();
            this.ButtonProducts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // AppPalette
            // 
            this.AppPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.AppPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AppPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AppPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AppPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AppPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.AppPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 4;
            this.AppPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.AppPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.AppPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.AppPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            // 
            // LabelCopy
            // 
            this.LabelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCopy.AutoSize = true;
            this.LabelCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCopy.Location = new System.Drawing.Point(1052, 542);
            this.LabelCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCopy.Name = "LabelCopy";
            this.LabelCopy.Size = new System.Drawing.Size(134, 20);
            this.LabelCopy.TabIndex = 8;
            this.LabelCopy.Text = "© 0000 JetSale Pro";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUser.Location = new System.Drawing.Point(17, 16);
            this.LabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(323, 37);
            this.LabelUser.TabIndex = 9;
            this.LabelUser.Text = "Bem vindo(a): USUARIO";
            // 
            // LabelLogout
            // 
            this.LabelLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLogout.AutoSize = true;
            this.LabelLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogout.Location = new System.Drawing.Point(1120, 16);
            this.LabelLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLogout.Name = "LabelLogout";
            this.LabelLogout.Size = new System.Drawing.Size(66, 37);
            this.LabelLogout.TabIndex = 17;
            this.LabelLogout.Text = "Sair";
            this.LabelLogout.Click += new System.EventHandler(this.LabelLogout_Click);
            // 
            // PictureLogout
            // 
            this.PictureLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLogout.Image = global::JetSalePro.Properties.Resources.logout;
            this.PictureLogout.Location = new System.Drawing.Point(1065, 13);
            this.PictureLogout.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLogout.Name = "PictureLogout";
            this.PictureLogout.Size = new System.Drawing.Size(53, 47);
            this.PictureLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogout.TabIndex = 18;
            this.PictureLogout.TabStop = false;
            this.PictureLogout.WaitOnLoad = true;
            this.PictureLogout.Click += new System.EventHandler(this.PictureLogout_Click);
            // 
            // ButtonSales
            // 
            this.ButtonSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSales.Image = global::JetSalePro.Properties.Resources.register_sale;
            this.ButtonSales.Location = new System.Drawing.Point(24, 90);
            this.ButtonSales.Name = "ButtonSales";
            this.ButtonSales.Size = new System.Drawing.Size(267, 156);
            this.ButtonSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSales.TabIndex = 26;
            this.ButtonSales.TabStop = false;
            this.ButtonSales.WaitOnLoad = true;
            // 
            // ButtonClients
            // 
            this.ButtonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClients.Image = global::JetSalePro.Properties.Resources.clients;
            this.ButtonClients.Location = new System.Drawing.Point(340, 90);
            this.ButtonClients.Name = "ButtonClients";
            this.ButtonClients.Size = new System.Drawing.Size(267, 156);
            this.ButtonClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClients.TabIndex = 27;
            this.ButtonClients.TabStop = false;
            this.ButtonClients.WaitOnLoad = true;
            this.ButtonClients.Click += new System.EventHandler(this.ButtonClientes_Click);
            // 
            // ButtonUsers
            // 
            this.ButtonUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUsers.Image = global::JetSalePro.Properties.Resources.users_control;
            this.ButtonUsers.Location = new System.Drawing.Point(650, 90);
            this.ButtonUsers.Name = "ButtonUsers";
            this.ButtonUsers.Size = new System.Drawing.Size(267, 156);
            this.ButtonUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonUsers.TabIndex = 28;
            this.ButtonUsers.TabStop = false;
            this.ButtonUsers.WaitOnLoad = true;
            this.ButtonUsers.Click += new System.EventHandler(this.ButtonLiberacaoUsers_Click);
            // 
            // ButtonReports
            // 
            this.ButtonReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReports.Image = global::JetSalePro.Properties.Resources.reports;
            this.ButtonReports.Location = new System.Drawing.Point(24, 288);
            this.ButtonReports.Name = "ButtonReports";
            this.ButtonReports.Size = new System.Drawing.Size(267, 156);
            this.ButtonReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonReports.TabIndex = 29;
            this.ButtonReports.TabStop = false;
            this.ButtonReports.WaitOnLoad = true;
            // 
            // ButtonProducts
            // 
            this.ButtonProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonProducts.Image = global::JetSalePro.Properties.Resources.products;
            this.ButtonProducts.Location = new System.Drawing.Point(340, 288);
            this.ButtonProducts.Name = "ButtonProducts";
            this.ButtonProducts.Size = new System.Drawing.Size(267, 156);
            this.ButtonProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonProducts.TabIndex = 30;
            this.ButtonProducts.TabStop = false;
            this.ButtonProducts.WaitOnLoad = true;
            this.ButtonProducts.Click += new System.EventHandler(this.ButtonProdutos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1207, 567);
            this.Controls.Add(this.ButtonProducts);
            this.Controls.Add(this.ButtonReports);
            this.Controls.Add(this.ButtonUsers);
            this.Controls.Add(this.ButtonClients);
            this.Controls.Add(this.ButtonSales);
            this.Controls.Add(this.PictureLogout);
            this.Controls.Add(this.LabelLogout);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.LabelCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(714, 605);
            this.Name = "Dashboard";
            this.Palette = this.AppPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JetSale Pro";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelCopy;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label LabelLogout;
        private System.Windows.Forms.PictureBox PictureLogout;
        private System.Windows.Forms.PictureBox ButtonSales;
        private System.Windows.Forms.PictureBox ButtonClients;
        private System.Windows.Forms.PictureBox ButtonUsers;
        private System.Windows.Forms.PictureBox ButtonReports;
        private System.Windows.Forms.PictureBox ButtonProducts;
    }
}

