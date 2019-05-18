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
using System.Collections;


namespace ejemplo
{
    public partial class Resumen : Form
    {
        string cadena = "Data Source=localhost;Initial Catalog=negocio;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;


        public Resumen()
        {
            InitializeComponent();
            conectarbd.ConnectionString = cadena;
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            GrafCategori();
            prodPreferidos();
            TotalTime();
            dashBoardDatos();
            numeroClientes();
        }

        ArrayList Categoria = new ArrayList();
        ArrayList CantProd = new ArrayList();
        ArrayList Producto = new ArrayList();
        ArrayList Cantidad = new ArrayList();
        ArrayList Fecha = new ArrayList();
        ArrayList Total = new ArrayList();
        


        private void GrafCategori()
        {
            cmd = new SqlCommand("ProductPorCategoria", conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            conectarbd.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria.Add(dr.GetString(0));
                CantProd.Add(dr.GetInt32(1));
            }
            chartProductCategoria.Series[0].Points.DataBindXY(Categoria, CantProd);
            dr.Close();
            conectarbd.Close();
        }

        private void prodPreferidos()
        {
            cmd = new SqlCommand("ProdPreferidos", conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            conectarbd.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto.Add(dr.GetString(0));
                Cantidad.Add(dr.GetInt32(1));
            }
            chartProductPreferidos.Series[0].Points.DataBindXY(Producto, Cantidad);
            dr.Close();
            conectarbd.Close();
        }

        private void TotalTime()
        {
            cmd = new SqlCommand("TotalFecha ", conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            conectarbd.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Fecha.Add(dr.GetDateTime(0));
                Total.Add(dr.GetInt32(1));
                
            }
            chartTotalTime.Series[0].Label = "#VALY{C}";
            chartTotalTime.Series[0].Points.DataBindXY(Fecha, Total);
            dr.Close();
            conectarbd.Close();
        }

        private void dashBoardDatos()
        {
            cmd = new SqlCommand("TablaDeDatos", conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter total = new SqlParameter("@totVentas",0);total.Direction = ParameterDirection.Output;
            SqlParameter cantiProductos = new SqlParameter("@cantiProduct", 0); cantiProductos.Direction = ParameterDirection.Output;
            SqlParameter numVentas = new SqlParameter("@numVentas", 0); numVentas.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(cantiProductos);
            cmd.Parameters.Add(numVentas);
            conectarbd.Open();
            cmd.ExecuteNonQuery();
            lblTotalVentas.Text = cmd.Parameters["@totVentas"].Value.ToString();
            lblTotalVentas.Text = (Convert.ToInt32(lblTotalVentas.Text)).ToString("C");
            lblCantidadProduct.Text = cmd.Parameters["@cantiProduct"].Value.ToString();
            lblcantidadVentas.Text = cmd.Parameters["@numVentas"].Value.ToString();


            conectarbd.Close();
        }

        private void numeroClientes()
        {
            cmd = new SqlCommand("numeroClientes", conectarbd);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter numClientes = new SqlParameter("@numClientes", 0); numClientes.Direction = ParameterDirection.Output;          
            cmd.Parameters.Add(numClientes);
            conectarbd.Open();
            cmd.ExecuteNonQuery();

            lblCantidadClientes.Text = cmd.Parameters["@numClientes"].Value.ToString();
          conectarbd.Close();
        }
    }
}
