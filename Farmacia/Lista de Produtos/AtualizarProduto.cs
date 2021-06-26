using Farmacia.Classes;
using MaterialSkin;
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

namespace Farmacia.Lista_de_Produtos
{
    public partial class AtualizarProduto : MaterialSkin.Controls.MaterialForm
    {
        int gid;
        public AtualizarProduto(int id, int cod, String produto, String ean, String fornecedor, String categoria, String valor)
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );


            tbCod.Text = cod.ToString();
            tbProduto.Text = produto;
            tbEAN.Text = ean;
            tbFornecedor.SelectedText = fornecedor;
            tbCategoria.Text = categoria;
            tbValor.Text = valor;

            gid = id;

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
                        tbFornecedor.Items.Add(reader.GetString(1));
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
            if(this.tbProduto.TextLength < 6)
            {
                MessageBox.Show("Por favor informe o Nome do produto que deseja cadastrar.\nOs nomes dos produtos devem ter no minimo 6 caracteres." , "Cadastro de Produtos");
                return;
            }

            if (tbEAN.TextLength < 6)
            {
                MessageBox.Show("Por favor informe o codigo de barras do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (this.tbCategoria.TextLength < 3)
            {
                MessageBox.Show("Por favor informe a categoria do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (this.tbValor.TextLength < 1)
            {
                MessageBox.Show("Por favor informe o valor do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }

            if (this.tbCod.TextLength < 1)
            {
                MessageBox.Show("Por favor informe o codigo interno do produto que deseja cadastrar.", "Cadastro de Produtos");
                return;
            }


            String bProduto = tbProduto.Text.ToString();
            long bEan = long.Parse(tbEAN.Text);
            String bFornecedor = tbFornecedor.Text.ToString();
            String bCategoria = tbCategoria.Text.ToString();
            String bValor = tbValor.Text.ToString();
            int bCod = int.Parse(this.tbCod.Text);



            atualizarP(gid, bCod, bProduto, bEan, bFornecedor, bCategoria, bValor, 0);

        }

        public void clearForm()
        {
            tbProduto.Clear();
            tbEAN.Clear();
            tbCategoria.Clear();
            tbValor.Clear();
            tbCod.Clear();
        }
        
        public void atualizarP(int id, int cod, String produto, long ean, String fornecedor, String categoria, String valAt, Double valAn)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    MySqlCommand cmd = new MySqlCommand("", conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "UPDATE `farmacia`.`produtos` SET `Cod` = '"+cod+"', `EAN` = '"+ean+"', `Produto` = '"+produto+"', `Fornecedor` = '"+fornecedor+"', `Categoria` = '"+categoria+"', `PrecoAtual` = '"+valAt+"', `PrecoAnterior` = '"+valAn+"' WHERE (`ID` = '"+id+"')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto atualizado com sucesso.", "Atualizaão de Produtos");

                    

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Atualização de Produtos");
                }
                finally
                {
                    conexaoMySQL.Close();
                    this.Close();
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
