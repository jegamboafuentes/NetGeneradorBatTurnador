namespace GeneradorBatTurnador
{
    partial class Finalizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Finalizar));
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.ImgGear = new System.Windows.Forms.PictureBox();
            this.ImgScreen = new System.Windows.Forms.PictureBox();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(12, 9);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(108, 13);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "Configuracion exitosa";
            // 
            // ImgGear
            // 
            this.ImgGear.Image = global::GeneradorBatTurnador.Properties.Resources.IMGGear;
            this.ImgGear.Location = new System.Drawing.Point(15, 43);
            this.ImgGear.Name = "ImgGear";
            this.ImgGear.Size = new System.Drawing.Size(53, 50);
            this.ImgGear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgGear.TabIndex = 9;
            this.ImgGear.TabStop = false;
            // 
            // ImgScreen
            // 
            this.ImgScreen.Image = global::GeneradorBatTurnador.Properties.Resources.IMGScreen;
            this.ImgScreen.Location = new System.Drawing.Point(85, 43);
            this.ImgScreen.Name = "ImgScreen";
            this.ImgScreen.Size = new System.Drawing.Size(66, 50);
            this.ImgScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgScreen.TabIndex = 8;
            this.ImgScreen.TabStop = false;
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Location = new System.Drawing.Point(142, 109);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(75, 23);
            this.cmdFinalizar.TabIndex = 10;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // Finalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 144);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.ImgGear);
            this.Controls.Add(this.ImgScreen);
            this.Controls.Add(this.lblEtiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Finalizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar";
            ((System.ComponentModel.ISupportInitialize)(this.ImgGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.PictureBox ImgGear;
        private System.Windows.Forms.PictureBox ImgScreen;
        private System.Windows.Forms.Button cmdFinalizar;
    }
}