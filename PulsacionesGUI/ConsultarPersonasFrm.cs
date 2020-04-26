using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace PulsacionesGUI
{
    public partial class ConsultarPersonasFrm : Form
    {
        PersonaService personaService = new PersonaService();
        RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
        public ConsultarPersonasFrm()
        {
            InitializeComponent();
        }

        private void ConsultarBtm_Click(object sender, EventArgs e)
        {
            
            if (OpcionCmb.Text == "General")
            {
                TablaTgb.DataSource = null;
                respuestaConsulta = personaService.Consultar();
                TablaTgb.DataSource = respuestaConsulta.Personas;
            }
            else if (OpcionCmb.Text == "Hombres")
            {
                TablaTgb.DataSource = null;
                respuestaConsulta = personaService.Consultar();
                TablaTgb.DataSource = personaService.CantidadHombres();
            }
            else
            {
                TablaTgb.DataSource = null;
                respuestaConsulta = personaService.Consultar();
                TablaTgb.DataSource = personaService.CantidadMujeres();
            }
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
