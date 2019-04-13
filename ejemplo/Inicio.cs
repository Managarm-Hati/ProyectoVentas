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
            table.Columns.Add("Codigo", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Precio", typeof(int));
            table.Columns.Add("Categoria", typeof(string));

            dataGridViewVenta.DataSource = table;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Add(Convert.ToInt32(txtAgrePorCode.Text), txtAgreNombre.Text, Convert.ToInt32(txtAgreStock.Text), Convert.ToInt32(txtAgrePrecio.Text), txtAgreCategoria.Text);
                dataGridViewVenta.DataSource = table;
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
                 
                }
               

            }

        }

  
      
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Se limpiara todo", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                table.Clear();
            }

        }
    }
}
