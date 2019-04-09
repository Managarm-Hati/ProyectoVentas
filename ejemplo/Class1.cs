using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ejemplo
{
    class Conectarse
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;



        string cadena = "Data Source=localhost;Initial Catalog=negocio;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public Conectarse()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectarse a la base de datos " + ex.Message);
            }
        }

        //validar si un producto existe o no
        public bool Existe(int Codigo)
        {

            conectarbd.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT  COUNT(1) FROM tableVentas WHERE  Codigo =" + Codigo + "", conectarbd);
            cmd.Parameters.AddWithValue("Codigo", Codigo);
            cmd.ExecuteNonQuery();           
            int count = Convert.ToInt32(cmd.ExecuteScalar());
         
            if (count == 0)
                return false;
            else
                return true;

            
        }



        public void GuardarArticulos(int Codigo, string nombreArticulo, int Stock, int precioCompra, string Categoria)
        {
            
            SqlCommand cmd;
            cmd = new SqlCommand("INSERT INTO tableVentas(Codigo,nombreArticulo,Stock,precioCompra,fechaRegistro,Categoria) values(" + Codigo + ",'" + nombreArticulo + "'," + Stock + ", " + precioCompra + ",GETDATE(),'" + Categoria + "')", conectarbd);
            cmd.ExecuteNonQuery();           

            conectarbd.Close();
        }

        public void actualizarArticulo(int Codigo, string nombreArticulo, int Stock, int precioCompra, string Categoria)
        {
            conectarbd.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("UPDATE tableVentas set nombreArticulo='" + nombreArticulo + "',Stock=" + Stock + ",precioCompra=" + precioCompra + ",fechaRegistro=GETDATE(), Categoria ='" + Categoria + "' where Codigo=" + Codigo + "", conectarbd);
            cmd.ExecuteNonQuery();
            conectarbd.Close();

        }

        public void eliminarArticulo(int Codigo)
        {
            conectarbd.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("DELETE FROM tableVentas where codigo=" + Codigo + "", conectarbd);
            cmd.ExecuteNonQuery();
            conectarbd.Close();
        }

        public void listarTodo(DataGridView dgv)
        {
            try
            {

                da = new SqlDataAdapter("Select * from tableVentas", conectarbd);
                dt = new DataTable();
                da.Fill(dt);

                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtuvieron los datos" + ex.ToString());

            }

        }

        public void listarNombre(DataGridView dgv, string Categoria)
        {
            try
            {
                da = new SqlDataAdapter("Select * from tableVentas where Categoria = '" + Categoria + "'", conectarbd);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se obtuvieron los datos" + ex.ToString());

            }

        }

        public void llenarComboBox(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select DISTINCT Categoria  FROM tableVentas", conectarbd);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Categoria"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Categorias no encontradas" + ex.ToString());
            }
        }


        public void ExportarExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "Registro de articulos" + DateTime.Now.Date.ToShortDateString().Replace("/", "-");
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);


                hoja_trabajo.Cells[1, "A"] = grd.Columns[0].HeaderText;
                hoja_trabajo.Cells[1, "B"] = grd.Columns[1].HeaderText;
                hoja_trabajo.Cells[1, "C"] = grd.Columns[2].HeaderText;
                hoja_trabajo.Cells[1, "D"] = grd.Columns[3].HeaderText;
                hoja_trabajo.Cells[1, "E"] = grd.Columns[4].HeaderText;
                hoja_trabajo.Cells[1, "F"] = grd.Columns[5].HeaderText;

                hoja_trabajo.Columns[1].Autofit();
                hoja_trabajo.Columns[2].Autofit();
                hoja_trabajo.Columns[3].Autofit();
                hoja_trabajo.Columns[4].Autofit();
                hoja_trabajo.Columns[5].Autofit();
                hoja_trabajo.Columns[6].Autofit();

                //Recorremos el DataGridView rellenando la hoja de trabajo

                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {

                    for (int j = 0; j < grd.Columns.Count; j++)

                    {

                        if (grd.Rows[i].Cells[j].Value != null)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                        }

                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                MessageBox.Show("Registros exportados a Excel");
            }
        }

        

    } 
}
