namespace JetSalePro {
    partial class Auth {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.AppPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.TextBoxUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LabelCopy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.TextBoxName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CheckboxRemember = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.ButtonLogin = new System.Windows.Forms.PictureBox();
            this.ButtonRegister = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // AppPalette
            // 
            this.AppPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.AppPalette.ButtonSpecs.FormMax.Image = global::JetSalePro.Properties.Resources.Invisible;
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
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelTitle.Location = new System.Drawing.Point(43, 112);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(572, 70);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "JetSale Pro\r\nSua ferramenta de gestão de vendas e estoque!";
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.AutoSize = true;
            this.LabelSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelSubTitle.Location = new System.Drawing.Point(43, 201);
            this.LabelSubTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(516, 46);
            this.LabelSubTitle.TabIndex = 1;
            this.LabelSubTitle.Text = "Sucesso nas vendas com a plataforma mais poderosa do mercado.\r\nGerencie, otimize " +
    "e conquiste resultados extraordinários!";
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.Location = new System.Drawing.Point(43, 286);
            this.TextBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.Size = new System.Drawing.Size(505, 39);
            this.TextBoxUser.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.TextBoxUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxUser.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxUser.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TextBoxUser.StateCommon.Border.Rounding = 20;
            this.TextBoxUser.StateCommon.Border.Width = 1;
            this.TextBoxUser.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.TextBoxUser.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUser.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TextBoxUser.TabIndex = 2;
            this.TextBoxUser.Text = "Usuário";
            this.TextBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.TextBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(43, 343);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(505, 39);
            this.TextBoxPassword.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.TextBoxPassword.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxPassword.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxPassword.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TextBoxPassword.StateCommon.Border.Rounding = 20;
            this.TextBoxPassword.StateCommon.Border.Width = 1;
            this.TextBoxPassword.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.TextBoxPassword.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TextBoxPassword.TabIndex = 3;
            this.TextBoxPassword.Text = "Senha";
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            this.TextBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.TextBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPassword_KeyDown);
            this.TextBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JetSalePro.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(48, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PictureLogin
            // 
            this.PictureLogin.Image = global::JetSalePro.Properties.Resources.Login;
            this.PictureLogin.Location = new System.Drawing.Point(713, 143);
            this.PictureLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(477, 287);
            this.PictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogin.TabIndex = 6;
            this.PictureLogin.TabStop = false;
            this.PictureLogin.WaitOnLoad = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(287, 286);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(261, 39);
            this.TextBoxName.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.TextBoxName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TextBoxName.StateCommon.Border.Rounding = 20;
            this.TextBoxName.StateCommon.Border.Width = 1;
            this.TextBoxName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.TextBoxName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TextBoxName.TabIndex = 9;
            this.TextBoxName.Text = "Nome";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // CheckboxRemember
            // 
            this.CheckboxRemember.Location = new System.Drawing.Point(49, 394);
            this.CheckboxRemember.Margin = new System.Windows.Forms.Padding(4);
            this.CheckboxRemember.Name = "CheckboxRemember";
            this.CheckboxRemember.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.CheckboxRemember.Size = new System.Drawing.Size(140, 26);
            this.CheckboxRemember.TabIndex = 10;
            this.CheckboxRemember.Values.Text = "Lembrar de mim";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.Image = global::JetSalePro.Properties.Resources.enter;
            this.ButtonLogin.Location = new System.Drawing.Point(417, 458);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(164, 88);
            this.ButtonLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonLogin.TabIndex = 25;
            this.ButtonLogin.TabStop = false;
            this.ButtonLogin.WaitOnLoad = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.Image = global::JetSalePro.Properties.Resources.no_account;
            this.ButtonRegister.Location = new System.Drawing.Point(156, 458);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(255, 88);
            this.ButtonRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRegister.TabIndex = 26;
            this.ButtonRegister.TabStop = false;
            this.ButtonRegister.WaitOnLoad = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ChangeAuthType);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1204, 558);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.CheckboxRemember);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelCopy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.LabelSubTitle);
            this.Controls.Add(this.LabelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1222, 605);
            this.MinimumSize = new System.Drawing.Size(714, 605);
            this.Name = "Auth";
            this.Palette = this.AppPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JetSale Pro";
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.Resize += new System.EventHandler(this.Auth_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelSubTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxPassword;
        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LabelCopy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxName;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CheckboxRemember;
        private System.Windows.Forms.PictureBox ButtonLogin;
        private System.Windows.Forms.PictureBox ButtonRegister;
    }
}

