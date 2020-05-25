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
using Entity;

namespace PulsacionesGUI
{
    public partial class RegistroPersonaFrm : Form
    {
        PersonaService personaService;

        public RegistroPersonaFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            personaService = new PersonaService(connectionString);
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = IdentificacionTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.Edad = int.Parse(EdadTxt.Text);
            persona.Sexo = SexoCmb.Text;
            persona.CalcularPulsacion();
            PulsacionTxt.Text = persona.Pulsacion.ToString();
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            IdentificacionTxt.Clear();
            NombreTxt.Clear();
            EdadTxt.Clear();
            SexoCmb.Text = null;
            PulsacionTxt.Clear();
        }
    }
}
