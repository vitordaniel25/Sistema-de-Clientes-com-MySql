using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemasDeClientes
{
    public partial class Form1 : Form
    {
        string parametro = "nome";
        DataTable resultados;
        public Form1()
        {
            InitializeComponent();
        }



        private void btConsultar_Click(object sender, EventArgs e)
        {
            pnlConsulta.Visible = true;
            pnlHome.Visible = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlHome.Visible = false;
        }

        private void btVoltar2_Click(object sender, EventArgs e)
        {
            pnlConsulta.Visible = false;
            pnlHome.Visible = true;
            txbBuscar.Text = "";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlHome.Visible = true;
            limpar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text != "") {
                var salvar = new Casdastrar();
                bool boolLimpar = salvar.SalvarNoBanco(txbNome.Text, txbEmail.Text, txbTelefone.Text, txbData.Text, txbCPF.Text, txbRua.Text,
                txbBairro.Text, txbCidade.Text, txbNumero.Text, txbCEP.Text, txbUF.Text);
                if (boolLimpar) { limpar(); }
            }
            else
            {
                MessageBox.Show("Digite um nome!");
            }
        }
        private void limpar()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbTelefone.Text = "";
            txbData.Text = "";
            txbCPF.Text = "";
            txbRua.Text = "";
            txbBairro.Text = "";
            txbCidade.Text = "";
            txbNumero.Text = "";
            txbCEP.Text = "";
            txbUF.Text = "";
            txbID.Text = "";
            txbNomeEdit.Text = "";
            txbEmailEdit.Text = "";
            txbTelefoneEdit.Text = "";
            txbDataEdit.Text = "";
            txbCPFEdit.Text = "";
            txbRuaEdit.Text = "";
            txbBairroEdit.Text = "";
            txbCidadeEdit.Text = "";
            txbNumeroEdit.Text = "";
            txbCEPEdit.Text = "";
            txbUFEdit.Text = "";
            txbID.Text = "";
            txbMostrarID.Text = "";
        }


        private void btBuscar_Click(object sender, EventArgs e)
        {
            

            var buscar = new Consultar();
            switch (parametro)
            {
                case "todos":
                    {
                        resultados = buscar.consultarTodos();
                    }
                    break;
                case "ID":
                    {
                        if (txbBuscar.Text != "")
                        {
                            resultados = buscar.consultarID(txbBuscar.Text);
                        }
                        else
                        {
                            MessageBox.Show("Digite algo!");
                        }
                    }
                    break;
                case "nome":
                    {
                        if (txbBuscar.Text != "")
                        {
                            resultados = buscar.consultarNome(txbBuscar.Text);
                        }
                        else
                        {
                            MessageBox.Show("Digite algo!");
                        }
                    }
                    break;
            }
            dgvBuscar.DataSource = resultados;
            txbBuscar.Text = "";
        }

        private void btNome_Click(object sender, EventArgs e)
        {
            btNome.BackColor = Color.FromArgb(25, 40, 60);
            btNome.ForeColor = System.Drawing.Color.White;
            btID.ForeColor = System.Drawing.Color.DarkGray;
            btID.BackColor = System.Drawing.Color.DimGray;
            btTodos.ForeColor = System.Drawing.Color.DarkGray;
            btTodos.BackColor = System.Drawing.Color.DimGray;
            parametro = "nome";
            txbBuscar.Text = "";

        }

        private void btID_Click(object sender, EventArgs e)
        {
            btID.ForeColor = System.Drawing.Color.White;
            btID.BackColor = Color.FromArgb(25, 40, 60);
            btNome.ForeColor = System.Drawing.Color.DarkGray;
            btNome.BackColor = System.Drawing.Color.DimGray;
            btTodos.ForeColor = System.Drawing.Color.DarkGray;
            btTodos.BackColor = System.Drawing.Color.DimGray;
            parametro = "ID";
            txbBuscar.Text = "";
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            btTodos.ForeColor = System.Drawing.Color.White;
            btTodos.BackColor = Color.FromArgb(25, 40, 60);
            btNome.ForeColor = System.Drawing.Color.DarkGray;
            btNome.BackColor = System.Drawing.Color.DimGray;
            btID.ForeColor = System.Drawing.Color.DarkGray;
            btID.BackColor = System.Drawing.Color.DimGray;
            parametro = "todos";
            txbBuscar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consultaMax = new ConsultaMax(resultados);
            consultaMax.Show();
        }


        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            pnlAtualizar.Visible = true;
            pnlHome.Visible = false;
        }

        private void btVoltar3_Click(object sender, EventArgs e)
        {
            pnlAtualizar.Visible = false;
            pnlHome.Visible = true;
            camposDisnable();
            limpar();
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            camposDisnable();            
            var a = new Atualizar();
            var client = new cliente();
            client = a.mostrarCliente(txbID.Text);
            txbMostrarID.Text = client.ID;
            txbNomeEdit.Text = client.nome;
            txbDataEdit.Text = client.data;
            txbCPFEdit.Text = client.cpf;
            txbCEPEdit.Text = client.cep;
            txbNumeroEdit.Text = client.numero;
            txbEmailEdit.Text = client.email;
            txbRuaEdit.Text = client.rua;
            txbUFEdit.Text = client.uf;
            txbBairroEdit.Text = client.bairro;
            txbCidadeEdit.Text = client.cidade;
            txbTelefoneEdit.Text = client.telefone; 
            if (client.nome != "")
            {
                camposEnable();
            }
            else
            {
                MessageBox.Show("ID não encontrado!");
                limpar();

            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            var atualizar = new Atualizar();
            bool boolLimpar = atualizar.atualizarCliente(txbID.Text, txbNomeEdit.Text, txbEmailEdit.Text, txbTelefoneEdit.Text, txbDataEdit.Text, txbCPFEdit.Text, txbRuaEdit.Text,
            txbBairroEdit.Text, txbCidadeEdit.Text, txbNumeroEdit.Text, txbCEPEdit.Text, txbUFEdit.Text);
            if (boolLimpar) { limpar(); camposDisnable(); }
        }
        private void camposEnable()
        {
            txbNomeEdit.Enabled = true;
            txbDataEdit.Enabled = true;
            txbCPFEdit.Enabled = true;
            txbCEPEdit.Enabled = true;
            txbNumeroEdit.Enabled = true;
            txbEmailEdit.Enabled = true;
            txbRuaEdit.Enabled = true;
            txbUFEdit.Enabled = true;
            txbBairroEdit.Enabled = true;
            txbCidadeEdit.Enabled = true;
            txbTelefoneEdit.Enabled = true;
            btExcluir.Enabled = true;
            btAtualizarCliente.Enabled = true;
        }
        private void camposDisnable()
        {
            txbNomeEdit.Enabled = false;
            txbDataEdit.Enabled = false;
            txbCPFEdit.Enabled = false;
            txbCEPEdit.Enabled = false;
            txbNumeroEdit.Enabled = false;
            txbEmailEdit.Enabled = false;
            txbRuaEdit.Enabled = false;
            txbUFEdit.Enabled = false;
            txbBairroEdit.Enabled = false;
            txbCidadeEdit.Enabled = false;
            txbTelefoneEdit.Enabled = false;
            btExcluir.Enabled = false;
            btAtualizarCliente.Enabled = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2))
            {
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var excluir = new Excluir();
                excluir.excluir(txbID.Text);
                limpar();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
