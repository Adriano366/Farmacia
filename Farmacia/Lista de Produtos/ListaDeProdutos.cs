using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Classes;
using MaterialSkin;
using MySql.Data.MySqlClient;

namespace Farmacia.Lista_de_Produtos
{
    public partial class ListaDeProdutos : MaterialSkin.Controls.MaterialForm
    {

        public ListaDeProdutos()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDeProdutos_Load(object sender, EventArgs e)
        {
			init();

            dvgLista.Columns["ID"].Visible = false;
            dvgLista.Columns["Cod"].HeaderText = "Código";
            dvgLista.Columns["Produto"].HeaderText = "Nome do Produto";
            dvgLista.Columns["PrecoAtual"].HeaderText = "Valor Atual";
            dvgLista.Columns["PrecoAnterior"].HeaderText = "Valor Anterior";
            dvgLista.Columns["Produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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
					this.dvgLista.DataSource = dtMensagens;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tbProduto = textBox1.Text.ToString();
            String tbCategoria = textBox2.Text.ToString();
            String tbFornecedor = comboBox1.Text.ToString();

            String query = "select * from produtos where `id` != 0";

            if (tbProduto.Length != 0)
                query = query + " AND `Produto` LIKE '%"+tbProduto+"%'";

            if (tbCategoria.Length != 0)
                query = query + " AND `Categoria` LIKE '%" + tbCategoria + "%'";

            if (tbFornecedor.Length != 0)
                query = query + " AND `Fornecedor` LIKE '%" + tbFornecedor + "%'";


            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    MySqlCommand cmd = new MySqlCommand(query, conexaoMySQL);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dtMensagens = new DataTable();
                    da.Fill(dtMensagens);
                    this.dvgLista.DataSource = dtMensagens;
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

                dvgLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx = dvgLista.CurrentCell.RowIndex;
            if (idx != 0)
            {

                int mid = int.Parse(dvgLista.Rows[idx].Cells[0].Value.ToString());
                int cod = int.Parse(dvgLista.Rows[idx].Cells[1].Value.ToString());
                String fProduto = dvgLista.Rows[idx].Cells[3].Value.ToString();
                String fEAN = dvgLista.Rows[idx].Cells[2].Value.ToString();
                String fFornecedor = dvgLista.Rows[idx].Cells[4].Value.ToString();
                String fCategoria = dvgLista.Rows[idx].Cells[5].Value.ToString();
                String fValor = dvgLista.Rows[idx].Cells[6].Value.ToString();

                Lista_de_Produtos.AtualizarProduto cpl = new Lista_de_Produtos.AtualizarProduto(mid, cod, fProduto, fEAN, fFornecedor, fCategoria, fValor);
                cpl.Owner = this;
                cpl.ShowDialog();
            }
        }
    }
}
