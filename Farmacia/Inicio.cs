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
using MaterialSkin;

namespace Farmacia
{


    public partial class Inicio : MaterialSkin.Controls.MaterialForm
    {

        public Inicio()
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

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Farmacia.Criar_Pedido.CriarPedido cp = new Criar_Pedido.CriarPedido();
            cp.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Farmacia.Cadastrar_Produto.CadastroProduto cnp = new Cadastrar_Produto.CadastroProduto();
            cnp.ShowDialog();
        }
    }
}
