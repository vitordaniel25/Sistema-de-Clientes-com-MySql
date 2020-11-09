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
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlHome.Visible = true;
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
            var salvar = new Casdastrar();
            bool boolLimpar = salvar.SalvarNoBanco(txbNome.Text, txbEmail.Text, txbTelefone.Text, txbData.Text, txbCPF.Text, txbRua.Text,
            txbBairro.Text, txbCidade.Text, txbNumero.Text, txbCEP.Text, txbUF.Text);
            if (boolLimpar) { limpar(); }
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consultaMax = new ConsultaMax(resultados);
            consultaMax.Show();
        }


        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
