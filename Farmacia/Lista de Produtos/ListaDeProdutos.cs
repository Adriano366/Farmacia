﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacia.Classes;
using MySql.Data.MySqlClient;

namespace Farmacia.Lista_de_Produtos
{
    public partial class ListaDeProdutos : Form
    {
        public ListaDeProdutos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaDeProdutos_Load(object sender, EventArgs e)
        {
			init();

            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Cod"].HeaderText = "Código";
            dataGridView1.Columns["Produto"].HeaderText = "Nome do Produto";
            dataGridView1.Columns["PrecoAtual"].HeaderText = "Valor Atual";
            dataGridView1.Columns["PrecoAnterior"].HeaderText = "Valor Anterior";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
