namespace JetSalePro.pages {
    partial class Success {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoaderGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaderGif
            // 
            this.LoaderGif.Image = global::JetSalePro.Properties.Resources.success;
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
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::JetSalePro.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(343, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // Success
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 324);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.LabelTile);
            this.Controls.Add(this.LoaderGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(501, 330);
            this.MinimumSize = new System.Drawing.Size(501, 330);
            this.Name = "Success";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LoaderGif;
        private System.Windows.Forms.Label LabelTile;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette AppPalette;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}