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

namespace Farmacia.Criar_Pedido
{
    public partial class cpLista : MaterialSkin.Controls.MaterialForm
    {
        public cpLista()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tbProduto = textBox1.Text.ToString();
            String tbCategoria = textBox3.Text.ToString();
            String tbFornecedor = comboBox1.Text.ToString();

            String query = "select * from produtos where `id` != 0";

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

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Cod"].Visible = false;
            dataGridView1.Columns["EAN"].Visible = false;
            dataGridView1.Columns["Categoria"].Visible = false;
            dataGridView1.Columns["PrecoAnterior"].Visible = false;
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
            if (e.RowIndex > -1)
            {
                vPedido.id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                vPedido.cod = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                vPedido.ean = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                vPedido.Produto = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                vPedido.Fornecedor = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                vPedido.Categoria = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                vPedido.PrecoAtual = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                vPedido.PrecoAnterior = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                Farmacia.Criar_Pedido.CriarPedido.ActiveForm.Refresh();
                ((CriarPedido)this.Owner).pedidoUpdate();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
