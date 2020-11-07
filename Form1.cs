using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeClientes
{
    public partial class Form1 : Form
    {
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
            var salvar = new ConexãoSql();
            salvar.SalvarNoBanco(txbNome.Text, txbEmail.Text, txbTelefone.Text, txbData.Text, txbCPF.Text, txbRua.Text,
            txbBairro.Text, txbCidade.Text, txbNumero.Text, txbCEP.Text, txbUF.Text);
        }
    }
}
