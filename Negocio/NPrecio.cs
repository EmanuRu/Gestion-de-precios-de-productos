using Entidades;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NPrecio
    {
        public static void Insert(DateTime fecha, int monto, int idProd) {
            DPrecio.Insert(fecha,monto,idProd);//envio los datos para insertar la clase DPrecio de la capa datos 
        }

        public static List<Precios> GetAll() { 
            List<Precios> list = DPrecio.GetAll();//lleno una lista con los datos de los precios obtenidos del
                                                  //metodo GetAll
            return list;//retorno la lista cargada
        }

        public static void Delete(int id) { 
            DPrecio.Delete(id);//envio el id a la clase DPrecio de la capa Datos
        }

        public static void Update(int id, int monto, DateTime fecha, int idProducto) {
            DPrecio.Update(id,monto,fecha,idProducto);//envio los datos para actualizar el precio a la clase
                                                      //DPrecio de la capa Datos
        }
    }
}
