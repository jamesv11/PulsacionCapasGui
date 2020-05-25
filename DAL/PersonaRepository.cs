using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class PersonaRepository
    {
        //private string ruta = @"Persona.txt";
        private readonly SqlConnection _connection;
        private IList<Persona> personas = new List<Persona>();
        public PersonaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }
        public void Guardar(Persona persona)
        
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO Persona(Identificacion,Nombre,Sexo,Edad,Pulsacion)
                                        Values (@Identificacion,@Nombre,@Sexo,@Edad,@Pulsacion)";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Sexo", persona.Sexo);
                command.Parameters.AddWithValue("@Edad", persona.Edad);
                command.Parameters.AddWithValue("@Pulsacion", persona.Pulsacion);
                var filas = command.ExecuteNonQuery();

            }

        }

        public IList<Persona> Consultar()
        {
            SqlDataReader dataReader;
            List<Persona> personas = new List<Persona>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from persona ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Persona persona = DataReaderMapToPerson(dataReader);
                        personas.Add(persona);
                    }
                }
            }
            return personas;
        }
        private Persona DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Persona persona = new Persona();
            persona.Identificacion = (string)dataReader["Identificacion"];
            persona.Nombre = (string)dataReader["Nombre"];
            persona.Sexo = (string)dataReader["Sexo"];
            persona.Edad = (int)dataReader["Edad"];
            persona.Pulsacion = (decimal)dataReader["Pulsacion"];
            return persona;
        }


        public void Eliminar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from persona where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.ExecuteNonQuery();
            }
        }


        public void Modificar(Persona persona)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update persona set nombre=@Nombre, edad=@Edad, sexo=@Sexo, pulsacion=@Pulsacion where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", persona.Identificacion);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Sexo", persona.Sexo);
                command.Parameters.AddWithValue("@Edad", persona.Edad);
                command.Parameters.AddWithValue("@Pulsacion", persona.Pulsacion);
                command.ExecuteNonQuery();
            }
        }

        public Persona BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from persona where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }
        public int ObtenerCantidadPersonas()
        {

            return personas.Count();
            
        }

        public int ObtenerCantidadPersonas(string tipo)
        {
            return  personas.Where(persona => persona.Sexo.Equals(tipo)).Count();
        }

      
        public IList<Persona> ConsultarPersonas(string tipo)
        {
            return Consultar().Where(personas => personas.Sexo.Equals(tipo)).ToList();
        }
        
    }
}
