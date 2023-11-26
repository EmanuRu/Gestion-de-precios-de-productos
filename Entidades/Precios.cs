using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Precios
    {
        public int id { get; set; }
        public DateTime Date { get; set; }

        public int Monto { get; set;}

        public int idProducto { get; set;}

        public Productos productos { get; set;}//se crea un objeto de la clase Productos para despues guadar la descripcion del producto
        public string? NombreProducto//la funcion de esta variable es recibir la descripcion de producto, que esta en la clase Producto
        {
            get
            {
                if (productos != null)//si productos no esta vacio
                    return productos.descripcion;//la variable NombreProducto va a contener la descripcion
                else
                    return null;
            }
        }

    }
}
