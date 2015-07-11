namespace GeneradorBatTurnador
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStriplblNumero = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStriplblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdBusqueda = new System.Windows.Forms.Button();
            this.ImgGear = new System.Windows.Forms.PictureBox();
            this.ImgScreen = new System.Windows.Forms.PictureBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(12, 9);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(148, 13);
            this.lblSucursal.TabIndex = 0;
            this.lblSucursal.Text = "Ingrese el numero de sucursal";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(15, 37);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(136, 20);
            this.txtSucursal.TabIndex = 1;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(253, 114);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdAceptar.TabIndex = 2;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStriplblNumero,
            this.toolStriplblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 140);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(340, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStriplblNumero
            // 
            this.toolStriplblNumero.Name = "toolStriplblNumero";
            this.toolStriplblNumero.Size = new System.Drawing.Size(50, 17);
            this.toolStriplblNumero.Text = "Servidor";
            // 
            // toolStriplblStatus
            // 
            this.toolStriplblStatus.Name = "toolStriplblStatus";
            this.toolStriplblStatus.Size = new System.Drawing.Size(44, 17);
            this.toolStriplblStatus.Text = "Estatus";
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.Location = new System.Drawing.Point(169, 35);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Size = new System.Drawing.Size(75, 23);
            this.cmdBusqueda.TabIndex = 4;
            this.cmdBusqueda.Text = "Busqueda";
            this.cmdBusqueda.UseVisualStyleBackColor = true;
            this.cmdBusqueda.Click += new System.EventHandler(this.cmdBusqueda_Click_1);
            // 
            // ImgGear
            // 
            this.ImgGear.Image = global::GeneradorBatTurnador.Properties.Resources.IMGGear;
            this.ImgGear.Location = new System.Drawing.Point(12, 87);
            this.ImgGear.Name = "ImgGear";
            this.ImgGear.Size = new System.Drawing.Size(53, 50);
            this.ImgGear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgGear.TabIndex = 7;
            this.ImgGear.TabStop = false;
            // 
            // ImgScreen
            // 
            this.ImgScreen.Image = global::GeneradorBatTurnador.Properties.Resources.IMGScreen;
            this.ImgScreen.Location = new System.Drawing.Point(71, 87);
            this.ImgScreen.Name = "ImgScreen";
            this.ImgScreen.Size = new System.Drawing.Size(66, 50);
            this.ImgScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgScreen.TabIndex = 6;
            this.ImgScreen.TabStop = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(169, 114);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 162);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.ImgGear);
            this.Controls.Add(this.ImgScreen);
            this.Controls.Add(this.cmdBusqueda);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.lblSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnador";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplblNumero;
        private System.Windows.Forms.ToolStripStatusLabel toolStriplblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.PictureBox ImgScreen;
        private System.Windows.Forms.PictureBox ImgGear;
        private System.Windows.Forms.Button cmdBusqueda;
        private System.Windows.Forms.Button cmdCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;


    }
}

