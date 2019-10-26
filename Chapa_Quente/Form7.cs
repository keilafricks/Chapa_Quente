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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form7 = new Form1();
            form7.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";


            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "INSERT INTO funcionario (nome, salario, CPF) VALUES " + "('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro realizado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "update funcionario set nome = '" + textBox1.Text + "', salario = '" + textBox2.Text + "', CPF = '" + textBox3.Text + "' where Id = '" + textBox4.Text + "'";


                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro alterado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form7 = new Form6();
            form7.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "delete from funcionario where Id = " + " ('" + textBox5.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro excluido com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
