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

namespace Farmacia.Cadastrar_Fornecedor
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tbFornecedor = textBox2.Text.ToString();
            String tbVendedor = textBox3.Text.ToString();
            String tbContato = textBox4.Text.ToString();
            String tbObs = richTextBox1.Text.ToString();

            CadastrarF(tbFornecedor, tbVendedor, tbContato, tbObs);
        }

        public void CadastrarF(String empresa, String vendedor, String contato, String obs)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from produtos";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "INSERT INTO `farmacia`.`fornecedor` (`Empresa`, `Vendedor`, `Contato`, `Obs`) VALUES ('"+empresa+"', '"+vendedor+"', '"+contato+"', '"+obs+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor cadastrado com sucesso.", "Cadastro de Fornecedores");

                    clearForm();

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Cadastro de Fornecedores");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        public void clearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
           // textBox5.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
