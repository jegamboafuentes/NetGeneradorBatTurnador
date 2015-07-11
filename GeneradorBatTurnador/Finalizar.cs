using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneradorBatTurnador
{
    public partial class Finalizar : Form
    {
        public Finalizar()
        {
            InitializeComponent();
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
