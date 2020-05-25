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
    public partial class ConsultaPersonaFrm : Form
    {
        PersonaService personaService;
        Persona persona;
        RespuestaBusqueda respuestaBusqueda;
        public ConsultaPersonaFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            personaService = new PersonaService(connectionString);
            respuestaBusqueda = new RespuestaBusqueda();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    SexoTxt.Text = respuestaBusqueda.Persona.Sexo;
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

       

        private void button2_Click(object sender, EventArgs e)
        {

            string identificacion = IdentificacionTxt.Text;
            if(identificacion != "")
            {
                var respuesta = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                   
                    
                        string mensaje = personaService.Eliminar(IdentificacionTxt.Text);
                        MessageBox.Show(mensaje);
                        VaciarCuadrosTexto();
                    
                }
                else
                {
                    MessageBox.Show("Por favor digite la cedula de la persona a modificar y presione el boton buscar", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
               
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
