
namespace Farmacia.Criar_Pedido
{
    partial class CriarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new MaterialSkin.Controls.MaterialButton();
            this.button9 = new MaterialSkin.Controls.MaterialButton();
            this.tbCategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.tbFornecedor = new MaterialSkin.Controls.MaterialTextBox();
            this.tbQtd = new MaterialSkin.Controls.MaterialTextBox();
            this.tbProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPrecoAtual = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCod = new MaterialSkin.Controls.MaterialTextBox();
            this.btnExportar = new MaterialSkin.Controls.MaterialButton();
            this.button7 = new MaterialSkin.Controls.MaterialButton();
            this.button6 = new MaterialSkin.Controls.MaterialButton();
            this.gvPedido = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbValor = new MaterialSkin.Controls.MaterialLabel();
            this.lbData = new MaterialSkin.Controls.MaterialLabel();
            this.lbItens = new MaterialSkin.Controls.MaterialLabel();
            this.lbComprador = new MaterialSkin.Controls.MaterialLabel();
            this.lbID = new MaterialSkin.Controls.MaterialLabel();
            this.lbLista = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.tbCategoria);
            this.groupBox1.Controls.Add(this.tbFornecedor);
            this.groupBox1.Controls.Add(this.tbQtd);
            this.groupBox1.Controls.Add(this.tbProduto);
            this.groupBox1.Controls.Add(this.tbPrecoAtual);
            this.groupBox1.Controls.Add(this.tbCod);
            this.groupBox1.Location = new System.Drawing.Point(12, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = false;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.HighEmphasis = true;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(894, 90);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(131, 51);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluir.UseAccentColor = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = false;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button9.Depth = 0;
            this.button9.HighEmphasis = true;
            this.button9.Icon = null;
            this.button9.Location = new System.Drawing.Point(894, 23);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button9.MouseState = MaterialSkin.MouseState.HOVER;
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(131, 54);
            this.button9.TabIndex = 7;
            this.button9.Text = "Inserir Produto";
            this.button9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button9.UseAccentColor = false;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tbCategoria
            // 
            this.tbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCategoria.Depth = 0;
            this.tbCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCategoria.Hint = "Categoria";
            this.tbCategoria.LeadingIcon = null;
            this.tbCategoria.Location = new System.Drawing.Point(496, 139);
            this.tbCategoria.MaxLength = 50;
            this.tbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCategoria.Multiline = false;
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.ReadOnly = true;
            this.tbCategoria.Size = new System.Drawing.Size(318, 50);
            this.tbCategoria.TabIndex = 2;
            this.tbCategoria.Text = "";
            this.tbCategoria.TrailingIcon = null;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFornecedor.Depth = 0;
            this.tbFornecedor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbFornecedor.Hint = "Fornecedor";
            this.tbFornecedor.LeadingIcon = null;
            this.tbFornecedor.Location = new System.Drawing.Point(64, 135);
            this.tbFornecedor.MaxLength = 50;
            this.tbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFornecedor.Multiline = false;
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.ReadOnly = true;
            this.tbFornecedor.Size = new System.Drawing.Size(286, 50);
            this.tbFornecedor.TabIndex = 2;
            this.tbFornecedor.Text = "";
            this.tbFornecedor.TrailingIcon = null;
            // 
            // tbQtd
            // 
            this.tbQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQtd.Depth = 0;
            this.tbQtd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbQtd.Hint = "Quantidade";
            this.tbQtd.LeadingIcon = null;
            this.tbQtd.Location = new System.Drawing.Point(496, 27);
            this.tbQtd.MaxLength = 50;
            this.tbQtd.MouseState = MaterialSkin.MouseState.OUT;
            this.tbQtd.Multiline = false;
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(318, 50);
            this.tbQtd.TabIndex = 1;
            this.tbQtd.Text = "";
            this.tbQtd.TrailingIcon = null;
            // 
            // tbProduto
            // 
            this.tbProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduto.Depth = 0;
            this.tbProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbProduto.Hint = "Produto";
            this.tbProduto.LeadingIcon = null;
            this.tbProduto.Location = new System.Drawing.Point(64, 79);
            this.tbProduto.MaxLength = 50;
            this.tbProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.tbProduto.Multiline = false;
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.ReadOnly = true;
            this.tbProduto.Size = new System.Drawing.Size(286, 50);
            this.tbProduto.TabIndex = 2;
            this.tbProduto.Text = "";
            this.tbProduto.TrailingIcon = null;
            // 
            // tbPrecoAtual
            // 
            this.tbPrecoAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecoAtual.Depth = 0;
            this.tbPrecoAtual.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPrecoAtual.Hint = "R$";
            this.tbPrecoAtual.LeadingIcon = null;
            this.tbPrecoAtual.Location = new System.Drawing.Point(497, 83);
            this.tbPrecoAtual.MaxLength = 50;
            this.tbPrecoAtual.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPrecoAtual.Multiline = false;
            this.tbPrecoAtual.Name = "tbPrecoAtual";
            this.tbPrecoAtual.ReadOnly = true;
            this.tbPrecoAtual.Size = new System.Drawing.Size(146, 50);
            this.tbPrecoAtual.TabIndex = 2;
            this.tbPrecoAtual.Text = "";
            this.tbPrecoAtual.TrailingIcon = null;
            // 
            // tbCod
            // 
            this.tbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCod.Depth = 0;
            this.tbCod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCod.Hint = "Código";
            this.tbCod.LeadingIcon = null;
            this.tbCod.Location = new System.Drawing.Point(64, 23);
            this.tbCod.MaxLength = 50;
            this.tbCod.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCod.Multiline = false;
            this.tbCod.Name = "tbCod";
            this.tbCod.ReadOnly = true;
            this.tbCod.Size = new System.Drawing.Size(100, 50);
            this.tbCod.TabIndex = 2;
            this.tbCod.Text = "";
            this.tbCod.TrailingIcon = null;
            // 
            // btnExportar
            // 
            this.btnExportar.AutoSize = false;
            this.btnExportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportar.Depth = 0;
            this.btnExportar.HighEmphasis = true;
            this.btnExportar.Icon = null;
            this.btnExportar.Location = new System.Drawing.Point(17, 29);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(89, 37);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Excel";
            this.btnExportar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportar.UseAccentColor = false;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = false;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button7.Depth = 0;
            this.button7.HighEmphasis = true;
            this.button7.Icon = null;
            this.button7.Location = new System.Drawing.Point(25, 80);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button7.MouseState = MaterialSkin.MouseState.HOVER;
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 48);
            this.button7.TabIndex = 6;
            this.button7.Text = "Novo";
            this.button7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button7.UseAccentColor = false;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = false;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button6.Depth = 0;
            this.button6.HighEmphasis = true;
            this.button6.Icon = null;
            this.button6.Location = new System.Drawing.Point(25, 20);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button6.MouseState = MaterialSkin.MouseState.HOVER;
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Pesquisar";
            this.button6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button6.UseAccentColor = false;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gvPedido
            // 
            this.gvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvPedido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvPedido.Location = new System.Drawing.Point(6, 19);
            this.gvPedido.MultiSelect = false;
            this.gvPedido.Name = "gvPedido";
            this.gvPedido.ReadOnly = true;
            this.gvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPedido.Size = new System.Drawing.Size(1036, 278);
            this.gvPedido.StandardTab = true;
            this.gvPedido.TabIndex = 1;
            this.gvPedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPedido_CellClick);
            this.gvPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvPedido);
            this.groupBox2.Location = new System.Drawing.Point(6, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 303);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbValor);
            this.groupBox3.Controls.Add(this.lbData);
            this.groupBox3.Controls.Add(this.lbItens);
            this.groupBox3.Controls.Add(this.lbComprador);
            this.groupBox3.Controls.Add(this.lbID);
            this.groupBox3.Controls.Add(this.lbLista);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Location = new System.Drawing.Point(6, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 137);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Produto";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Depth = 0;
            this.lbValor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbValor.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbValor.Location = new System.Drawing.Point(152, 105);
            this.lbValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(57, 17);
            this.lbValor.TabIndex = 7;
            this.lbValor.Text = "Valor R$:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Depth = 0;
            this.lbData.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbData.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbData.Location = new System.Drawing.Point(318, 16);
            this.lbData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(34, 17);
            this.lbData.TabIndex = 7;
            this.lbData.Text = "Data:";
            // 
            // lbItens
            // 
            this.lbItens.AutoSize = true;
            this.lbItens.Depth = 0;
            this.lbItens.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbItens.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbItens.Location = new System.Drawing.Point(153, 76);
            this.lbItens.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(35, 17);
            this.lbItens.TabIndex = 7;
            this.lbItens.Text = "Itens:";
            // 
            // lbComprador
            // 
            this.lbComprador.AutoSize = true;
            this.lbComprador.Depth = 0;
            this.lbComprador.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbComprador.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbComprador.Location = new System.Drawing.Point(318, 46);
            this.lbComprador.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbComprador.Name = "lbComprador";
            this.lbComprador.Size = new System.Drawing.Size(75, 17);
            this.lbComprador.TabIndex = 7;
            this.lbComprador.Text = "Comprador:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Depth = 0;
            this.lbID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbID.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbID.Location = new System.Drawing.Point(153, 16);
            this.lbID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(17, 17);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID:";
            // 
            // lbLista
            // 
            this.lbLista.AutoSize = true;
            this.lbLista.Depth = 0;
            this.lbLista.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbLista.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbLista.Location = new System.Drawing.Point(153, 46);
            this.lbLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(35, 17);
            this.lbLista.TabIndex = 7;
            this.lbLista.Text = "Lista:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(704, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 137);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pedido";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(140, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 100);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // button1
            // 
            this.button1.AutoSize = false;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(19, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button6_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = false;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(19, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Novo";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = false;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button3.Depth = 0;
            this.button3.HighEmphasis = true;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(19, 98);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Apagar";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.btnExportar);
            this.groupBox5.Location = new System.Drawing.Point(549, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 136);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exportar";
            // 
            // button4
            // 
            this.button4.AutoSize = false;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button4.Depth = 0;
            this.button4.HighEmphasis = true;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(16, 86);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "PDF";
            this.button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button4.UseAccentColor = false;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // CriarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 723);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CriarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pedido";
            this.Load += new System.EventHandler(this.CriarPedido_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialTextBox tbCategoria;
        private MaterialSkin.Controls.MaterialTextBox tbFornecedor;
        private MaterialSkin.Controls.MaterialTextBox tbProduto;
        private MaterialSkin.Controls.MaterialTextBox tbCod;
        private MaterialSkin.Controls.MaterialTextBox tbPrecoAtual;
        private MaterialSkin.Controls.MaterialTextBox tbQtd;
        private MaterialSkin.Controls.MaterialButton btnExportar;
        private MaterialSkin.Controls.MaterialButton button7;
        private MaterialSkin.Controls.MaterialButton button6;
        private MaterialSkin.Controls.MaterialButton button9;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialButton btnExcluir;
        private MaterialSkin.Controls.MaterialButton button4;
        private MaterialSkin.Controls.MaterialLabel lbValor;
        private MaterialSkin.Controls.MaterialLabel lbItens;
        private MaterialSkin.Controls.MaterialLabel lbID;
        private MaterialSkin.Controls.MaterialLabel lbLista;
        private MaterialSkin.Controls.MaterialLabel lbData;
        private MaterialSkin.Controls.MaterialLabel lbComprador;
    }
}