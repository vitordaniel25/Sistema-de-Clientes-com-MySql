using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemasDeClientes
{
    class ConexãoSql
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter dataAdapter;
        MySqlDataReader dataReader;
        string strSQL;
    
        public void SalvarNoBanco(string nome,string email, string telefone, string data, string cpf, string rua, 
            string bairro, string cidade, string numero, string cep, string uf)
        {
            
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database= SISTEMADECLIENTES; Uid=root; Pwd=1234;");

                strSQL = "INSERT INTO CLIENTES" + " (NOME,EMAIL,TELEFONE, DATA, CPF, CEP, RUA, NUMERO, UF, CIDADE, BAIRRO) VALUES (@NOME,@EMAIL,@TELEFONE, @DATA, @CPF, @CEP, @RUA, @NUMERO, @UF, @CIDADE, @BAIRRO)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", nome);
                comando.Parameters.AddWithValue("@EMAIL", email);
                comando.Parameters.AddWithValue("@TELEFONE", telefone);
                comando.Parameters.AddWithValue("@DATA", data);
                comando.Parameters.AddWithValue("@CPF", cpf);
                comando.Parameters.AddWithValue("@CEP", cep);
                comando.Parameters.AddWithValue("@RUA", rua);
                comando.Parameters.AddWithValue("@NUMERO", numero);
                comando.Parameters.AddWithValue("@UF", uf);
                comando.Parameters.AddWithValue("@CIDADE", cidade);
                comando.Parameters.AddWithValue("@BAIRRO", bairro);

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
