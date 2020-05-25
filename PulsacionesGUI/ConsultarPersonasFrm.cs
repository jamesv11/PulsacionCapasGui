using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        PersonaService personaService;
        public ConsultarPersonasFrm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            personaService = new PersonaService(connectionString);
        }

        private void ConsultarBtm_Click(object sender, EventArgs e)
        {

            RespuestaConsulta respuesta = new RespuestaConsulta();

            string tipo = OpcionCmb.Text;
            if(tipo == "General")
            {
                TablaTgb.DataSource = null;
                respuesta = personaService.Consultar();
                TablaTgb.DataSource = respuesta.Personas;
               
                
            }
            else if (tipo == "Hombres")
            {
                TablaTgb.DataSource = null;
                
                respuesta.Personas = personaService.ObtenerPersonas("M");
                TablaTgb.DataSource = respuesta.Personas;


            }
            else
            {
                TablaTgb.DataSource = null;
               
                respuesta.Personas = personaService.ObtenerPersonas("F");
                TablaTgb.DataSource = respuesta.Personas;


            }

            MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
