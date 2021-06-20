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

namespace Farmacia.Criar_Pedido
{
    public partial class cpLista : Form
    {
        public cpLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tbProduto = textBox1.Text.ToString();
            String tbCategoria = textBox3.Text.ToString();
            String tbFornecedor = comboBox1.Text.ToString();

            String query = "select `Produto`,`Fornecedor`,`PrecoAtual` from produtos where `id` != 0";

            if (tbProduto.Length != 0)
                query = query + " AND `produto` LIKE '%" + tbProduto + "%'";

            if (tbCategoria.Length != 0)
                query = query + " AND `categoria` LIKE '%" + tbCategoria + "%'";

            if (tbFornecedor.Length != 0)
                query = query + " AND `fornecedor` LIKE '%" + tbFornecedor + "%'";


            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conexaoMySQL);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dtMensagens = new DataTable();
                    da.Fill(dtMensagens);
                    this.dataGridView1.DataSource = dtMensagens;
                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Lista de Produtos");
                    //lConexao.Text = "Conexão: Não foi possivel se conectar ao banco de dados.";
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        private void cpLista_Load(object sender, EventArgs e)
        {
            init();

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
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Lista de Produtos");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }


        public void init()
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select `ID`,`Produto`,`Fornecedor`,`PrecoAtual` from produtos";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dtMensagens = new DataTable();
                    da.Fill(dtMensagens);
                    this.dataGridView1.DataSource = dtMensagens;
                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + msqle.Message, "Erro");
                    //lConexao.Text = "Conexão: Não foi possivel se conectar ao banco de dados.";
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Classes.vPedido.Produto = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Classes.vPedido.cod = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            Farmacia.Criar_Pedido.CriarPedido.ActiveForm.Refresh();
            this.Close();
        }
    }
}
