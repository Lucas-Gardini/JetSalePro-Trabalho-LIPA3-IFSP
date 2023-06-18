namespace JetSalePro {
    partial class User {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.AppPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LabelCopy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewUsers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.codigo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.criado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atualizado_em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureAdd = new System.Windows.Forms.PictureBox();
            this.PictureSearch = new System.Windows.Forms.PictureBox();
            this.PictureDelete = new System.Windows.Forms.PictureBox();
            this.PictureEdit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureReset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReset)).BeginInit();
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
            this.LabelCopy.Location = new System.Drawing.Point(789, 440);
            this.LabelCopy.Name = "LabelCopy";
            this.LabelCopy.Size = new System.Drawing.Size(104, 15);
            this.LabelCopy.TabIndex = 8;
            this.LabelCopy.Text = "© 0000 JetSale Pro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::JetSalePro.Properties.Resources.back1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.GoBack);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Voltar";
            this.label1.Click += new System.EventHandler(this.GoBack);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(696, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Controle de usuários";
            // 
            // DataGridViewUsers
            // 
            this.DataGridViewUsers.AllowUserToAddRows = false;
            this.DataGridViewUsers.AllowUserToDeleteRows = false;
            this.DataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_usuario,
            this.nome,
            this.usuario,
            this.senha,
            this.situacao,
            this.adm,
            this.criado_em,
            this.atualizado_em});
            this.DataGridViewUsers.Location = new System.Drawing.Point(13, 56);
            this.DataGridViewUsers.Name = "DataGridViewUsers";
            this.DataGridViewUsers.ReadOnly = true;
            this.DataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUsers.Size = new System.Drawing.Size(823, 366);
            this.DataGridViewUsers.TabIndex = 12;
            // 
            // codigo_usuario
            // 
            this.codigo_usuario.HeaderText = "Cód.";
            this.codigo_usuario.Name = "codigo_usuario";
            this.codigo_usuario.ReadOnly = true;
            this.codigo_usuario.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Nome de Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // senha
            // 
            this.senha.HeaderText = "Senha Cript";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.HeaderText = "Ativo";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.situacao.Width = 75;
            // 
            // adm
            // 
            this.adm.HeaderText = "Administrador";
            this.adm.Name = "adm";
            this.adm.ReadOnly = true;
            this.adm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // criado_em
            // 
            this.criado_em.HeaderText = "Criado em";
            this.criado_em.Name = "criado_em";
            this.criado_em.ReadOnly = true;
            // 
            // atualizado_em
            // 
            this.atualizado_em.HeaderText = "Atualizado em";
            this.atualizado_em.Name = "atualizado_em";
            this.atualizado_em.ReadOnly = true;
            // 
            // PictureAdd
            // 
            this.PictureAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAdd.Image = global::JetSalePro.Properties.Resources.add;
            this.PictureAdd.Location = new System.Drawing.Point(853, 252);
            this.PictureAdd.Name = "PictureAdd";
            this.PictureAdd.Size = new System.Drawing.Size(40, 38);
            this.PictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureAdd.TabIndex = 13;
            this.PictureAdd.TabStop = false;
            this.PictureAdd.WaitOnLoad = true;
            this.PictureAdd.Click += new System.EventHandler(this.PictureAdd_Click);
            // 
            // PictureSearch
            // 
            this.PictureSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureSearch.Image = global::JetSalePro.Properties.Resources.search;
            this.PictureSearch.Location = new System.Drawing.Point(854, 296);
            this.PictureSearch.Name = "PictureSearch";
            this.PictureSearch.Size = new System.Drawing.Size(40, 38);
            this.PictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureSearch.TabIndex = 14;
            this.PictureSearch.TabStop = false;
            this.PictureSearch.WaitOnLoad = true;
            this.PictureSearch.Click += new System.EventHandler(this.PictureSearch_Click);
            // 
            // PictureDelete
            // 
            this.PictureDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureDelete.Image = global::JetSalePro.Properties.Resources.delete;
            this.PictureDelete.Location = new System.Drawing.Point(853, 384);
            this.PictureDelete.Name = "PictureDelete";
            this.PictureDelete.Size = new System.Drawing.Size(40, 38);
            this.PictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureDelete.TabIndex = 15;
            this.PictureDelete.TabStop = false;
            this.PictureDelete.WaitOnLoad = true;
            this.PictureDelete.Click += new System.EventHandler(this.PictureDelete_Click);
            // 
            // PictureEdit
            // 
            this.PictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureEdit.Image = global::JetSalePro.Properties.Resources.edit;
            this.PictureEdit.Location = new System.Drawing.Point(853, 340);
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.Size = new System.Drawing.Size(40, 38);
            this.PictureEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureEdit.TabIndex = 16;
            this.PictureEdit.TabStop = false;
            this.PictureEdit.WaitOnLoad = true;
            this.PictureEdit.Click += new System.EventHandler(this.PictureEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::JetSalePro.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(656, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // PictureReset
            // 
            this.PictureReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureReset.Image = global::JetSalePro.Properties.Resources.reset_search;
            this.PictureReset.Location = new System.Drawing.Point(854, 56);
            this.PictureReset.Name = "PictureReset";
            this.PictureReset.Size = new System.Drawing.Size(40, 38);
            this.PictureReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureReset.TabIndex = 18;
            this.PictureReset.TabStop = false;
            this.PictureReset.WaitOnLoad = true;
            this.PictureReset.Click += new System.EventHandler(this.PictureReset_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(905, 461);
            this.Controls.Add(this.PictureReset);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PictureEdit);
            this.Controls.Add(this.PictureDelete);
            this.Controls.Add(this.PictureSearch);
            this.Controls.Add(this.PictureAdd);
            this.Controls.Add(this.DataGridViewUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelCopy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 500);
            this.Name = "User";
            this.Palette = this.AppPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JetSale Pro";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Resize += new System.EventHandler(this.UserManagement_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelCopy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewUsers;
        private System.Windows.Forms.PictureBox PictureAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adm;
        private System.Windows.Forms.DataGridViewTextBoxColumn criado_em;
        private System.Windows.Forms.DataGridViewTextBoxColumn atualizado_em;
        private System.Windows.Forms.PictureBox PictureSearch;
        private System.Windows.Forms.PictureBox PictureDelete;
        private System.Windows.Forms.PictureBox PictureEdit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PictureReset;
    }
}

