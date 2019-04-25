using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;


namespace ejemplo
{
    public partial class Inicio : Form
    {

        Conectarse n = new Conectarse();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
       
        private string idCodigo = null;

        string cadena = "Data Source=localhost;Initial Catalog=negocio;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public Inicio()
        {
            InitializeComponent();
            conectarbd.ConnectionString = cadena;

        }
     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAgrePorCode_TextChanged(object sender, EventArgs e)
        {
        }

        DataTable table = new DataTable();

        private void Inicio_Load(object sender, EventArgs e)
        {
            dataGridViewVenta.AllowUserToAddRows = false;
            table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Categoria", typeof(string));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Precio", typeof(int));           
            table.Columns.Add("Total", typeof(string));


            dataGridViewVenta.DataSource = table;
        
        }

 
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
 
            try
            {
                int restaStock;
                restaStock = int.Parse(txtAgreStock.Text) - int.Parse(txbCanidad.Text);
                if (restaStock < 0)
                {
                    MessageBox.Show("No hay suficiente Stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                { 
                if (Convert.ToInt32(txtAgreStock.Text) == 0)
                {

                    MessageBox.Show("No hay Stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {                  

                table.Rows.Add(Convert.ToInt32(txtAgrePorCode.Text), txtAgreNombre.Text, txtAgreCategoria.Text, Convert.ToInt32(txbCanidad.Text), Convert.ToInt32(txtAgrePrecio.Text));

            

                foreach (DataGridViewRow rowMulti in dataGridViewVenta.Rows)
                {

                    rowMulti.Cells["Total"].Value = (Convert.ToDecimal(rowMulti.Cells["Cantidad"].Value) * Convert.ToDecimal(rowMulti.Cells["Precio"].Value)); 
              
                }


                int suma = 0;
                foreach (DataGridViewRow row in dataGridViewVenta.Rows)
                {
                    suma += Convert.ToInt32(row.Cells["Total"].Value);
                }


                dataGridViewVenta.DataSource = table;
                lPrecio.Text = suma.ToString();


                        //Limpiar textbox
                        txtAgrePorCode.Text = "0";
                        txtAgreNombre.Text = "";
                        txtAgreCategoria.Text = "";
                        txtAgrePrecio.Text = "";
                        txtAgreStock.Text = "";
                        txbCanidad.Text = "";


              }
             }
            }
            catch
            {
                MessageBox.Show("Hay campos vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }        
        }

        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }


        private void btnAgreBuscar_Click(object sender, EventArgs e)
        {
            
                conectarbd.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("Select * from tableVentas where Codigo = @Codigo", conectarbd);
                cmd.Parameters.AddWithValue("@Codigo", Convert.ToInt32(txtAgrePorCode.Text));

                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    txtAgrePorCode.Text = registro["codigo"].ToString();
                    txtAgreNombre.Text = registro["nombreArticulo"].ToString();
                    txtAgrePrecio.Text = registro["precioCompra"].ToString();
                    txtAgreStock.Text = registro["Stock"].ToString();
                    txtAgreCategoria.Text = registro["Categoria"].ToString();

                }
                else
                {
                    MessageBox.Show("No se encontro el Articulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            conectarbd.Close();
   
        }

        private void cargar()
        {
            conectarbd.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd;
            cmd = new SqlCommand("SELECT * FROM tableVentas", conectarbd);
            cmd.ExecuteNonQuery();            
          //  da.Fill(dt);

            dataGridViewVenta.DataSource = dt;
            conectarbd.Close();
        }

        private void btnSacarVenta_Click(object sender, EventArgs e)
        {
            Conectarse n = new Conectarse();


            if (dataGridViewVenta.SelectedRows.Count > 0)
            {

                idCodigo = dataGridViewVenta.CurrentRow.Cells["Codigo"].Value.ToString();

                if (MessageBox.Show("Desea quitar este articulo?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridViewVenta.Rows.Remove(dataGridViewVenta.CurrentRow);


                        int suma = 0;
                        foreach (DataGridViewRow row in dataGridViewVenta.Rows)
                        {
                            suma += Convert.ToInt32(row.Cells["Total"].Value);
                        }

                        lPrecio.Text = suma.ToString();
                     lblVuelto.Text = "0";

                }
            }

            
        }


     

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            // Restar stock a la cantidad en la BD

            conectarbd.Open();
            cmd = new SqlCommand("UPDATE p SET p.Stock = (p.Stock - v.stock_cantidad) FROM tableVentas P INNER JOIN Ventas V ON (P.Codigo = V.id_Codigo)", conectarbd);
            cmd.ExecuteNonQuery();
            conectarbd.Close();

            if (MessageBox.Show("Ingresar otra Compra?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtAgrePorCode.Text = "0";
                txtAgreNombre.Text = "";
                txtAgreCategoria.Text = "";
                txtAgrePrecio.Text = "0";
                txtAgreStock.Text = "0";
                

                table.Clear();
                lblVuelto.Text = "0";
                lPrecio.Text = "0";
                textBox1.Text = "0";
                lblNumeroVenta.Text = (Convert.ToInt32(lblNumeroVenta.Text) + 1).ToString();

            }

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quiere Cerrar caja?, se reiniciara todo", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtAgrePorCode.Text = "0";
                txtAgreNombre.Text = "";
                txtAgreCategoria.Text = "";
                txtAgrePrecio.Text = "0";
                txtAgreStock.Text = "0";


                table.Clear();
                table.Clear();
                lblVuelto.Text = "0";
                lPrecio.Text = "0";
                textBox1.Text = "0";
                lblNumeroVenta.Text = "1";
            }

            
        }

        public class NegativeException : Exception
        {
            public NegativeException(string Nombre)
                : base(Nombre)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

              


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            conectarbd.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("INSERT INTO Ventas (Total,stock_cantidad,fecha_venta,num_venta,id_codigo) values( @Total,@stock_cantidad,GETDATE(),@num_venta,@id_Codigo)", conectarbd);

            try
            {

                foreach (DataGridViewRow row in dataGridViewVenta.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Total", Convert.ToString(row.Cells["Total"].Value));
                    cmd.Parameters.AddWithValue("@stock_cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                    cmd.Parameters.AddWithValue("@num_venta", Convert.ToString(lblNumeroVenta.Text));
                    cmd.Parameters.AddWithValue("@id_codigo", Convert.ToString(row.Cells["Codigo"].Value));
                 
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("error al agregar");
            }

            conectarbd.Close();


            int suma = 0;
            foreach (DataGridViewRow row in dataGridViewVenta.Rows)
            {
                suma += Convert.ToInt32(row.Cells["Total"].Value);

            }

            try
            {

                lblVuelto.Text = (Convert.ToInt32(textBox1.Text) - suma).ToString();
            }
            catch
            {
                MessageBox.Show("Coloque el monto con el que paga el cliente, no puede quedar vacio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                int resta = Convert.ToInt32(lblVuelto.Text);
                if (resta < 0) throw new NegativeException(string.Format("Faltan {0:C} para pagar el total", resta * -1));
            }
            catch (NegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txbCanidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
