namespace SistemasDeClientes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbData = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUF = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.btVoltar2 = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btID = new System.Windows.Forms.Button();
            this.btNome = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlHome.Controls.Add(this.pictureBox1);
            this.pnlHome.Controls.Add(this.btConsultar);
            this.pnlHome.Controls.Add(this.btNovo);
            this.pnlHome.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHome.ForeColor = System.Drawing.Color.White;
            this.pnlHome.Location = new System.Drawing.Point(0, 40);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(657, 560);
            this.pnlHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemasDeClientes.Properties.Resources.icone22;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(27, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 433);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btConsultar.FlatAppearance.BorderSize = 0;
            this.btConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConsultar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btConsultar.Location = new System.Drawing.Point(28, 488);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(295, 60);
            this.btConsultar.TabIndex = 1;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btNovo.Location = new System.Drawing.Point(332, 488);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(295, 60);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlCadastro.Controls.Add(this.btVoltar);
            this.pnlCadastro.Controls.Add(this.btCadastrar);
            this.pnlCadastro.Controls.Add(this.txbCEP);
            this.pnlCadastro.Controls.Add(this.label11);
            this.pnlCadastro.Controls.Add(this.txbCPF);
            this.pnlCadastro.Controls.Add(this.txbTelefone);
            this.pnlCadastro.Controls.Add(this.txbData);
            this.pnlCadastro.Controls.Add(this.label4);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.txbUF);
            this.pnlCadastro.Controls.Add(this.txbNumero);
            this.pnlCadastro.Controls.Add(this.label9);
            this.pnlCadastro.Controls.Add(this.txbBairro);
            this.pnlCadastro.Controls.Add(this.label8);
            this.pnlCadastro.Controls.Add(this.label6);
            this.pnlCadastro.Controls.Add(this.txbCidade);
            this.pnlCadastro.Controls.Add(this.label7);
            this.pnlCadastro.Controls.Add(this.txbRua);
            this.pnlCadastro.Controls.Add(this.label5);
            this.pnlCadastro.Controls.Add(this.label14);
            this.pnlCadastro.Controls.Add(this.txbEmail);
            this.pnlCadastro.Controls.Add(this.label13);
            this.pnlCadastro.Controls.Add(this.txbNome);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCadastro.ForeColor = System.Drawing.Color.White;
            this.pnlCadastro.Location = new System.Drawing.Point(0, 40);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(657, 560);
            this.pnlCadastro.TabIndex = 1;
            this.pnlCadastro.Visible = false;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btVoltar.Location = new System.Drawing.Point(28, 488);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(295, 60);
            this.btVoltar.TabIndex = 13;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btCadastrar.Location = new System.Drawing.Point(332, 488);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(295, 60);
            this.btCadastrar.TabIndex = 12;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txbCEP
            // 
            this.txbCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbCEP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCEP.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txbCEP.ForeColor = System.Drawing.Color.White;
            this.txbCEP.Location = new System.Drawing.Point(454, 175);
            this.txbCEP.Mask = "00000-000";
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(173, 35);
            this.txbCEP.TabIndex = 4;
            this.txbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label11.Location = new System.Drawing.Point(22, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Novo Cliente";
            // 
            // txbCPF
            // 
            this.txbCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCPF.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txbCPF.ForeColor = System.Drawing.Color.White;
            this.txbCPF.Location = new System.Drawing.Point(232, 175);
            this.txbCPF.Mask = "000.000.000-00";
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(216, 35);
            this.txbCPF.TabIndex = 3;
            this.txbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbData
            // 
            this.txbData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbData.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txbData.ForeColor = System.Drawing.Color.White;
            this.txbData.Location = new System.Drawing.Point(28, 175);
            this.txbData.Mask = "00/00/0000";
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(196, 35);
            this.txbData.TabIndex = 2;
            this.txbData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(450, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "CEP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(230, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data de Nascimento";
            // 
            // txbUF
            // 
            this.txbUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbUF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbUF.ForeColor = System.Drawing.Color.White;
            this.txbUF.Location = new System.Drawing.Point(553, 246);
            this.txbUF.Name = "txbUF";
            this.txbUF.Size = new System.Drawing.Size(74, 34);
            this.txbUF.TabIndex = 7;
            // 
            // txbNumero
            // 
            this.txbNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbNumero.ForeColor = System.Drawing.Color.White;
            this.txbNumero.Location = new System.Drawing.Point(444, 246);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(103, 34);
            this.txbNumero.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label9.Location = new System.Drawing.Point(549, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "UF";
            // 
            // txbBairro
            // 
            this.txbBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbBairro.ForeColor = System.Drawing.Color.White;
            this.txbBairro.Location = new System.Drawing.Point(353, 313);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(274, 34);
            this.txbBairro.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label8.Location = new System.Drawing.Point(440, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.Location = new System.Drawing.Point(349, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bairro";
            // 
            // txbCidade
            // 
            this.txbCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbCidade.ForeColor = System.Drawing.Color.White;
            this.txbCidade.Location = new System.Drawing.Point(28, 313);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(319, 34);
            this.txbCidade.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.Location = new System.Drawing.Point(23, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cidade";
            // 
            // txbRua
            // 
            this.txbRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbRua.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbRua.ForeColor = System.Drawing.Color.White;
            this.txbRua.Location = new System.Drawing.Point(28, 246);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(410, 34);
            this.txbRua.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.Location = new System.Drawing.Point(23, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label14.Location = new System.Drawing.Point(22, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Telefone";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbEmail.ForeColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(27, 384);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(599, 34);
            this.txbEmail.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label13.Location = new System.Drawing.Point(22, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "Email";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbNome.ForeColor = System.Drawing.Color.White;
            this.txbNome.Location = new System.Drawing.Point(28, 106);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(599, 34);
            this.txbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.btMinimizar);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 40);
            this.panel2.TabIndex = 2;
            // 
            // btMinimizar
            // 
            this.btMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btMinimizar.BackgroundImage = global::SistemasDeClientes.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(582, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btMinimizar.TabIndex = 0;
            this.btMinimizar.UseVisualStyleBackColor = false;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = global::SistemasDeClientes.Properties.Resources.Fechar;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(620, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label10.Location = new System.Drawing.Point(23, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sistema de Clientes";
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlConsulta.Controls.Add(this.label12);
            this.pnlConsulta.Controls.Add(this.dgvBuscar);
            this.pnlConsulta.Controls.Add(this.btVoltar2);
            this.pnlConsulta.Controls.Add(this.btTodos);
            this.pnlConsulta.Controls.Add(this.btID);
            this.pnlConsulta.Controls.Add(this.btNome);
            this.pnlConsulta.Controls.Add(this.btBuscar);
            this.pnlConsulta.Controls.Add(this.txbBuscar);
            this.pnlConsulta.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConsulta.ForeColor = System.Drawing.Color.White;
            this.pnlConsulta.Location = new System.Drawing.Point(0, 40);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(657, 560);
            this.pnlConsulta.TabIndex = 5;
            this.pnlConsulta.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label12.Location = new System.Drawing.Point(22, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 31);
            this.label12.TabIndex = 6;
            this.label12.Text = "Consultar Cliente";
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Location = new System.Drawing.Point(27, 162);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.RowHeadersWidth = 51;
            this.dgvBuscar.RowTemplate.Height = 24;
            this.dgvBuscar.Size = new System.Drawing.Size(599, 320);
            this.dgvBuscar.TabIndex = 5;
            // 
            // btVoltar2
            // 
            this.btVoltar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btVoltar2.FlatAppearance.BorderSize = 0;
            this.btVoltar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btVoltar2.Location = new System.Drawing.Point(27, 488);
            this.btVoltar2.Name = "btVoltar2";
            this.btVoltar2.Size = new System.Drawing.Size(295, 60);
            this.btVoltar2.TabIndex = 3;
            this.btVoltar2.Text = "Voltar";
            this.btVoltar2.UseVisualStyleBackColor = false;
            this.btVoltar2.Click += new System.EventHandler(this.btVoltar2_Click);
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btTodos.FlatAppearance.BorderSize = 0;
            this.btTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTodos.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btTodos.Location = new System.Drawing.Point(540, 87);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(86, 29);
            this.btTodos.TabIndex = 4;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            // 
            // btID
            // 
            this.btID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btID.FlatAppearance.BorderSize = 0;
            this.btID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btID.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btID.Location = new System.Drawing.Point(120, 87);
            this.btID.Name = "btID";
            this.btID.Size = new System.Drawing.Size(86, 29);
            this.btID.TabIndex = 4;
            this.btID.Text = "ID";
            this.btID.UseVisualStyleBackColor = false;
            // 
            // btNome
            // 
            this.btNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btNome.FlatAppearance.BorderSize = 0;
            this.btNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNome.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btNome.Location = new System.Drawing.Point(28, 87);
            this.btNome.Name = "btNome";
            this.btNome.Size = new System.Drawing.Size(86, 29);
            this.btNome.TabIndex = 4;
            this.btNome.Text = "Nome";
            this.btNome.UseVisualStyleBackColor = false;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btBuscar.Location = new System.Drawing.Point(331, 488);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(295, 60);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            // 
            // txbBuscar
            // 
            this.txbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txbBuscar.ForeColor = System.Drawing.Color.White;
            this.txbBuscar.Location = new System.Drawing.Point(28, 122);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(599, 34);
            this.txbBuscar.TabIndex = 1;
            // 
            // txbTelefone
            // 
            this.txbTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.txbTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTelefone.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txbTelefone.ForeColor = System.Drawing.Color.White;
            this.txbTelefone.Location = new System.Drawing.Point(28, 445);
            this.txbTelefone.Mask = "(00)0 0000 0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(196, 35);
            this.txbTelefone.TabIndex = 11;
            this.txbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 49F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(657, 600);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txbCEP;
        private System.Windows.Forms.MaskedTextBox txbCPF;
        private System.Windows.Forms.MaskedTextBox txbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbUF;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Button btVoltar2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btID;
        private System.Windows.Forms.Button btNome;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
    }
}

