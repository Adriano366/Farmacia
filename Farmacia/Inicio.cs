using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using Farmacia.Classes;

namespace Farmacia
{


    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Farmacia.Cadastrar_Produto.CadastroProduto cnp = new Cadastrar_Produto.CadastroProduto();
            cnp.ShowDialog();
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

					lConexao.Text = "Conexão: Conectado ao Banco de Dados com sucesso.";
				}
				catch (MySqlException msqle)
				{
					MessageBox.Show("Erro de acesso ao MySQL : " + msqle.Message, "Erro");
					lConexao.Text = "Conexão: Não foi possivel se conectar ao banco de dados.";
				}
				finally
				{
					conexaoMySQL.Close();
				}
			}
		}

        private void button6_Click(object sender, EventArgs e)
        {
			Farmacia.Lista_de_Produtos.ListaDeProdutos list = new Lista_de_Produtos.ListaDeProdutos();
			list.ShowDialog();
		}

        private void button3_Click(object sender, EventArgs e)
        {
			Farmacia.Cadastrar_Fornecedor.CadastroFornecedor cf = new Cadastrar_Fornecedor.CadastroFornecedor();
			cf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Farmacia.Criar_Pedido.CriarPedido cp = new Criar_Pedido.CriarPedido();
			cp.ShowDialog();
        }
    }
}
