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
		public static String id;
		public static String cod;
		public static long ean;
		public static String Produto;
		public static String Fornecedor;
		public static String Categoria;
		public static String PrecoAtual;
		public static String PrecoAnterior;
    }
}
