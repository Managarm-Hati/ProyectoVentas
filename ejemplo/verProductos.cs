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
    public partial class verProductos : Form
    {
        public verProductos()
        {
            InitializeComponent();
        }

        private void verProductos_Load(object sender, EventArgs e)
        {
            Conectarse conexion = new Conectarse();
            conexion.abrir();
            conexion.llenarComboBox(cbxListarCategoria);
            listarAutomatico();
            this.dataGridView2.Columns["ID"].Visible = false;
        }

        private void listarAutomatico()
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

            dataGridView2.EnableHeadersVisualStyles = false;
        }

       

        private void btnListarNombre_Click(object sender, EventArgs e)
        {
            if (cbxListarCategoria.Text == "Categorias")
            {
                MessageBox.Show("Seleccione una categoria", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conectarse n = new Conectarse();
                //  int Codigo = int.Parse(txtBuscador.Text);
                String Categoria = cbxListarCategoria.Text;

                n.listarNombre(dataGridView2, Categoria);
                dataGridView2.EnableHeadersVisualStyles = false;

            }
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

        //exportar a excel
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();
            n.ExportarExcel(dataGridView2);
        }

        //exporta a PDF
        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            ExportarPDF(dataGridView2, "test");
        }


        private void cbxListarCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            cbxListarCategoria.FlatStyle = FlatStyle.Flat;
          //  Color.border
               // = Color.FromArgb(222, 144, 71);
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

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "Stock")
            {
                if (Convert.ToInt32(e.Value) <= 15)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(58, 99, 44);
                
                }
                if (Convert.ToInt32(e.Value) <= 10)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(204, 141, 24);
                    
                }
                if (Convert.ToInt32(e.Value) <= 5)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.FromArgb(209, 31, 31);
                    
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
