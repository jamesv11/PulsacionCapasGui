﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entity;
namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = @"Persona.txt";
        private IList<Persona> personas;
        public PersonaRepository()
        {
            personas = new List<Persona>();
        }
        public void Guardar(Persona persona)
        
        {
            FileStream fileStream = new FileStream(ruta,FileMode.Append);
            StreamWriter stream = new StreamWriter (fileStream);
            stream.WriteLine(persona.ToString());
            stream.Close();
            fileStream.Close();
            
        }

        public IList<Persona> Consultar()
        {
            personas.Clear();
            
            
            FileStream fileStream = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(fileStream);
            string linea = string.Empty;
            while((linea=lector.ReadLine())!=null)
            {
                Persona persona = new Persona();
                string[] datos = linea.Split(';');
                persona.Identificacion = datos[0];
                persona.Nombre = datos[1];
                persona.Edad = int.Parse(datos[2]);
                persona.Sexo = datos[3];
                persona.Pulsacion = Convert.ToDecimal(datos[4]);
                personas.Add(persona);
            }
            fileStream.Close();
            lector.Close();
            return personas;
        }


        public void Eliminar(string identificacion)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion!=identificacion)
                {
                    Guardar(item);
                }
            }

        }

        public void Modificar(Persona persona)
        {
            personas.Clear();
            personas = Consultar();
            FileStream fileStream = new FileStream(ruta, FileMode.Create);
            fileStream.Close();
            foreach (var item in personas)
            {
                if (item.Identificacion != persona.Identificacion)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(persona);
                }
            }   

        }

        public Persona Buscar(string identificacion) 
        {
            personas.Clear();
            personas = Consultar();
            Persona persona = new Persona();
            foreach (var item in personas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        public int ObtenerCantidadPersonas()
        {

            return personas.Count();
            
        }

        public int ObtenerCantidadMujeres()
        {
            return  personas.Where(persona => persona.Sexo.Equals("F")).Count();
        }

        public int ObtenerCantidadHombre()
        {
            return personas.Where(persona => persona.Sexo.Equals("M")).Count();
        }
        public IList<Persona> ConsultarMujeres()
        {
            return personas.Where(personas => personas.Sexo.Equals("F")).ToList();
        }
        public IList<Persona> ConsultarHombres()
        {
            return personas.Where(personas => personas.Sexo.Equals("M")).ToList();
        }
    }
}
