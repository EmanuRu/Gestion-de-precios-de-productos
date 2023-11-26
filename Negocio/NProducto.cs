using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NProducto
    {
        public static void Insert(string desc) {
            DProductos.Insert(desc);//se envia la descripcion al metodo Insert de la clase DProducto
        }

        public static List<Productos> GetAll() {
            List<Productos> lista = new List<Productos>();//se crea una lista de las clase Producto
            lista = DProductos.GetAll();//se la llena con los productos obtenidos del metodo GetAll de la clase DProductos
            return lista;//se devuelve la lista llena
        }

        public static void Update(int id, string desc){
            DProductos.Update(id, desc);//se envian el id y la descripcion al metodo Update de la clase DProducto
        }

        public static void Delete(int id)
        {
            DProductos.Delete(id);//se envia el id al metodo Delete de la clase DProducto

        }

    }
}
