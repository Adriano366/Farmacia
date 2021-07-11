using Farmacia.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Farmacia.Criar_Pedido
{

    public partial class CriarPedido : MaterialSkin.Controls.MaterialForm
    {
        public CriarPedido()
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

            updateListaPedido();

            this.Refresh();
        }

        public void updateListaPedido()
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from Lista_de_pedido order by id desc limit 0,20";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    listBox1.Items.Clear();
                    listaPedido.Clear();

                    while (reader.Read())
                    {
                        // idnumber = reader.ToString();
                        listBox1.Items.Add(reader.GetString(1));

                        pList c1 = new pList();

                        c1.id = reader.GetInt32(0);
                        c1.pedido = reader.GetString(1);
                        c1.comprador = reader.GetString(2);
                        c1.data = reader.GetString(3);

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

        public void returnInfo(int mid)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    string mSQL = "Select * from Lista_de_produto where ID_List = '"+mid+"'";

                    MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
                    //cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    float stotal = 0;
                    int sitem = 0;

                    while (reader.Read())
                    {
                        stotal += reader.GetFloat(8) * reader.GetInt32(4);
                        sitem += reader.GetInt32(4);
                    }

                    Classes.vPedido.cntItens = sitem;
                    Classes.vPedido.valorTotal = stotal;

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

            if(tbQtd.Text.Length == 0)
            {
                MessageBox.Show("Informe a quantidade de Produtos que serão inseridos na lista.", "Inserir Produto na Lista");
                return;
            }

            int qtd = int.Parse(tbQtd.Text.ToString());
            int cod = int.Parse(Classes.vPedido.cod.ToString());
            long ean = long.Parse(Classes.vPedido.ean.ToString());
            float stotal = qtd * float.Parse(vPedido.PrecoAtual);


            addProdutoLista(Classes.vPedido.id_list, qtd, cod, Classes.vPedido.Produto, ean, Classes.vPedido.Fornecedor, Classes.vPedido.Categoria, Classes.vPedido.PrecoAtual, Classes.vPedido.PrecoAnterior, stotal);

            gvUpdate();
            returnInfo(Classes.vPedido.id_list);

            lbValor.Text = "Total R$: " + Classes.vPedido.valorTotal;
            lbItens.Text = "Itens: " + Classes.vPedido.cntItens;

            this.Refresh();
        }

        public void addProdutoLista(int idList, int qtd, int cod, String produto, long ean, String fornecedor, String categoria, String valAt, String valAn, float total)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    MySqlCommand cmd = new MySqlCommand("", conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "INSERT INTO `farmacia`.`lista_de_produto` (`ID_List`, `Produto`, `Quantidade`, `Cod`, `EAN`, `Fornecedor`, `Categoria`, `Valor_Atual`, `Valor_Anterior`, `Valor_Total`) VALUES ('"+idList+"', '"+produto+ "', '"+qtd+"', '"+cod+ "', '"+ean+ "', '"+fornecedor+ "', '"+categoria+ "', '"+valAt+ "', '"+valAn+"', '"+total+"')";
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

            gvPedido.Columns["Valor_Atual"].HeaderText = "Valor Atual";
            gvPedido.Columns["Valor_Anterior"].HeaderText = "Valor Anteior";
            gvPedido.Columns["Valor_Total"].HeaderText = "Valor Total";

            gvPedido.Columns["Produto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gvPedido.Columns["EAN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            gvPedido.Columns["Quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gvPedido.Columns["Valor_Atual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gvPedido.Columns["Valor_Anterior"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


            // gvPedido.Columns["Cod"].DisplayIndex = 0;

            lbID.Text = "ID: " + Classes.vPedido.id_list;
            lbLista.Text = "Lista: " + listaPedido[mid].pedido.ToString();
            lbComprador.Text = "Comprador: " + listaPedido[mid].comprador.ToString();
            lbData.Text = "Data: " + listaPedido[mid].data.ToString();

            returnInfo(listaPedido[mid].id);

            lbValor.Text = "Total R$: " + Classes.vPedido.valorTotal;
            lbItens.Text = "Itens: " + Classes.vPedido.cntItens;

            this.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Criar_Pedido.NovoPedido np = new NovoPedido();
            np.Owner = this;
            np.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto.CadastroProduto cp = new Cadastrar_Produto.CadastroProduto();
            cp.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (exProduto.id > 0)
            {
                //MessageBox.Show("Você deseja excluir o produto: "+exProduto.produto, "Excluir Produto da Lista");

                DialogResult confirm = MessageBox.Show("O produto '"+exProduto.produto+"' sera excluido da lista, deseja continuar ?", "Exluir Produto da Lista", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "YES")
                {
                    MessageBox.Show(exProduto.produto+" foi excluido da lista.", "Excluir Produto da Lista");
                    excluirProduto(exProduto.id);

                    gvUpdate();
                    returnInfo(Classes.vPedido.id_list);

                    lbValor.Text = "Total R$: " + Classes.vPedido.valorTotal;
                    lbItens.Text = "Itens: " + Classes.vPedido.cntItens;

                    this.Refresh();
                }


            }

        }

        public void excluirProduto(int id)
        {
            using (MySqlConnection conexaoMySQL = daoMySQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySQL.Open();

                    
                    MySqlCommand cmd = new MySqlCommand("",conexaoMySQL);
                    //cmd.CommandText = "INSERT INTO `farmacia`.`produtos` (`EAN`,`Produto`, `Fornecedor`, `Categoria`, `PrecoAtual`, `PrecoAnterior`) VALUES ('" + ean + "','" + produto+"', '"+fornecedor+"', '"+categoria+"', '"+valAt+"', '"+valAn+"')";
                    cmd.CommandText = "DELETE FROM `farmacia`.`lista_de_produto` WHERE (`ID` = '"+id+"')";
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException msqle)
                {
                    MessageBox.Show("Erro de acesso ao Banco de Dados : " + msqle.Message, "Excluir Produto da Lista");
                }
                finally
                {
                    conexaoMySQL.Close();
                }
            }
        }

        private void gvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1 && e.RowIndex < (gvPedido.RowCount-1))
            {
                exProduto.id = int.Parse(gvPedido.Rows[e.RowIndex].Cells[0].Value.ToString());
                exProduto.produto = gvPedido.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog(); // novo


            Excel.Application App; // Aplicação Excel
            Excel.Workbook WorkBook; // Pasta
            Excel.Worksheet WorkSheet; // Planilha
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);


            int ret = 0;
            for (int c = 1; c < gvPedido.Columns.Count + 1; c++)
            {
                if (gvPedido.Columns[c - 1].Visible == false)
                {
                    ret++;
                    continue;
                }

                WorkSheet.Cells[1, (c-ret)] = gvPedido.Columns[c - 1].HeaderText;
            }

            int i = 0;
            int req = 0;
            for (; i < gvPedido.Rows.Count - 1; i++)
            {
                req = 0;
                for (int j = 0; j < gvPedido.Columns.Count; j++)
                {
                    if (gvPedido.Columns[j].Visible == false)
                    {
                        req++;
                        continue;
                    }

                    WorkSheet.Cells[i + 2, (j-req) + 1] = gvPedido.Rows[i].Cells[j].Value.ToString();
                }
            }

            WorkSheet.Columns.AutoFit();
            WorkSheet.Cells.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexNone, Color.FromArgb(255, 0, 0), Type.Missing);
            WorkSheet.get_Range("A1", "I"+(i+1)).Cells.Borders.Weight = Excel.XlBorderWeight.xlHairline;

            // define algumas propriedades da caixa salvar
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            // salva o arquivo
            WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

            Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit(); // encerra o excel

            MessageBox.Show("Pedido exportado com sucesso!","Exportação Excel");


         }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gvPedido.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = vPedido.comprador+".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(gvPedido.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            //foreach (DataGridViewColumn column in gvPedido.Columns)
                            //{
                            //    if (column.HeaderText == "ID_List" ||
                            //        column.HeaderText == "ID" ||
                            //        column.HeaderText == "EAN" ||
                            //        column.HeaderText == "Valor_Anteior")
                            //        continue;
                            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            //    pdfTable.AddCell(cell);
                            //}


                            //foreach (DataGridViewRow row in gvPedido.Rows)
                            //{
                            //    foreach (DataGridViewCell cell in row.Cells)
                            //    {
                            //        if(cell.Value != null)
                            //            pdfTable.AddCell(cell.Value.ToString());
                            //    }
                            //}

                            PdfPCell cell;
                            for (int c = 0; c < gvPedido.Columns.Count; c++)
                            {
                                if (gvPedido.Columns[c].Visible == false)
                                    continue;

                                cell = new PdfPCell(new Phrase(gvPedido.Columns[c].HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < gvPedido.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < gvPedido.Columns.Count; j++)
                                {
                                    if (gvPedido.Columns[j].Visible == false)
                                        continue;
                   
                                    if (gvPedido.Rows[i].Cells[j].Value != null)
                                    {
                                        cell = new PdfPCell(new Phrase(gvPedido.Rows[i].Cells[j].Value.ToString()));
                                        pdfTable.AddCell(cell);
                                    }

                                }
                            }


                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Pedido exportado com sucesso.", "Exportação PDF");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }

    class pList
    {
        public int id { get; set; }
        public string pedido { get; set; }
        public string comprador { get; set; }
        public string data { get; set; }
    }

}
