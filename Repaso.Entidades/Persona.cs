using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entidades
{
   public class Persona
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _cedula;


        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }

        public Persona()
        {

        }

        public Persona(int id, string nombre, string apellido, string cedula)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
        }


        public void Insertar() {

            OperacionesPersona operacionesPersona = new OperacionesPersona();

            operacionesPersona.Insertar(this);
        
        }

        public void Eliminar() {

            OperacionesPersona operacionesPersona = new OperacionesPersona();

            operacionesPersona.Eliminar(this);

        }

        public void Modificar() {

            OperacionesPersona operacionesPersona = new OperacionesPersona();
            operacionesPersona.Modificar(this);

        }



        
    }
}
