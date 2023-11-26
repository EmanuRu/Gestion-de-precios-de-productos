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
using System.Windows.Forms.VisualStyles;

namespace RecuperatorioTomasRuibal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarListaProductos();
            CargarListaPrecios();
        }

        public void cargarListaProductos()//metodo para cargar los combo box de los precios
        {

            List<Productos> lista = new List<Productos>();
            lista = NProducto.GetAll();//se llama al metodo getall de la clase NProducto de la capa de negocios
            bsProd.DataSource = null;
            bsProd.DataSource = lista;//la lista obtenida del getall se carga en el binding source

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form formuProductos = new Form2();
            formuProductos.Show();
        }

        public void CargarListaPrecios()//actualiza el binding source
        {
            bsPrecio.DataSource = NPrecio.GetAll();
            dataGridView1.DataSource = bsPrecio;
        }

        private void button2_Click(object sender, EventArgs e)//boton para insertar precios
        {
            String idString = comboBox1.SelectedValue.ToString();//toma id del valor seleccionado
            int id = int.Parse(idString);//lo convierte en entero
            DateTime fecha = dtpFecha.Value.Date;
            int monto = int.Parse(tbMonto.Text);
            NPrecio.Insert(fecha, monto, id);//los valores del los campos fecha monto y id son enviados a la
                                             //capa de negocios
            CargarListaPrecios();//se actualiza el binding source
            tbMonto.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//boton para eliminar un precio
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que quieres eliminar el precio?", "Borrar Precio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)//se realiza una pregunta antes de borrar un precio
            {
                if (tbPrecioEdit.Text != "")//se corrobora que tbPrecioEdit (donde esta el codigo del precio)
                {                           //no este vacio
                    int id = int.Parse(tbPrecioEdit.Text);
                    NPrecio.Delete(id);//se envia el id a la clase NPrecio de la capa negocio
                    tbPrecioEdit.Text = "";
                    CargarListaPrecios();//se actualiza el binding source
                }
                else
                {
                    MessageBox.Show("El codigo del precio esta vacio");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)//boton para actualizar los precios
        {
            if (tbPrecioEdit.Text != "")
            {
                int id = int.Parse(tbPrecioEdit.Text);//tomo los datos que se encuentran al lado derecho
                String idString = comboBoxEdit.SelectedValue.ToString();
                int idProducto = int.Parse(idString);
                DateTime fecha = dateTimePickerEdit.Value.Date;
                int monto = int.Parse(tbMontoEdit.Text);
                NPrecio.Update(id, monto, fecha, idProducto);//y los envio al metodo Update de la clase NPrecio
                CargarListaPrecios();//actualizo el binding source de los precios
                tbPrecioEdit.Text = "";//limpio los campos
                tbMontoEdit.Text = "";
            }
            else
            {
                MessageBox.Show("Ingresa el codigo del producto");
            }
        }

        private void button5_Click(object sender, EventArgs e)//boton para mostrar los cambios hechos en
        {                                                     //Gestionar Productos
            cargarListaProductos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El boton Gestionar Productos Abrira la ventana \ndel mismo nombre," +
                "donde podra: agregar, \nactualizar y eliminar los productos");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton te permite actualizar cualquier cambio relizado en la ventana" +
                " Gestionar Productos, para reflejarlos en las listas deplegables");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este boton te permite cargar los datos del precio (fecha y monto), asignados" +
                " a un determinado producto seleccionado de la lista desplegable, a la base de datos\n\n" +
                "(los cambios se veran reflejados en la grilla de abajo)");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El boton Actualizar te permite modificar los campos monto y fecha, al igual" +
                "que seleccionar un nuevo producto al que pretenecera el precio, para indicar el precio" +
                "hay que colocar su numero de codigo en el campo *Codigo del Precio*");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El boton Eliminar te permitira borrar un precio indicado de la base de datos\n\n" +
                "(solo hace falta indicar el numero del producto en el campo *Codigo del Precio* para eliminarlo)");
        }
    }
}
