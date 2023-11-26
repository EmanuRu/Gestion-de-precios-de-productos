using System;
using Negocio;
using Entidades;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuperatorioTomasRuibal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void button1_Click(object sender, EventArgs e)//boton para agregar un nuevo producto
        {
            NProducto.Insert(tbNomProd.Text);//se envia el nombre del producto al metodo insert de la clase NProducto
            tbNomProd.Text = string.Empty;
            CargarProductos();
        }

        public List<Productos> ListaProductos()
        {
            List<Productos> lista = new List<Productos>();//se crea una lista de la clase Productos
            lista = NProducto.GetAll();//se llena la lista con el metodo GetAll de la clase NProductos
            return lista;
        }

        public void CargarProductos()
        {
            bsProductos.DataSource = ListaProductos();//carga el binding source de los productos con el metodo Lista Productos
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "")//si el campo tbNombre no esta vacio
            {
                String idString = comboBox1.SelectedValue.ToString();
                int id = int.Parse(idString);
                string desc = tbNombre.Text;
                NProducto.Update(id, desc);//se envia el id del producto, y el nuevo nombre para actualizar
                tbNombre.Text = "";
                CargarProductos();//se actualiza el comboBox de losproductos
            }
            else
            {
                MessageBox.Show("Llene el campo 'Nombre'");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar el producto?", "Borrar Precio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//se realiza una pregunta antes de borrar un producto
            {
                String idString = comboBox1.SelectedValue.ToString();
                int id = int.Parse(idString);
                NProducto.Delete(id);//se envia el id del producto sacado del comboBox al metodo delete de la clase NProducto
                CargarProductos();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El boton Agregar cargara el porducto con el \nnombre indicado en la base de datos");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El bonton Actualizar te permitira cambiar \nel nombre del producto mostrado la" +
                " lista \ndesplegable");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El bonton Eliminar te permitira borrar \nel producto mostrado la" +
               " lista desplegable, \nde la base de datos \n\n(no es necesario ingresar ninigun nombre)");
        }
    }
}
