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
    public partial class Form2 : Form
    {
        public Form2()
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

                string scomando = "INSERT INTO chapaquente (Vendas1, Cliente1, Dia, Mês, Ano) VALUES " + "('" + textBox2.Text + "','" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";

                MySqlCommand comando = new MySqlCommand(scomando, conn);

                MessageBox.Show("Cadastro realizado com sucesso");
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stringconexao = "Server=localhost;Database=chapaquente;Uid=root;Pwd=keila";

            MySqlConnection conn = new MySqlConnection(stringconexao);

            try
            {
                conn.Open();

                string scomando = "update chapaquente set Vendas1 = '" + textBox2.Text + "', Cliente1 = '" + textBox1.Text + "', Dia = '" + textBox3.Text + "', Mês = '" + textBox4.Text + "', Ano = '" + textBox5.Text + "' where Id = '" + textBox6.Text + "'";


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

                string scomando = "delete from chapaquente where Id = " + " ('" + textBox7.Text + "')";

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

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form2 = new Form1();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 form2 = new Form3();
            form2.ShowDialog();
        }
    }
}
