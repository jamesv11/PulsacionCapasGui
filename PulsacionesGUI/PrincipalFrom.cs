using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersonaFrm registroPersonaFrm = new RegistroPersonaFrm();
            registroPersonaFrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPersonaFrm consultaPersonaFrm = new ConsultaPersonaFrm();
            consultaPersonaFrm.Show();
        }

        private void consultarTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPersonasFrm consultarPersonasFrm = new ConsultarPersonasFrm();
            consultarPersonasFrm.Show();
        }
    }
}
