using Farmacia.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia.Cadastrar_Produto
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from fornecedor";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // idnumber = reader.ToString();
                        comboBox1.Items.Add(reader.GetString(1));
                    }

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Cadastro de Produtos");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength < 6)
            {
                MessageBox.Show("Por favor informe o Nome do produto que deseja cadastrar.\nOs nomes dos produtos devem ter no minimo 6 caracteres." , "Cadastro de Produtos");
                return;
            }

            if (textBox2.TextLength < 6)
            {
                MessageBox.Show("Por favor informe o codigo de barras do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (textBox3.TextLength < 3)
            {
                MessageBox.Show("Por favor informe a categoria do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (textBox4.TextLength < 1)
            {
                MessageBox.Show("Por favor informe o valor do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (textBox5.TextLength < 1)
            {
                MessageBox.Show("Por favor informe o codigo interno do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }


            String tbProduto = textBox1.Text.ToString();
            long tbEan = long.Parse(textBox2.Text);
            String tbFornecedor = comboBox1.Text.ToString();
            String tbCategoria = textBox3.Text.ToString();
            String tbValor = textBox4.Text.ToString();
            int tbCod = int.Parse(textBox5.Text);



            CadastrarP(tbCod, tbProduto, tbEan, tbFornecedor, tbCategoria, tbValor, 0);

        }

        public void clearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        
        public void CadastrarP(int cod, String produto, long ean, String fornecedor, String categoria, String valAt, Double valAn)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from produtos";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`Cod`, `EAN`, `Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('"+cod+"', '" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso.", "Cadastro de Produtos");

                    clearForm();

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Cadastro de Produtos");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
