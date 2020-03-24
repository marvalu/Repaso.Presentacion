using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Presentacion;
using Repaso.Entidades;


namespace Repaso.LogicaNegocios
{
    public class Operaciones
    {
        List<Persona> personaList = new List<Persona>();
        OperacionesPersona operacionesPersona = new OperacionesPersona();
        public void CrearPersonas(Persona persona) {



            personaList.Add(persona);

            operacionesPersona.Insertar(persona);


        }


        public void Eliminar(Persona persona) {



            operacionesPersona.Eliminar(persona);
        }


        public Persona modificar(int dato) {



            return (operacionesPersona.Buscar(dato));
        
        }

    }
}
