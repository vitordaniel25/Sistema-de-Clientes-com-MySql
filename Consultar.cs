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
        string strSQL;
        DataTable resultados = null;

        public DataTable consultarNome(string Valor)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database= SISTEMADECLIENTES; Uid=root; Pwd=1234;");
                strSQL = "SELECT * FROM CLIENTES WHERE NOME LIKE '" + Valor + "%'";
                dataAdapter = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                resultados = dt;
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
            return (resultados);
        }
        public DataTable consultarID(string Valor)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database= SISTEMADECLIENTES; Uid=root; Pwd=1234;");
                strSQL = "SELECT * FROM CLIENTES WHERE ID = " + Valor;

                dataAdapter = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                resultados = dt;
            }

            catch
            {
                MessageBox.Show("Digite um ID válido!");
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return (resultados);
        }



        public DataTable consultarTodos()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database= SISTEMADECLIENTES; Uid=root; Pwd=1234;");
                strSQL = "SELECT * FROM CLIENTES";
                dataAdapter = new MySqlDataAdapter(strSQL, conexao);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                resultados = dt;
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
            return (resultados);
        }
    }
}
