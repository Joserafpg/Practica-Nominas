using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Practica_Nominas
{
    public class Datosbasedt
    {
        public static int Agregar (Datosget pget)
        {

            int retorno = 0;

            Conexion.opoencon();

            SqlCommand Comando = new SqlCommand(string.Format("Insert into Empleados (Nombre, Cedula, Fecha_Nacimiento, Cargo, Sueldo_bruto, ARS, AFP, Vivienda, Descuento, Sueldo_Neto  ) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", 
                    pget.Nombre, pget.Cedula, pget.Fecha_Nac, pget.Cargo, pget.Sueldo_Bruto, pget.ARS, pget.AFP, pget.Vivienda, pget.Descuento, pget.Sueldo_Neto), Conexion.ObtenerConexion());

            retorno = Comando.ExecuteNonQuery();
            Conexion.cerrarcon();
            return retorno;

        }
    } 
}
