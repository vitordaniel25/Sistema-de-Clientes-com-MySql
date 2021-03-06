﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemasDeClientes
{
    class Casdastrar
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string strSQL;
    
        public bool SalvarNoBanco(string nome,string email, string telefone, string data, string cpf, string rua, 
            string bairro, string cidade, string numero, string cep, string uf)
        {
            if (numero == "")
            {
                numero = "0";
            }
            bool limpar = false;
            
            try
            {
                conexao = new MySqlConnection(MySqlParametros.Rota);

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
                MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
