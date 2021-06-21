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

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Cod"].Visible = false;
            dataGridView1.Columns["EAN"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;
            dataGridView1.Columns["PrecoAnterior"].Visible = false;

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

                    string mSQL = "Select * from produtos";

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
            Classes.vPedido.id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Classes.vPedido.cod = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Classes.vPedido.ean = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Classes.vPedido.Produto = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Classes.vPedido.Fornecedor = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Classes.vPedido.Categoria = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Classes.vPedido.PrecoAtual = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Classes.vPedido.PrecoAnterior = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            Farmacia.Criar_Pedido.CriarPedido.ActiveForm.Refresh();
            ((CriarPedido)this.Owner).pedidoUpdate();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
