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
    public partial class CriarPedido : Form
    {
        public CriarPedido()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Farmacia.Criar_Pedido.cpLista cpl = new Criar_Pedido.cpLista();
            cpl.ShowDialog();
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {

            textBox1.Text = Classes.vPedido.cod;
            textBox2.Text = Classes.vPedido.Produto;
        }

        private void CriarPedido_Shown(object sender, EventArgs e)
        {
            textBox1.Text = Classes.vPedido.cod;
            textBox2.Text = Classes.vPedido.Produto;
        }

        private void CriarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Classes.vPedido.cod = "";
        }

        private void CriarPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = Classes.vPedido.cod;
            textBox2.Text = Classes.vPedido.Produto;
        }

        private void CriarPedido_Enter(object sender, EventArgs e)
        {
            textBox1.Text = Classes.vPedido.cod;
            textBox2.Text = Classes.vPedido.Produto;
        }
    }
}
