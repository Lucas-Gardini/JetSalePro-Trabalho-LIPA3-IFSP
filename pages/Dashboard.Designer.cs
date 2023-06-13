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
			this.ButtonRegistroVenda = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ButtonRelatorios = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ButtonProdutos = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ButtonClientes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
			this.ButtonLiberacaoUsers = new ComponentFactory.Krypton.Toolkit.KryptonButton();
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
			// LabelUser
			// 
			this.LabelUser.AutoSize = true;
			this.LabelUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUser.Location = new System.Drawing.Point(13, 13);
			this.LabelUser.Name = "LabelUser";
			this.LabelUser.Size = new System.Drawing.Size(251, 30);
			this.LabelUser.TabIndex = 9;
			this.LabelUser.Text = "Bem vindo(a): USUARIO";
			// 
			// ButtonRegistroVenda
			// 
			this.ButtonRegistroVenda.Location = new System.Drawing.Point(18, 73);
			this.ButtonRegistroVenda.Name = "ButtonRegistroVenda";
			this.ButtonRegistroVenda.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRegistroVenda.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.OverrideDefault.Back.ColorAngle = 45F;
			this.ButtonRegistroVenda.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.OverrideDefault.Border.ColorAngle = 45F;
			this.ButtonRegistroVenda.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRegistroVenda.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRegistroVenda.OverrideDefault.Border.Rounding = 20;
			this.ButtonRegistroVenda.OverrideDefault.Border.Width = 1;
			this.ButtonRegistroVenda.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.ButtonRegistroVenda.Size = new System.Drawing.Size(200, 52);
			this.ButtonRegistroVenda.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRegistroVenda.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StateCommon.Back.ColorAngle = 45F;
			this.ButtonRegistroVenda.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRegistroVenda.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StateCommon.Border.ColorAngle = 45F;
			this.ButtonRegistroVenda.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRegistroVenda.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRegistroVenda.StateCommon.Border.Rounding = 20;
			this.ButtonRegistroVenda.StateCommon.Border.Width = 1;
			this.ButtonRegistroVenda.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.ButtonRegistroVenda.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.ButtonRegistroVenda.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRegistroVenda.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StatePressed.Back.ColorAngle = 135F;
			this.ButtonRegistroVenda.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StatePressed.Border.ColorAngle = 135F;
			this.ButtonRegistroVenda.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRegistroVenda.StatePressed.Border.Rounding = 20;
			this.ButtonRegistroVenda.StatePressed.Border.Width = 1;
			this.ButtonRegistroVenda.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRegistroVenda.StateTracking.Back.ColorAngle = 45F;
			this.ButtonRegistroVenda.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRegistroVenda.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRegistroVenda.StateTracking.Border.ColorAngle = 45F;
			this.ButtonRegistroVenda.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRegistroVenda.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRegistroVenda.StateTracking.Border.Rounding = 20;
			this.ButtonRegistroVenda.StateTracking.Border.Width = 1;
			this.ButtonRegistroVenda.TabIndex = 10;
			this.ButtonRegistroVenda.Values.Text = "Registrar Venda";
			// 
			// ButtonRelatorios
			// 
			this.ButtonRelatorios.Location = new System.Drawing.Point(18, 148);
			this.ButtonRelatorios.Name = "ButtonRelatorios";
			this.ButtonRelatorios.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRelatorios.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.OverrideDefault.Back.ColorAngle = 45F;
			this.ButtonRelatorios.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.OverrideDefault.Border.ColorAngle = 45F;
			this.ButtonRelatorios.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRelatorios.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRelatorios.OverrideDefault.Border.Rounding = 20;
			this.ButtonRelatorios.OverrideDefault.Border.Width = 1;
			this.ButtonRelatorios.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.ButtonRelatorios.Size = new System.Drawing.Size(200, 52);
			this.ButtonRelatorios.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRelatorios.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StateCommon.Back.ColorAngle = 45F;
			this.ButtonRelatorios.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRelatorios.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StateCommon.Border.ColorAngle = 45F;
			this.ButtonRelatorios.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRelatorios.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRelatorios.StateCommon.Border.Rounding = 20;
			this.ButtonRelatorios.StateCommon.Border.Width = 1;
			this.ButtonRelatorios.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.ButtonRelatorios.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.ButtonRelatorios.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonRelatorios.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StatePressed.Back.ColorAngle = 135F;
			this.ButtonRelatorios.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StatePressed.Border.ColorAngle = 135F;
			this.ButtonRelatorios.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRelatorios.StatePressed.Border.Rounding = 20;
			this.ButtonRelatorios.StatePressed.Border.Width = 1;
			this.ButtonRelatorios.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRelatorios.StateTracking.Back.ColorAngle = 45F;
			this.ButtonRelatorios.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonRelatorios.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonRelatorios.StateTracking.Border.ColorAngle = 45F;
			this.ButtonRelatorios.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonRelatorios.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonRelatorios.StateTracking.Border.Rounding = 20;
			this.ButtonRelatorios.StateTracking.Border.Width = 1;
			this.ButtonRelatorios.TabIndex = 11;
			this.ButtonRelatorios.Values.Text = "Relatórios";
			// 
			// ButtonProdutos
			// 
			this.ButtonProdutos.Location = new System.Drawing.Point(255, 148);
			this.ButtonProdutos.Name = "ButtonProdutos";
			this.ButtonProdutos.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonProdutos.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.OverrideDefault.Back.ColorAngle = 45F;
			this.ButtonProdutos.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.OverrideDefault.Border.ColorAngle = 45F;
			this.ButtonProdutos.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonProdutos.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonProdutos.OverrideDefault.Border.Rounding = 20;
			this.ButtonProdutos.OverrideDefault.Border.Width = 1;
			this.ButtonProdutos.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.ButtonProdutos.Size = new System.Drawing.Size(200, 52);
			this.ButtonProdutos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonProdutos.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StateCommon.Back.ColorAngle = 45F;
			this.ButtonProdutos.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonProdutos.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StateCommon.Border.ColorAngle = 45F;
			this.ButtonProdutos.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonProdutos.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonProdutos.StateCommon.Border.Rounding = 20;
			this.ButtonProdutos.StateCommon.Border.Width = 1;
			this.ButtonProdutos.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.ButtonProdutos.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.ButtonProdutos.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonProdutos.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StatePressed.Back.ColorAngle = 135F;
			this.ButtonProdutos.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StatePressed.Border.ColorAngle = 135F;
			this.ButtonProdutos.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonProdutos.StatePressed.Border.Rounding = 20;
			this.ButtonProdutos.StatePressed.Border.Width = 1;
			this.ButtonProdutos.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonProdutos.StateTracking.Back.ColorAngle = 45F;
			this.ButtonProdutos.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonProdutos.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonProdutos.StateTracking.Border.ColorAngle = 45F;
			this.ButtonProdutos.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonProdutos.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonProdutos.StateTracking.Border.Rounding = 20;
			this.ButtonProdutos.StateTracking.Border.Width = 1;
			this.ButtonProdutos.TabIndex = 13;
			this.ButtonProdutos.Values.Text = "Produtos";
			this.ButtonProdutos.Click += new System.EventHandler(this.ButtonProdutos_Click);
			// 
			// ButtonClientes
			// 
			this.ButtonClientes.Location = new System.Drawing.Point(255, 73);
			this.ButtonClientes.Name = "ButtonClientes";
			this.ButtonClientes.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonClientes.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.OverrideDefault.Back.ColorAngle = 45F;
			this.ButtonClientes.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.OverrideDefault.Border.ColorAngle = 45F;
			this.ButtonClientes.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonClientes.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonClientes.OverrideDefault.Border.Rounding = 20;
			this.ButtonClientes.OverrideDefault.Border.Width = 1;
			this.ButtonClientes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.ButtonClientes.Size = new System.Drawing.Size(200, 52);
			this.ButtonClientes.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonClientes.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StateCommon.Back.ColorAngle = 45F;
			this.ButtonClientes.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonClientes.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StateCommon.Border.ColorAngle = 45F;
			this.ButtonClientes.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonClientes.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonClientes.StateCommon.Border.Rounding = 20;
			this.ButtonClientes.StateCommon.Border.Width = 1;
			this.ButtonClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.ButtonClientes.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.ButtonClientes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonClientes.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StatePressed.Back.ColorAngle = 135F;
			this.ButtonClientes.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StatePressed.Border.ColorAngle = 135F;
			this.ButtonClientes.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonClientes.StatePressed.Border.Rounding = 20;
			this.ButtonClientes.StatePressed.Border.Width = 1;
			this.ButtonClientes.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonClientes.StateTracking.Back.ColorAngle = 45F;
			this.ButtonClientes.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonClientes.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonClientes.StateTracking.Border.ColorAngle = 45F;
			this.ButtonClientes.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonClientes.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonClientes.StateTracking.Border.Rounding = 20;
			this.ButtonClientes.StateTracking.Border.Width = 1;
			this.ButtonClientes.TabIndex = 12;
			this.ButtonClientes.Values.Text = "Clientes";
			this.ButtonClientes.Click += new System.EventHandler(this.ButtonClientes_Click);
			// 
			// ButtonLiberacaoUsers
			// 
			this.ButtonLiberacaoUsers.Location = new System.Drawing.Point(499, 73);
			this.ButtonLiberacaoUsers.Name = "ButtonLiberacaoUsers";
			this.ButtonLiberacaoUsers.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonLiberacaoUsers.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.OverrideDefault.Back.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.OverrideDefault.Border.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonLiberacaoUsers.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonLiberacaoUsers.OverrideDefault.Border.Rounding = 20;
			this.ButtonLiberacaoUsers.OverrideDefault.Border.Width = 1;
			this.ButtonLiberacaoUsers.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
			this.ButtonLiberacaoUsers.Size = new System.Drawing.Size(200, 52);
			this.ButtonLiberacaoUsers.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonLiberacaoUsers.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StateCommon.Back.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonLiberacaoUsers.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StateCommon.Border.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonLiberacaoUsers.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonLiberacaoUsers.StateCommon.Border.Rounding = 20;
			this.ButtonLiberacaoUsers.StateCommon.Border.Width = 1;
			this.ButtonLiberacaoUsers.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
			this.ButtonLiberacaoUsers.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
			this.ButtonLiberacaoUsers.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonLiberacaoUsers.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StatePressed.Back.ColorAngle = 135F;
			this.ButtonLiberacaoUsers.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StatePressed.Border.ColorAngle = 135F;
			this.ButtonLiberacaoUsers.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonLiberacaoUsers.StatePressed.Border.Rounding = 20;
			this.ButtonLiberacaoUsers.StatePressed.Border.Width = 1;
			this.ButtonLiberacaoUsers.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonLiberacaoUsers.StateTracking.Back.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
			this.ButtonLiberacaoUsers.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
			this.ButtonLiberacaoUsers.StateTracking.Border.ColorAngle = 45F;
			this.ButtonLiberacaoUsers.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
			this.ButtonLiberacaoUsers.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
			this.ButtonLiberacaoUsers.StateTracking.Border.Rounding = 20;
			this.ButtonLiberacaoUsers.StateTracking.Border.Width = 1;
			this.ButtonLiberacaoUsers.TabIndex = 16;
			this.ButtonLiberacaoUsers.Values.Text = "Controle de Usuários";
			this.ButtonLiberacaoUsers.Click += new System.EventHandler(this.ButtonLiberacaoUsers_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(905, 461);
			this.Controls.Add(this.ButtonLiberacaoUsers);
			this.Controls.Add(this.ButtonProdutos);
			this.Controls.Add(this.ButtonClientes);
			this.Controls.Add(this.ButtonRelatorios);
			this.Controls.Add(this.ButtonRegistroVenda);
			this.Controls.Add(this.LabelUser);
			this.Controls.Add(this.LabelCopy);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(540, 500);
			this.Name = "Dashboard";
			this.Palette = this.AppPalette;
			this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "JetSale Pro";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.Resize += new System.EventHandler(this.Dashboard_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelCopy;
        private System.Windows.Forms.Label LabelUser;
		private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonRegistroVenda;
		private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonRelatorios;
		private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonProdutos;
		private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonClientes;
		private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonLiberacaoUsers;
	}
}

