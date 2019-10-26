using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Chapa_Quente
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from estoque";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(scomando, conn);

                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from estoque where data = '" + textBox1.Text + "'";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(scomando, conn);

                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from estoque where Id = '" + textBox2.Text + "'";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(scomando, conn);

                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text = textBox2.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form5 = new Form4();
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Hide();
            Form1 form5 = new Form1();
            form5.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
