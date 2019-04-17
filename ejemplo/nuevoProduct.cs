using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Runtime.InteropServices;

namespace ejemplo
{
    public partial class nuevoProduct : Form
    {
        private string idCodigo = null;

        public nuevoProduct()
        {
            InitializeComponent();
        }

        private void nuevoProduct_Load(object sender, EventArgs e)
        {
            Conectarse conexion = new Conectarse();
            conexion.abrir();
            mostrarDatos();
            conexion.autoCompletar(txtCategoria);
        }

        #region Botones y validaciones

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();
            //if para validar que ningun campoeste vacio
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Ingrese un Registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else

            {
                if (txtNombreArticulo.Text == "")
                {
                    MessageBox.Show("Hace falta el nombre del articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else

                {
                    if (txtCategoria.Text == "")
                    {
                        MessageBox.Show("Hace falta la cetegoria del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else

                    {
                        if (txtStock.Text == "")
                        {
                            MessageBox.Show("Hace falta el stock del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        else
                        {
                            if (txtPrecio.Text == "")
                            {
                                MessageBox.Show("Porfavor ingrese el precio del producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                            else
                            {

                                //if para validar si existe el registro

                                if (n.Existe(Convert.ToInt32(txtCodigo.Text)))
                                {

                                    MessageBox.Show("Este registro ya existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }

                                else
                                {
                                    //guardar el articulo
                                    int Codigo = int.Parse(txtCodigo.Text);
                                    String nombreArticulo = txtNombreArticulo.Text;
                                    int Stock = int.Parse(txtStock.Text);
                                    int precioCompra = int.Parse(txtPrecio.Text);
                                    String Categoria = txtCategoria.Text;
                                    n.GuardarArticulos(Codigo, nombreArticulo, Stock, precioCompra, Categoria);

                                    MessageBox.Show("Registro completado");

                                    txtCodigo.Text = "";
                                    txtNombreArticulo.Text = "";
                                    txtStock.Text = "";
                                    txtPrecio.Text = "";
                                    txtCategoria.Text = "";

                                    mostrarDatos();

                                }
                            }

                        }
                    }
                }

            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            if (dataGridViewAgregar.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dataGridViewAgregar.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombreArticulo.Text = dataGridViewAgregar.CurrentRow.Cells["nombreArticulo"].Value.ToString();
                txtStock.Text = dataGridViewAgregar.CurrentRow.Cells["Stock"].Value.ToString();
                txtPrecio.Text = dataGridViewAgregar.CurrentRow.Cells["precioCompra"].Value.ToString();
                txtCategoria.Text = dataGridViewAgregar.CurrentRow.Cells["Categoria"].Value.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();



            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No se puede actualizar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (txtNombreArticulo.Text == "")
            {
                MessageBox.Show("Campo Vacio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (txtStock.Text == "")
            {
                MessageBox.Show("Campo Vacio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Campo Vacio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Campo Vacio ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

            if (n.Existe(Convert.ToInt32(txtCodigo.Text)))
            {

               
                    int Codigo = int.Parse(txtCodigo.Text);
                    String nombreArticulo = txtNombreArticulo.Text;
                    int Stock = int.Parse(txtStock.Text);
                    int precioCompra = int.Parse(txtPrecio.Text);
                    String categoria = txtCategoria.Text;

                    n.actualizarArticulo(Codigo, nombreArticulo, Stock, precioCompra, categoria);

                    MessageBox.Show("Datos actualizado");

                    txtCodigo.Text = "";
                    txtNombreArticulo.Text = "";
                    txtStock.Text = "";
                    txtPrecio.Text = "";
                    txtCategoria.Text = "";

                    mostrarDatos();
               

            }
            else
            {
                MessageBox.Show("Este registro no existe", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();
            

            if (dataGridViewAgregar.SelectedRows.Count > 0)
            {
                
                idCodigo = dataGridViewAgregar.CurrentRow.Cells["Codigo"].Value.ToString();

                if (MessageBox.Show("Seguro desea borrar este dato?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    n.eliminarArticulo(Convert.ToInt32(idCodigo));
                    

                    mostrarDatos();
                }
                else
                {
                    MessageBox.Show("Dato no eliminado", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
             
            }

        }


        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                return;
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Primera letra mayuscula
            if (txtCategoria.Text.Length == 0)

                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (txtCategoria.Text.Length > 0)

                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];



            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }


        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {


            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                return;
            }
        }


        private void txtNombreArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Primera letra mayuscula
            if (txtNombreArticulo.Text.Length == 0)

                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (txtNombreArticulo.Text.Length > 0)

                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

       

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
                return;
            }
        }
        #endregion

        private void mostrarDatos()
        {
            Conectarse n = new Conectarse();
            
            n.listarTodo(dataGridViewAgregar);
            dataGridViewAgregar.Columns[0].HeaderText = "Codigo";
            dataGridViewAgregar.Columns[1].HeaderText = "Nombre ";
            dataGridViewAgregar.Columns[2].HeaderText = "Stock";
            dataGridViewAgregar.Columns[3].HeaderText = "Precio";
            dataGridViewAgregar.Columns[4].HeaderText = "Fecha ";
            dataGridViewAgregar.Columns[5].HeaderText = "Categoria";

            this.dataGridViewAgregar.Columns[3].DefaultCellStyle.Format = "c";

            dataGridViewAgregar.EnableHeadersVisualStyles = false;

            this.dataGridViewAgregar.Columns["ID"].Visible = false;
            
        }

        private void tabVer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
