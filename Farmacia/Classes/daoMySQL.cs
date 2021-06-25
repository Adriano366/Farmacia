using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Farmacia.Classes
{
    public class daoMySQL
    {

		private static readonly daoMySQL instanciaMySQL = new daoMySQL();

		private daoMySQL() { }

		public static daoMySQL getInstancia()
		{
			return instanciaMySQL;
		}

		public MySqlConnection getConexao()
		{
			string conn = ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString();
			return new MySqlConnection(conn);
		}
	}

	public class vPedido
    {
		public static int id_list;
		public static int id;
		public static String cod;
		public static String ean;
		public static String Produto;
		public static String Fornecedor;
		public static String Categoria;
		public static String PrecoAtual;
		public static String PrecoAnterior;

		public static String comprador;
		public static float valorTotal;
		public static int cntItens;
		public static String Data;
    }

	public class exProduto
	{
		public static int id { get; set; }
		public static String produto { get; set; }

	}
}
