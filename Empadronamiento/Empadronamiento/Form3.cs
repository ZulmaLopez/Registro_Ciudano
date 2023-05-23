using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empadronamiento
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblIdUname_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionBD conexionb = new ConexionBD();
            conexionb.abrir();

            string Nombre = NOMBRE.Text;
            string Apellido = APELLIDO.Text;
            string Cel = CEL.Text;
            string Dpi = DPI.Text;
            string Departamento = DEPARTAMENTO.Text;
            string Correo = CORREO.Text;
           

            string cadena = "insert into Empadronados(Nombre,Apellido,Cel,DPI,Departamento,Correo) values('" + NOMBRE.Text + "','" + APELLIDO.Text + "','" + CEL.Text + "','" + DPI.Text + "','" + DEPARTAMENTO.Text + "','" + CORREO.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexionb.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Empadronado Correctamento");

            NOMBRE.Text = "";
            APELLIDO.Text = "";
            CEL.Text = "";
            DPI.Text = "";
            DEPARTAMENTO.Text = "";
            CORREO.Text = "";
           
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form();
        }
    }
}
