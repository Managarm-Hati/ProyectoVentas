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
    public partial class Form1 : Form 
    {


        public Form1()
        {
            InitializeComponent();
        }


        

        private void Form1_Load(object sender, EventArgs e)
        {
            Conectarse conexion = new Conectarse();
            conexion.abrir();
            mostrarlogo();

        }

        #region funcionalidades del formulario

        private void mostrarlogo()
        {
            AbrirFormulario<Inicial>();
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
  

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seguro desea cerrar?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else {

            }
           

        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            AbrirFormulario<Inicio>();
            btnventa.BackColor = Color.FromArgb(34, 41, 54);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<nuevoProduct>();
            btnNuevo.BackColor = Color.FromArgb(34, 41, 54);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Resumen>();
            button4.BackColor = Color.FromArgb(34, 41, 54);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Ayuda>();
            btnAyuda.BackColor = Color.FromArgb(34, 41, 54);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerProduct_Click(object sender, EventArgs e)
        {
            AbrirFormulario<verProductos>();
            btnVerProduct.BackColor = Color.FromArgb(34, 41, 54);
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

        #endregion 

        //Metodo abrir formulario dentro del panel

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en al coleccion en el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelContenedor.Controls.Add(formulario);
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Inicio"] == null)
                btnventa.BackColor = Color.FromArgb(22, 27, 36);

            if (Application.OpenForms["nuevoProduct"] == null)
                btnNuevo.BackColor = Color.FromArgb(22, 27, 36);

            if (Application.OpenForms["verProductos"] == null)
                btnVerProduct.BackColor = Color.FromArgb(22, 27, 36);

            if (Application.OpenForms["Resumen"] == null)
                btnVerProduct.BackColor = Color.FromArgb(22, 27, 36);

            if (Application.OpenForms["Ayuda"] == null)
                btnVerProduct.BackColor = Color.FromArgb(22, 27, 36);
        }

       
    }
}
