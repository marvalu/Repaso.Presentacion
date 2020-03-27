using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Presentacion;
using Repaso.Entidades;
using System.Data.SqlClient;
using Repaso.AccesoDatos;


namespace Repaso.LogicaNegocios
{
    public class Operaciones
    {
        Coneccion coneccion = new Coneccion();
        Persona persona = new Persona();
        List<Persona> personaList = new List<Persona>();
        OperacionesPersona operacionesPersona = new OperacionesPersona();
        public void CrearPersonas(Persona persona) {


            //coneccion.CreaConexion();
            personaList.Add(persona);

            operacionesPersona.Insertar(persona);
            //coneccion.CerrarConexion();

        }


        public void Eliminar(int id) {

            try
            {
                operacionesPersona.Eliminar(persona);

                if (persona is null) {
                    Console.WriteLine("Valor nulo");

                }
                

                

            }
            catch (Exception)
            {

                Console.WriteLine("Valor nulo");
            }
            
        }


        public void modificar(int id, string nombre, string apellido, string ced) {

            
           // Boolean modifica;
            
            persona=operacionesPersona.Buscar(id);


            if (persona.Apellido != apellido)
            {
                persona.Apellido = apellido;
            }


            if (persona.Nombre != nombre)
            {
                persona.Nombre = nombre;
            }

            if (persona.Cedula != ced)
            {
                persona.Apellido = ced;
            }

          
           // return modifica=true;
        
        }


        //public SqldataReader Actualizar()
        //{


        //    operacionesPersona.MostrarTodo();
        //    return null;
        //}

    }
}
