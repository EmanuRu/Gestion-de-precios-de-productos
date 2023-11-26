using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DProductos
    {

        public static void Insert(string desc)
        {

            try
            {
                string conexion = System.Configuration.ConfigurationManager.
                    ConnectionStrings["conexion"].ConnectionString;//string que tiene el nombre de la conexion del Appconfig
                SqlConnection connection = new SqlConnection(conexion);//se crea un objeto SQlConnection con, conString
                SqlCommand command = new SqlCommand("ProductosInsert", connection);//se crea un comando indcando en parentesis el nombre del procedimiento, y el string de la conexion
                command.CommandType = System.Data.CommandType.StoredProcedure;//se indica que el comando es un procedimiento almacenado
                command.Parameters.AddWithValue("@descripcion", desc);//se cargan los parametros que van a ser enviados a la base de datos usando al comando
                connection.Open();//se abre la conexion con la base de datos
                command.ExecuteNonQuery();//se ejecuta la consulata (enviar los parametros)
                connection.Close();//se cierra la conexion
            }
            catch
            {
                throw;
            }
        }

        //los comando siguientes son muy parecidos asi que solo voy a comentar las diferencias de los demas
        public static Productos GetById(int id)
        {
            Productos prod = new Productos(); //se crea un objeto de la clase productos que va a se cargados, si es que se encuenta en la base de datos

            try
            {
                string stringCon = System.Configuration.ConfigurationManager.ConnectionStrings["ProductosGetId"]
                    .ConnectionString;
                SqlConnection connection = new SqlConnection(stringCon);
                SqlCommand command = new SqlCommand("ProductosGetId", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);//se envia el id que se va a comprobar si esta en la base de datos
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    prod.id = Convert.ToInt32(reader["id"]);//se cargan los datos en el objeto
                    prod.descripcion = reader["descripcion"].ToString();
                }

                connection.Close();
            }
            catch
            {
                throw;
            }
            return prod;//se devuelve el objeto
        }

        public static List<Productos> GetAll()
        {
            List<Productos> prod = new List<Productos>();//se crea una lista de la clase Productos
            try
            {
                string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("ProductosGetAll", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();//se crea un "reader" el cual va a leer todos los registros de la base de datos
                while (reader.Read())
                {
                    Productos producto = new Productos();// se crea un objeto de la clase productos para que se guarde en la lista
                    producto.id = Convert.ToInt32(reader["id"]);//se cargan los datos de la base de datos al objeto
                    producto.descripcion = reader["descripcion"].ToString();
                    prod.Add(producto);//se agrega el objeto a la lista
                }
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return prod;//se retorna la lista
        }

        public static void Update(int id, string desc)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.
                    ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("ProductosUpdate", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);//se envian los datos para indicarle a la base de datos que producto se va a actualizar
                command.Parameters.AddWithValue("@descripcion", desc);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                string conexion = System.Configuration.ConfigurationManager.
                    ConnectionStrings["conexion"].ConnectionString;
                SqlConnection connection = new SqlConnection(conexion);
                SqlCommand command = new SqlCommand("ProductosDelete", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);//se envia el id para indicarle a la base de datos que producto se va a eliminar
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
