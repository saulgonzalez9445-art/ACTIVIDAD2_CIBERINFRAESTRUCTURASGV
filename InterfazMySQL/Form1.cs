using Microsoft.VisualBasic.ApplicationServices;

using MySql.Data.MySqlClient;
using System.Data;

namespace InterfazMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = tbHost.Text;
            string user = tbUsuario.Text;
            string password = tbContraseña.Text;
            string puerto = tbPuerto.Text;
            string database = tbBasedatos.Text;

            string connectionString = BuildConnectionString(host, user, password, puerto, database);

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adapter=new MySqlDataAdapter("SELECT * FROM CatPersonal", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource= dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: "+ex.Message);
                }
            }
        }

        private string BuildConnectionString(string host,string user, string password, string puerto, string database)
        {
            return $"SERVER={host};PORT={puerto};DATABASE={database};USER ID={user};PASSWORD={password}";
        }
    }
}
