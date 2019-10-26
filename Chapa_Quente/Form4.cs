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
    public partial class Form4 : Form
    {
        public Form4()
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

                string scomando = "INSERT INTO estoque (alimento, quantidade, data, valor, prazo) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text +"')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro realizado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "update estoque set alimento = '" + textBox1.Text + "', quantidade = '" + textBox2.Text + "', data = '" + textBox3.Text + "', valor = '" + textBox4.Text + "', prazo = '" + textBox5.Text + "' where Id = '" + textBox6.Text + "'";


                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro alterado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "delete from estoque where Id = " + " ('" + textBox7.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro excluido com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form4 = new Form1();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form4 = new Form5();
            form4.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

