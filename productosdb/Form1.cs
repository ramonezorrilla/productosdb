using System;
using System.Data;
using System.Data.SqlClient;


namespace productosdb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=.; database = basica; integrated security = true");
            conexion.Open();
            string descripcion = tbdescripcion.Text;
            string precio = tbprecio.Text;
            string cadena = "insert into producto(descripcion,precio) values ('"+descripcion+"',"+precio+")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron guardados correctamente");
            tbdescripcion.Text = "";
            tbprecio.Text = "";
            conexion.Close();


        }
    }
}
