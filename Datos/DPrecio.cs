using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DPrecio
    {
        public static void Insert(DateTime fecha, int monto, int idProd) {
            try {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].
                    ConnectionString;//string que tiene el nombre de la conexion del Appconfig
                SqlConnection con = new SqlConnection(conString);//se crea un objeto SQlConnection con, conString
                SqlCommand conCommand = new SqlCommand("PreciosInsert", con);//se crea un comando indcando en parentesis el nombre del procedimiento, y el string de la conexion
                conCommand.CommandType = System.Data.CommandType.StoredProcedure;//se indica que el comando es un procedimiento almacenado
                conCommand.Parameters.AddWithValue("@fecha", fecha);//se cargan los parametros que van a ser enviados a la base de datos usando al comando
                conCommand.Parameters.AddWithValue("@monto", monto);
                conCommand.Parameters.AddWithValue("@idProd", idProd);
                con.Open();//se abre la conexion con la base de datos
                conCommand.ExecuteNonQuery();//se ejecuta la consulata (enviar los parametros)
                con.Close();//se cierra la conexion

            }
            catch (Exception) {
                throw;
            }
        }

        //los comando siguientes son muy parecidos asi que solo voy a comentar las diferencias de los demas
        public static List<Precios> GetAll() { 
            List<Precios> lista = new List<Precios>();//se crea una lista del Precios

            try 
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].
                    ConnectionString;
                SqlConnection con = new SqlConnection( conString);
                SqlCommand conCommand = new SqlCommand("PreciosGetAll", con);
                conCommand.CommandType= System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader=conCommand.ExecuteReader();//se crea un "reader" el cual va a leer todos los registros de la base de datos
                while (reader.Read())
                {
                    Precios precios = new Precios();// se crea un objeto de la clase precios para que se guarde en la lista
                
                    precios.id = Convert.ToInt32(reader["id"]);
                    precios.Date = Convert.ToDateTime(reader["fecha"]);
                    precios.Monto = Convert.ToInt32(reader["monto"]);
                    precios.idProducto = Convert.ToInt32(reader["idProducto"]);//se cargan los datos de la base de datos al objeto
                    Productos prod = new Productos();// se crea un objeto de la clase productos
                    prod.id = Convert.ToInt32(reader["id"]);//se guardan los datos del objeto de dicha clase
                    prod.descripcion = Convert.ToString(reader["descripcion"]);
                    precios.productos = prod;//y se los envia a la clase Precios, donde hay un objeto de la clase productos

                    lista.Add(precios);
                }
                con.Close() ;
            } 
            catch (Exception)
            {
                throw;
            }

            return lista;

        }

        public static void Delete(int id) {
            try 
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].
                    ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand conCommand = new SqlCommand("PreciosDelete", con);
                conCommand.CommandType = System.Data.CommandType.StoredProcedure;
                conCommand.Parameters.AddWithValue("@id", id);//se envia el ide del producto que se va a eliminar
                con.Open();
                conCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception) 
            {
                throw;
            }
        
        }

        public static void Update(int id, int monto,DateTime fecha, int idProducto) {
            try 
            {
                string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].
                    ConnectionString;
                SqlConnection con = new SqlConnection( conString);
                SqlCommand conCommand = new SqlCommand("PreciosUpdate", con);
                conCommand.CommandType=System.Data.CommandType.StoredProcedure;
                conCommand.Parameters.AddWithValue("@id",id);//se envian los datos del precio que se va a actualizar
                conCommand.Parameters.AddWithValue("@fecha", fecha);
                conCommand.Parameters.AddWithValue("@monto", monto);
                conCommand.Parameters.AddWithValue("@idProducto", idProducto);
                con.Open();
                conCommand.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
