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
    public partial class NovoPedido : Form
    {
        public NovoPedido()
        {
            InitializeComponent();
        }

        private void NovoPedido_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            tbData.Text = data.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String nome = tbNome.Text.ToString();
            String comprador = tbComprador.Text.ToString();

            if (tbNome.Text.Length < 3 )
            {
                MessageBox.Show("Você deve informar um nome para classificar o novo pedido.", "Novo Pedido");
                return;
            }

            if (tbComprador.Text.Length < 1)
            {
                MessageBox.Show("Você deve informar o nome do comprador para criar um novo pedido.", "Novo Pedido");
                return;
            }


            DateTime data = DateTime.Now;
            criarPedido(nome, comprador, data.ToString());

            Farmacia.Criar_Pedido.CriarPedido.ActiveForm.Refresh();
            ((CriarPedido)this.Owner).pedidoUpdate();
            this.Close();
        }

        public void criarPedido(String nome, String comprador, String data)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    MySqlCommand cmd = new MySqlCommand("", conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "INSERT INTO `farmacia`.`lista_de_pedido` (`Nome_do_Pedido`, `Nome_do_Comprador`, `Data`) VALUES ('"+nome+"', '"+comprador+"', '"+data+"')";
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Novo Pedido");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }
    }
}
