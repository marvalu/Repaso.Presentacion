using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repaso.AccesoDatos;

namespace Repaso.Entidades
{
    public class OperacionesPersona : IOperaciones<Persona>
    {

        Coneccion coneccion = new Coneccion();
        public Persona Buscar(string dato)
        {


            string Sqlstring = string.Format("select * from Persona where nombre like '{0}' ", dato);


            SqlDataReader SQLTemporal = coneccion.QueryUsing(Sqlstring);
            if (SQLTemporal != null && SQLTemporal.HasRows)
            {

                while (SQLTemporal.Read())
                {

                    return new Persona(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim());

                }


            }

            return null;
        }

        public Persona Buscar(int id)
        {

            string Sqlstring = string.Format("select * from Persona where id={0}", id);


            SqlDataReader SQLTemporal = coneccion.QueryUsing(Sqlstring);
            if (SQLTemporal != null && SQLTemporal.HasRows)
            {

                while (SQLTemporal.Read())
                {

                    return new Persona(SQLTemporal.GetInt32(0), SQLTemporal.GetString(1).Trim(), SQLTemporal.GetString(2).Trim(), SQLTemporal.GetString(3).Trim());

                }


            }
            return null;
        }

        public void Eliminar(Persona item)
        {

            string Sqlstring = string.Format("delete * from Persona where id={0}", item.Id);

            coneccion.nonQueryUsing(Sqlstring);

        }

        public void Insertar(Persona item)
        {


            string Sqlstring = string.Format("INSERT INTO[dbo].[Persona]([nombre],[apellido],[cedula]) VALUES ('{0}','{1}','{2}')", item.Nombre, item.Apellido, item.Cedula);
            coneccion.nonQueryUsing(Sqlstring);
        }
        public void Modificar(Persona item)
        {
            string Sqlstring = string.Format("UPDATE[dbo].[Persona] SET [nombre]='{0}',[apellido] ='{1}',[cedula] ='{2}' WHERE id={3}", item.Nombre, item.Apellido, item.Cedula, item.Id);
            coneccion.nonQueryUsing(Sqlstring);
        }
    }
}
