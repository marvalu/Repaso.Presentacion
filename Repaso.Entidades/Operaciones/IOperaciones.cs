using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso.Entidades
{
   public interface IOperaciones <T>
    {

        T Buscar(string dato);
        T Buscar(int id);

        void Insertar(T item);

        void Eliminar(T item);

        void Modificar(T item);

      //  List<T> BuscarTodos();

    }
}
