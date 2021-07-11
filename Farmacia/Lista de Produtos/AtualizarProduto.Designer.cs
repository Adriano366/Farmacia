
namespace Farmacia.Lista_de_Produtos
{
    partial class AtualizarProduto
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
            this.tbValor = new MaterialSkin.Controls.MaterialTextBox();
            this.tbFornecedor = new MaterialSkin.Controls.MaterialComboBox();
            this.tbEAN = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCategoria = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCod = new MaterialSkin.Controls.MaterialTextBox();
            this.tbProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.button3 = new MaterialSkin.Controls.MaterialButton();
            this.button4 = new MaterialSkin.Controls.MaterialButton();
            this.button5 = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbValor);
            this.groupBox1.Controls.Add(this.tbFornecedor);
            this.groupBox1.Controls.Add(this.tbEAN);
            this.groupBox1.Controls.Add(this.tbCategoria);
            this.groupBox1.Controls.Add(this.tbCod);
            this.groupBox1.Controls.Add(this.tbProduto);
            this.groupBox1.Location = new System.Drawing.Point(13, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // tbValor
            // 
            this.tbValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbValor.Depth = 0;
            this.tbValor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbValor.Hint = "R$";
            this.tbValor.LeadingIcon = null;
            this.tbValor.Location = new System.Drawing.Point(21, 275);
            this.tbValor.MaxLength = 50;
            this.tbValor.MouseState = MaterialSkin.MouseState.OUT;
            this.tbValor.Multiline = false;
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(140, 50);
            this.tbValor.TabIndex = 5;
            this.tbValor.Text = "";
            this.tbValor.TrailingIcon = null;
            // 
            // tbFornecedor
            // 
            this.tbFornecedor.AutoResize = false;
            this.tbFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbFornecedor.Depth = 0;
            this.tbFornecedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tbFornecedor.DropDownHeight = 174;
            this.tbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbFornecedor.DropDownWidth = 121;
            this.tbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbFornecedor.FormattingEnabled = true;
            this.tbFornecedor.Hint = "Fornecedor";
            this.tbFornecedor.IntegralHeight = false;
            this.tbFornecedor.ItemHeight = 43;
            this.tbFornecedor.Location = new System.Drawing.Point(21, 202);
            this.tbFornecedor.MaxDropDownItems = 4;
            this.tbFornecedor.MouseState = MaterialSkin.MouseState.OUT;
            this.tbFornecedor.Name = "tbFornecedor";
            this.tbFornecedor.Size = new System.Drawing.Size(274, 49);
            this.tbFornecedor.StartIndex = 0;
            this.tbFornecedor.TabIndex = 3;
            // 
            // tbEAN
            // 
            this.tbEAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEAN.Depth = 0;
            this.tbEAN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEAN.Hint = "EAN";
            this.tbEAN.LeadingIcon = null;
            this.tbEAN.Location = new System.Drawing.Point(317, 120);
            this.tbEAN.MaxLength = 50;
            this.tbEAN.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEAN.Multiline = false;
            this.tbEAN.Name = "tbEAN";
            this.tbEAN.Size = new System.Drawing.Size(195, 50);
            this.tbEAN.TabIndex = 2;
            this.tbEAN.Text = "";
            this.tbEAN.TrailingIcon = null;
            // 
            // tbCategoria
            // 
            this.tbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCategoria.Depth = 0;
            this.tbCategoria.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCategoria.Hint = "Categoria";
            this.tbCategoria.LeadingIcon = null;
            this.tbCategoria.Location = new System.Drawing.Point(317, 201);
            this.tbCategoria.MaxLength = 50;
            this.tbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCategoria.Multiline = false;
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(195, 50);
            this.tbCategoria.TabIndex = 4;
            this.tbCategoria.Text = "";
            this.tbCategoria.TrailingIcon = null;
            // 
            // tbCod
            // 
            this.tbCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCod.Depth = 0;
            this.tbCod.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCod.Hint = "Código";
            this.tbCod.LeadingIcon = null;
            this.tbCod.Location = new System.Drawing.Point(21, 38);
            this.tbCod.MaxLength = 50;
            this.tbCod.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCod.Multiline = false;
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(101, 50);
            this.tbCod.TabIndex = 0;
            this.tbCod.Text = "";
            this.tbCod.TrailingIcon = null;
            this.tbCod.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // tbProduto
            // 
            this.tbProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProduto.Depth = 0;
            this.tbProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbProduto.Hint = "Produto";
            this.tbProduto.LeadingIcon = null;
            this.tbProduto.Location = new System.Drawing.Point(21, 120);
            this.tbProduto.MaxLength = 50;
            this.tbProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.tbProduto.Multiline = false;
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(274, 50);
            this.tbProduto.TabIndex = 1;
            this.tbProduto.Text = "";
            this.tbProduto.TrailingIcon = null;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button2
            // 
            this.button2.AutoSize = false;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(555, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 46);
            this.button2.TabIndex = 24;
            this.button2.Text = "Limpar";
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
            this.button3.Location = new System.Drawing.Point(555, 146);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Verificar";
            this.button3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button3.UseAccentColor = false;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = false;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button4.Depth = 0;
            this.button4.HighEmphasis = true;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(555, 372);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Atualizar";
            this.button4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button4.UseAccentColor = false;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = false;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button5.Depth = 0;
            this.button5.HighEmphasis = true;
            this.button5.Icon = null;
            this.button5.Location = new System.Drawing.Point(555, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button5.MouseState = MaterialSkin.MouseState.HOVER;
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 46);
            this.button5.TabIndex = 22;
            this.button5.Text = "Fechar";
            this.button5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button5.UseAccentColor = false;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AtualizarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 448);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AtualizarProduto";
            this.Text = "Atualizar Produtos";
            this.Load += new System.EventHandler(this.AtualizarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialTextBox tbCategoria;
        private MaterialSkin.Controls.MaterialTextBox tbProduto;
        private MaterialSkin.Controls.MaterialTextBox tbEAN;
        private MaterialSkin.Controls.MaterialButton button2;
        private MaterialSkin.Controls.MaterialButton button3;
        private MaterialSkin.Controls.MaterialButton button4;
        private MaterialSkin.Controls.MaterialButton button5;
        private MaterialSkin.Controls.MaterialTextBox tbValor;
        private MaterialSkin.Controls.MaterialTextBox tbCod;
        protected MaterialSkin.Controls.MaterialComboBox tbFornecedor;
    }
}