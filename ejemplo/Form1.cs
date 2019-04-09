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




namespace ejemplo
{
    public partial class Form1 : Form 
    {


        public Form1()
        {
            InitializeComponent();
        }


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

                                    }
                                }
                            
                        }
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conectarse conexion = new Conectarse();
            conexion.abrir();
            conexion.llenarComboBox(cbxListarCategoria);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Dato no actualizado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                Conectarse n = new Conectarse();
                int Codigo = int.Parse(txtCodigo.Text);
                String nombreArticulo = txtNombreArticulo.Text;
                int Stock = int.Parse(txtStock.Text);
                int precioCompra = int.Parse(txtPrecio.Text);
                String categoria = txtCategoria.Text;


                n.actualizarArticulo(Codigo, nombreArticulo, Stock, precioCompra, categoria);

                MessageBox.Show("Dato actualizado");

                txtCodigo.Text = "";
                txtNombreArticulo.Text = "";
                txtStock.Text = "";
                txtPrecio.Text = "";
                txtCategoria.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Dato no eliminado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conectarse n = new Conectarse();
                int Codigo = int.Parse(txtCodigo.Text);



                n.eliminarArticulo(Codigo);

                MessageBox.Show("Dato eliminado");

                txtCodigo.Text = "";

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //..............

            // dataGridView2 = new System.Windows.Forms.DataGridView();
            //  Controls.Add(dataGridView2);

            //   this.dataGridView2.Columns("precioCompra").DefaultCellStyle.Format = "C2";
        }



        public void formatoDinero()
        {
            
          // dataGridView2.Columns("ValorCompra").DefaultCellStyle.Format = "C2";
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();
            
            n.listarTodo(dataGridView2);
            dataGridView2.Columns[0].HeaderText = "Codigo";
            dataGridView2.Columns[1].HeaderText = "Nombre Articulo";
            dataGridView2.Columns[2].HeaderText = "Stock";
            dataGridView2.Columns[3].HeaderText = "Precio";
            dataGridView2.Columns[4].HeaderText = "Fecha de Registro";
            dataGridView2.Columns[5].HeaderText = "Categoria";

            this.dataGridView2.Columns[3].DefaultCellStyle.Format = "c";


        }

        private void btnListarNombre_Click(object sender, EventArgs e)
        {
            if (cbxListarCategoria.Text == "")
            {
                MessageBox.Show("Campo vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conectarse n = new Conectarse();              
              //  int Codigo = int.Parse(txtBuscador.Text);
                String Categoria =  cbxListarCategoria.Text;

                n.listarNombre(dataGridView2,Categoria);  
                
            }
            
            
        }

        private void tbRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
                 
              
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



            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) &&  !(char.IsWhiteSpace(e.KeyChar))  )
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

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
          //  txtPrecio.Text = Format(txtPrecio, "$#,##0.00");
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView2_ColumnHeaderCellChanged(object sender, DataGridViewColumnEventArgs e)
        {
            
        }

        private void dataGridView2_ColumnNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Primera letra mayuscula
            if (txtNombreArticulo.Text.Length == 0)

                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];

            else if (txtNombreArticulo.Text.Length > 0)

                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();
            n.ExportarExcel(dataGridView2);
        }

        private void tabVer_Click(object sender, EventArgs e)
        {
           
        }

        public void ExportarPDF(DataGridView dgv, string filename)
        {
            
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
           pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);

                iTextSharp.text.Font pTipoLetra = iTextSharp.text.FontFactory.GetFont(FontFactory.COURIER, 13);

            


            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);

                pdfTable.AddCell(cell);

            }

            //Adding DataRow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Agregar datos al principio de pagina PDF

            var espacioBlanco = new Paragraph("")
            {
               SpacingBefore = 10f,
               SpacingAfter=10f,

            };

            string remito = "Nombre: Reporte de Articulos";
            string envio = "Fecha: " + DateTime.Now.ToString();

            //Exporting to PDF
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = "Reporte de articulos"; 
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph(remito,FontFactory.GetFont("ARIAL",15)));
                    pdfDoc.Add(new Paragraph(envio, FontFactory.GetFont("ARIAL",15)));
                    pdfDoc.Add(espacioBlanco);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Registros exportados a PDF");
                }

            }
        }

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {

            ExportarPDF(dataGridView2, "test");
           
        }
    }
}
