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
    public partial class ConsultaPersonaFrm : Form
    {
        public ConsultaPersonaFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VaciarCuadrosTexto();

            PersonaService personaService = new PersonaService();
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();

            respuestaBusqueda = personaService.Buscar(IdentificacionTxt.Text);
            if (respuestaBusqueda.Persona != null)
            {
                NombreTxt.Text = respuestaBusqueda.Persona.Nombre;
                EdadTxt.Text = respuestaBusqueda.Persona.Edad.ToString();
                SexoTxt.Text = respuestaBusqueda.Persona.Sexo;
                PulsacionTxt.Text = respuestaBusqueda.Persona.Pulsacion.ToString();
            }


            string mensaje = respuestaBusqueda.Mensaje;

            MessageBox.Show(mensaje);


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaService personaService = new PersonaService();
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
            respuestaBusqueda = personaService.Buscar(IdentificacionTxt.Text);
            if(respuestaBusqueda.Persona != null)
            {
                string mensaje = personaService.Eliminar(IdentificacionTxt.Text);
                MessageBox.Show(mensaje);
                VaciarCuadrosTexto();
            }
            

            
        }
        private void VaciarCuadrosTexto()
        {
            
            NombreTxt.Clear();
            EdadTxt.Clear();
            SexoTxt.Clear();
            PulsacionTxt.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarPersonaFrm modificarPersonaFrm = new ModificarPersonaFrm();
            modificarPersonaFrm.Show();
        }
    }
}
