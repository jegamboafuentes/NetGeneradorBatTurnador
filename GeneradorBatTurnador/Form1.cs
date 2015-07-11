using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.Net;
using System.IO;
using System.Threading;

namespace GeneradorBatTurnador
{
    public partial class Inicio : Form
    {
        int contador = 50;
        Logic logica = new Logic();
        private Thread oThread = null;
        bool bandera = false;


        
        public Inicio()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (logica.validaInformacion(txtSucursal.Text) == true)
            {
                logica.GeneraBat(logica.ValidaCantidadCeros(txtSucursal.Text)); 
                Finalizar form = new Finalizar();
                form.Visible = true;
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Ejemplo 55","Numero de sucural invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void busqueda()
        {
            DialogResult mensaje = MessageBox.Show("Esta operacion puede tardar mucho tiempo", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mensaje == DialogResult.Yes)
            {
                bool status = false;
                do
                {
                    contador++;
                    status = logica.BuscarServidorAutomatico(contador); 
                    toolStriplblNumero.Text = "nt" + contador.ToString();
                    if (status == false) { toolStriplblStatus.Text = "Falso"; } else { toolStriplblStatus.Text = "Verdadero"; }
                } while (status != true);
                
                MessageBox.Show("La busqueda fue exitosa la sucursal es "+contador, "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void cmdBusqueda_Click_1(object sender, EventArgs e)
        {
           toolStriplblStatus.Text = " - - - ";
           this.oThread = new Thread(new ThreadStart(this.busqueda));
           this.oThread.Start();
           backgroundWorker1.RunWorkerAsync();
           this.toolStripProgressBar1.Value = contador;
           cmdBusqueda.Enabled = false;
           //toolStripProgressBar1.Maximum = contador;
           
        }

        private void button1_Click(System.Object sender, System.EventArgs e)
        {
            if (oThread.IsAlive == true) { oThread.Abort(); toolStriplblNumero.Text = "----"; toolStriplblStatus.Text = "Cancelado"; cmdBusqueda.Enabled = true; }
        }



        }

    }

