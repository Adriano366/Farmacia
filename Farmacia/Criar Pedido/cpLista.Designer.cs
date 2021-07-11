
namespace Farmacia.Criar_Pedido
{
    partial class cpLista
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
            this.comboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.textBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(20, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoResize = false;
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBox1.Depth = 0;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.DropDownHeight = 174;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 121;
            this.comboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Hint = "Fornecedor";
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 43;
            this.comboBox1.Location = new System.Drawing.Point(18, 83);
            this.comboBox1.MaxDropDownItems = 4;
            this.comboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 49);
            this.comboBox1.StartIndex = 0;
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.AutoSize = false;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(18, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Depth = 0;
            this.textBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.Hint = "Categoria";
            this.textBox3.LeadingIcon = null;
            this.textBox3.Location = new System.Drawing.Point(262, 82);
            this.textBox3.MaxLength = 50;
            this.textBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox3.Multiline = false;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 50);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "";
            this.textBox3.TrailingIcon = null;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Hint = "Produto";
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(18, 27);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            this.textBox1.TrailingIcon = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(20, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 378);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cpLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "cpLista";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.cpLista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton button1;
        private MaterialSkin.Controls.MaterialTextBox textBox3;
        private MaterialSkin.Controls.MaterialTextBox textBox1;
        private MaterialSkin.Controls.MaterialComboBox comboBox1;
    }
}