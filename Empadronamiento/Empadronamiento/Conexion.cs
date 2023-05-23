using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Empadronamiento
{
    class ConexionBD
    {
        string cadena = "Data Source=GIDEOASCGDBTWFA\\SQL2022;Initial Catalog=Datos_Empadronamiento;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }
    public void abrir()
    {
            try
            {
                conectarbd.Open();
                Console.WriteLine("coneccion exitosa");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error a la hora de abrir la Base de Datos"+ex.Message);
            }
    }
        public void cerrar()
        {
            conectarbd.Close();
        }


    }
}
