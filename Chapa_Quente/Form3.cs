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
    public partial class Form3 : Form
    {
        public Form3()
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

                string scomando = "select * from chapaquente";

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

                string scomando = "select * from chapaquente where Dia = '" + textBox2.Text + "'";

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

                string scomando = "select * from chapaquente where Mês = '" + textBox3.Text + "'";

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

        private void button4_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from chapaquente where Ano = '" + textBox4.Text + "'";

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

        private void button7_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from chapaquente where Id = '" + textBox1.Text + "'";

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
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form3 = new Form2();
            form3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);


            try
            {
                conn.Open();

                string scomando = "select * from chapaquente where Cliente1 = '" + textBox5.Text + "'";

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

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form3 = new Form1();
            form3.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

