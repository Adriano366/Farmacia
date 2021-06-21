using Farmacia.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Farmacia.Criar_Pedido
{

    public partial class CriarPedido : Form
    {
        public CriarPedido()
        {
            InitializeComponent();
        }


        List<pList> listaPedido = new List<pList>();

        private void button6_Click(object sender, EventArgs e)
        {
            Farmacia.Criar_Pedido.cpLista cpl = new Criar_Pedido.cpLista();
            cpl.Owner = this;
            cpl.ShowDialog();
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {

            pedidoUpdate();

            updateListaPedido();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void gvUpdate()
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from lista_de_produto where ID_List = '"+Classes.vPedido.id_list+"'";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dtMensagens = new DataTable();
                    da.Fill(dtMensagens);
                    this.gvPedido.DataSource = dtMensagens;
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

        public void pedidoUpdate()
        {
            tbCod.Text = Classes.vPedido.cod;
            tbProduto.Text = Classes.vPedido.Produto;
            tbFornecedor.Text = Classes.vPedido.Fornecedor;
            tbCategoria.Text = Classes.vPedido.Categoria;
            tbPrecoAtual.Text = Classes.vPedido.PrecoAtual;

            this.Refresh();
        }

        public void updateListaPedido()
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from Lista_de_pedido";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // idnumber = reader.ToString();
                        listBox1.Items.Add(reader.GetString(1));

                        pList c1 = new pList();

                        c1.id = reader.GetInt32(0);
                        c1.pedido = reader.GetString(1);

                        listaPedido.Add(c1);
                       
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

        private void button9_Click(object sender, EventArgs e)
        {

            if(Classes.vPedido.id_list == 0)
            {
                MessageBox.Show("Você não pode inserir um produto na lista antes de selecionar um pedido.","Inserir Produto na Lista");
                return;
            }

            int qtd = int.Parse(tbQtd.Text.ToString());
            int cod = int.Parse(Classes.vPedido.cod.ToString());
            long ean = long.Parse(Classes.vPedido.ean.ToString());

            addProdutoLista(Classes.vPedido.id_list, qtd, cod, Classes.vPedido.Produto, ean, Classes.vPedido.Fornecedor, Classes.vPedido.Categoria, Classes.vPedido.PrecoAtual, Classes.vPedido.PrecoAnterior);

            gvUpdate();
        }

        public void addProdutoLista(int idList, int qtd, int cod, String produto, long ean, String fornecedor, String categoria, String valAt, String valAn)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from produtos";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "INSERT INTO `farmacia`.`lista_de_produto` (`ID_List`, `Produto`, `Quantidade`, `Cod`, `EAN`, `Fornecedor`, `Categoria`, `Valor_Atual`, `Valor_Anterior`) VALUES ('"+idList+"', '"+produto+ "', '"+qtd+"', '"+cod+ "', '"+ean+ "', '"+fornecedor+ "', '"+categoria+ "', '"+valAt+ "', '"+valAn+"')";
                    cmd.ExecuteNonQuery();

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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            int mid = list.SelectedIndex;
         
            Classes.vPedido.id_list = listaPedido[mid].id;

            gvUpdate();

            gvPedido.Columns["ID"].Visible = false;
            gvPedido.Columns["ID_List"].Visible = false;

            lbID.Text = "ID: " + Classes.vPedido.id_list;
            lbLista.Text = "Lista: " + listaPedido[mid].pedido.ToString();

            this.Refresh();
        }
    }

    class pList
    {
        public int id { get; set; }
        public string pedido { get; set; }
    }
}
