using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemasDeClientes
{
    class Consultar
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter dataAdapter;
        MySqlDataReader dataReader;
        string strSQL;
    
        public DataTable ConsultarNoBanco(string Parametro, string Valor)
        {
            DataTable Final;
            
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database= SISTEMADECLIENTES; Uid=root; Pwd=1234;");
                switch (Parametro){
                    case "nome": strSQL = "SELECT * FROM CLIENTES WHERE NOME = @Valor";
                        break;
                    case "ID": strSQL = "SELECT * FROM CLIENTES WHERE ID = @Valor";
                        break;
                    case "todos": strSQL = "SELECT * FROM CLIENTES";
                        break;
                }


                dataAdapter = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                dataAdapter.Fill(dt);
                Final = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Final = (null);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return (Final);

        }

    }
}
