using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;
using System.Configuration;

namespace PulsacionesGUI
{
    public partial class ModificarPersonaFrm : Form
    {
        PersonaService personaService;
        Persona persona;
        public ModificarPersonaFrm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            personaService = new PersonaService(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
            string identificacion = IdentificacionTxt.Text;
            if (identificacion != "")
            {
                respuestaBusqueda = personaService.Buscar(IdentificacionTxt.Text);
                if (respuestaBusqueda.Persona != null)
                {
                    NombreTxt.Text = respuestaBusqueda.Persona.Nombre;
                    EdadTxt.Text = respuestaBusqueda.Persona.Edad.ToString();
                    SexoCmb.Text = respuestaBusqueda.Persona.Sexo;
                    PulsacionTxt.Text = respuestaBusqueda.Persona.Pulsacion.ToString();
                    MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            else
            {
                MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(respuesta == DialogResult.Yes)
            {
                RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();

                respuestaBusqueda = personaService.Buscar(IdentificacionTxt.Text);
                if (respuestaBusqueda.Persona != null)
                {
                    Persona persona = new Persona();
                    persona.Identificacion = IdentificacionTxt.Text;
                    persona.Nombre = NombreTxt.Text;
                    persona.Edad = int.Parse(EdadTxt.Text);
                    persona.Sexo = SexoCmb.Text;
                    persona.CalcularPulsacion();
                    PulsacionTxt.Text = persona.Pulsacion.ToString();
                    string mensaje = personaService.Modificar(persona);
                    MessageBox.Show(mensaje);
                }
          
                
            }
        }
    }
}
