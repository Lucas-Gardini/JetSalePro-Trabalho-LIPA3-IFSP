namespace JetSalePro.pages {
    partial class Alert {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.LoaderGif = new System.Windows.Forms.PictureBox();
            this.LabelTile = new System.Windows.Forms.Label();
            this.AppPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.LabelMessage = new System.Windows.Forms.Label();
            this.ButtonCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonConfirm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderGif)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaderGif
            // 
            this.LoaderGif.Image = global::JetSalePro.Properties.Resources.alert;
            this.LoaderGif.Location = new System.Drawing.Point(12, 12);
            this.LoaderGif.Name = "LoaderGif";
            this.LoaderGif.Size = new System.Drawing.Size(89, 73);
            this.LoaderGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoaderGif.TabIndex = 0;
            this.LoaderGif.TabStop = false;
            this.LoaderGif.WaitOnLoad = true;
            // 
            // LabelTile
            // 
            this.LabelTile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LabelTile.Location = new System.Drawing.Point(107, 12);
            this.LabelTile.Name = "LabelTile";
            this.LabelTile.Size = new System.Drawing.Size(376, 76);
            this.LabelTile.TabIndex = 1;
            this.LabelTile.Text = "TITLE";
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
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LabelMessage.Location = new System.Drawing.Point(12, 88);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(471, 168);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "MESSAGE";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(367, 269);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonCancel.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.OverrideDefault.Back.ColorAngle = 45F;
            this.ButtonCancel.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.OverrideDefault.Border.ColorAngle = 45F;
            this.ButtonCancel.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonCancel.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonCancel.OverrideDefault.Border.Rounding = 20;
            this.ButtonCancel.OverrideDefault.Border.Width = 1;
            this.ButtonCancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ButtonCancel.Size = new System.Drawing.Size(116, 43);
            this.ButtonCancel.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonCancel.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StateCommon.Back.ColorAngle = 45F;
            this.ButtonCancel.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonCancel.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StateCommon.Border.ColorAngle = 45F;
            this.ButtonCancel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonCancel.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonCancel.StateCommon.Border.Rounding = 20;
            this.ButtonCancel.StateCommon.Border.Width = 1;
            this.ButtonCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonCancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StatePressed.Back.ColorAngle = 135F;
            this.ButtonCancel.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StatePressed.Border.ColorAngle = 135F;
            this.ButtonCancel.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonCancel.StatePressed.Border.Rounding = 20;
            this.ButtonCancel.StatePressed.Border.Width = 1;
            this.ButtonCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonCancel.StateTracking.Back.ColorAngle = 45F;
            this.ButtonCancel.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonCancel.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonCancel.StateTracking.Border.ColorAngle = 45F;
            this.ButtonCancel.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonCancel.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonCancel.StateTracking.Border.Rounding = 20;
            this.ButtonCancel.StateTracking.Border.Width = 1;
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Values.Text = "❌  Fechar";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(226, 269);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonConfirm.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.OverrideDefault.Back.ColorAngle = 45F;
            this.ButtonConfirm.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.OverrideDefault.Border.ColorAngle = 45F;
            this.ButtonConfirm.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonConfirm.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonConfirm.OverrideDefault.Border.Rounding = 20;
            this.ButtonConfirm.OverrideDefault.Border.Width = 1;
            this.ButtonConfirm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ButtonConfirm.Size = new System.Drawing.Size(135, 43);
            this.ButtonConfirm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonConfirm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StateCommon.Back.ColorAngle = 45F;
            this.ButtonConfirm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonConfirm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StateCommon.Border.ColorAngle = 45F;
            this.ButtonConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonConfirm.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonConfirm.StateCommon.Border.Rounding = 20;
            this.ButtonConfirm.StateCommon.Border.Width = 1;
            this.ButtonConfirm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonConfirm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonConfirm.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StatePressed.Back.ColorAngle = 135F;
            this.ButtonConfirm.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StatePressed.Border.ColorAngle = 135F;
            this.ButtonConfirm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonConfirm.StatePressed.Border.Rounding = 20;
            this.ButtonConfirm.StatePressed.Border.Width = 1;
            this.ButtonConfirm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonConfirm.StateTracking.Back.ColorAngle = 45F;
            this.ButtonConfirm.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.ButtonConfirm.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(13)))), ((int)(((byte)(255)))));
            this.ButtonConfirm.StateTracking.Border.ColorAngle = 45F;
            this.ButtonConfirm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonConfirm.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonConfirm.StateTracking.Border.Rounding = 20;
            this.ButtonConfirm.StateTracking.Border.Width = 1;
            this.ButtonConfirm.TabIndex = 6;
            this.ButtonConfirm.Values.Text = "✅  Confirmar";
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // Alert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 324);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTile);
            this.Controls.Add(this.LoaderGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(501, 330);
            this.MinimumSize = new System.Drawing.Size(501, 330);
            this.Name = "Alert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(11)))), ((int)(((byte)(207)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 0;
            this.StateCommon.Border.Width = 10;
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoaderGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoaderGif;
        private System.Windows.Forms.Label LabelTile;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonConfirm;
    }
}