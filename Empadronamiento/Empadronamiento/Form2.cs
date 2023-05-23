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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           ConexionBD conexionBD = new ConexionBD();
            conexionBD.abrir();

            string cadena = "Select * from Empadronados";
            SqlCommand comando = new SqlCommand(cadena, conexionBD.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable table = new DataTable();
            adaptador.Fill(table);
            tabla.DataSource = table;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form();
        }
    }
}
