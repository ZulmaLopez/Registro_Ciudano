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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empadronamiento
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();

            Agregar fr2 = new Agregar();
            fr2.Show();
            
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
           
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();

            string cadena = "insert into personas(nombre, apellido, cell, DPI, departamento,correo) values ";
            SqlCommand comando  = new SqlCommand(cadena,conexion.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("se a empadronado correctamente");

        

        }

        private void iconVisualizar_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconAgregar_Click_1(object sender, EventArgs e)
        {
            Form Form1 = new Form3();
            this.Hide();
            Form1.ShowDialog();
            this.Show();

        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void iconVisualizar_Click_1(object sender, EventArgs e)
        {
            Form form = new Form2 ();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconportada_Click(object sender, EventArgs e)
        {

        }
    }
}
