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

namespace PulsacionesGUI
{
    public partial class ModificarPersonaFrm : Form
    {
        public ModificarPersonaFrm()
        {
            InitializeComponent();
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

            PersonaService personaService = new PersonaService();
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();

            respuestaBusqueda = personaService.Buscar(IdentificacionTxt.Text);
            if (respuestaBusqueda.Persona != null)
            {
                NombreTxt.Text = respuestaBusqueda.Persona.Nombre;
                EdadTxt.Text = respuestaBusqueda.Persona.Edad.ToString();
                SexoCmb.Text = respuestaBusqueda.Persona.Sexo;
                PulsacionTxt.Text = respuestaBusqueda.Persona.Pulsacion.ToString();
            }


            string mensaje = respuestaBusqueda.Mensaje;

            MessageBox.Show(mensaje);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaService personaService = new PersonaService();
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
