using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemasDeClientes
{
    class Excluir
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
        public void excluir(string ID)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database=SISTEMADECLIENTES; Uid=root; Pwd=1234;");

                strSQL = "DELETE FROM CLIENTES WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", ID);
                conexao.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
