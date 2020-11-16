using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemasDeClientes
{
    class cliente
    {
        public string ID, nome, email, telefone, data, cpf, rua, bairro, cidade, numero, cep, uf;
    }
    class Atualizar
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public cliente mostrarCliente(string ID)
        {
            var a = new cliente();
            a.nome = "";
            try
            {
                conexao = new MySqlConnection(MySqlParametros.Rota);

                strSQL = "SELECT * FROM CLIENTES WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", ID);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {                  
                    
                    a.ID = Convert.ToString(dr["ID"]);
                    a.nome = Convert.ToString(dr["nome"]);
                    a.cpf = Convert.ToString(dr["cpf"]);
                    a.numero = Convert.ToString(dr["numero"]);
                    a.email = Convert.ToString(dr["email"]);
                    a.cep = Convert.ToString(dr["cep"]);
                    a.rua = Convert.ToString(dr["rua"]);
                    a.uf = Convert.ToString(dr["uf"]);
                    a.bairro = Convert.ToString(dr["bairro"]);
                    a.cidade = Convert.ToString(dr["cidade"]);
                    a.telefone = Convert.ToString(dr["telefone"]);
                    a.data = Convert.ToString(dr["data"]);
                }
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
            return (a);
        }
        public bool atualizarCliente(string ID, string nome, string email, string telefone, string data, string cpf, string rua,
            string bairro, string cidade, string numero, string cep, string uf)
        {
            bool limpar = false;
            try
            {
                conexao = new MySqlConnection("Server=localhost; Database=SISTEMADECLIENTES; Uid=root; Pwd=1234;");

                strSQL = "UPDATE CLIENTES SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE, DATA = @DATA, CPF = @CPF, CEP = @CEP, RUA = @RUA, NUMERO = @NUMERO, UF = @UF, CIDADE = @CIDADE, BAIRRO = @BAIRRO WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao); 
                comando.Parameters.AddWithValue("@ID", ID);
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
                MessageBox.Show("Atualizado com sucesso!");
                limpar = true;
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
            return limpar;
        }
    }
}
