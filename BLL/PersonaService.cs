using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;



namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;
        private readonly ConnectionManager conexion;

        public PersonaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            personaRepository = new PersonaRepository(conexion);

        }
        public string Guardar(Persona persona)
        {

            {
                try
                {
                    persona.CalcularPulsacion();
                    conexion.Open();
                    personaRepository.Guardar(persona);
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente";
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}";
                }
                finally { conexion.Close(); }
            }
        }


        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var persona = personaRepository.BuscarPorIdentificacion(identificacion);
                if (persona != null)
                {
                    personaRepository.Eliminar(persona);
                    conexion.Close();
                    return ($"El registro {persona.Nombre} se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }


        }

        public string Modificar(Persona persona)
        {
            try
            {
                conexion.Open();
                var personaVieja = personaRepository.BuscarPorIdentificacion(persona.Identificacion);
                conexion.Close();
                if (personaVieja != null)
                {
                    conexion.Open();
                    personaRepository.Modificar(persona);
                    conexion.Close();
                    return ($"El registro {persona.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, {persona.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public RespuestaBusqueda Buscar(string identificacion)
        {
            RespuestaBusqueda respueta = new RespuestaBusqueda();

            try
            {
                conexion.Open();
                respueta.Persona = personaRepository.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respueta.Mensaje = (respueta.Persona != null) ? "Se encontro la persona buscada" : "La persona no existe";
                respueta.Error = false;
                return respueta;

            }
            catch (Exception e )
            {

                respueta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respueta.Error = true;
                return respueta;
            }
            finally { conexion.Close(); }
        }


        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {

                conexion.Open();
                respuesta.Personas = personaRepository.Consultar();
                conexion.Close();
                if (respuesta.Personas.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }


        }
        public int ObtenerTotal()
        {
            return personaRepository.ObtenerCantidadPersonas();
        }

        public int ObtenerCantidadPersonas(string tipo)
        {
            try
            {
                return personaRepository.ObtenerCantidadPersonas(tipo);
            }
            catch (Exception)
            {

                throw;
            }
            finally { conexion.Close(); }
            
        }
        
        public IList<Persona> ObtenerPersonas(string tipo)
        {
            try
            {
                conexion.Open();
                return personaRepository.ConsultarPersonas(tipo);
            }
            catch (Exception )
            {

                throw;
            }
            finally { conexion.Close(); }
            
            
        }
       



        }


        public class RespuestaBusqueda
        {
            public string Mensaje { get; set; }
            public Persona Persona { get; set; }
            public bool Error { get; set; }
        }



        public class RespuestaConsulta
        {
            public string Mensaje { get; set; }
            public IList<Persona> Personas { get; set; }
            public bool Error { get; set; }
        }




    }




