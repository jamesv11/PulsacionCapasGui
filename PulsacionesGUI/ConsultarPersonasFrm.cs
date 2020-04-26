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
            TablaTgb.DataSource = null;
            respuestaConsulta =  personaService.Consultar();
            TablaTgb.DataSource = respuestaConsulta.Personas;
            

        }
    }
}
