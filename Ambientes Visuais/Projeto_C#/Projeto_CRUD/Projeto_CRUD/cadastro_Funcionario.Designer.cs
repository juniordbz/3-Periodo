namespace Projeto_CRUD
{
    partial class formCadastro_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOp = new System.Windows.Forms.ComboBox();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.gbSistema = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.maskLocalizaCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskRg = new System.Windows.Forms.MaskedTextBox();
            this.gbDadosPessoais.SuspendLayout();
            this.gbSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o CPF:";
            // 
            // gbDadosPessoais
            // 
            this.gbDadosPessoais.Controls.Add(this.maskRg);
            this.gbDadosPessoais.Controls.Add(this.maskCpf);
            this.gbDadosPessoais.Controls.Add(this.tbEndereco);
            this.gbDadosPessoais.Controls.Add(this.label8);
            this.gbDadosPessoais.Controls.Add(this.label3);
            this.gbDadosPessoais.Controls.Add(this.label4);
            this.gbDadosPessoais.Controls.Add(this.label5);
            this.gbDadosPessoais.Controls.Add(this.tbNome);
            this.gbDadosPessoais.Controls.Add(this.label2);
            this.gbDadosPessoais.Controls.Add(this.cbOp);
            this.gbDadosPessoais.Location = new System.Drawing.Point(106, 84);
            this.gbDadosPessoais.Name = "gbDadosPessoais";
            this.gbDadosPessoais.Size = new System.Drawing.Size(335, 163);
            this.gbDadosPessoais.TabIndex = 2;
            this.gbDadosPessoais.TabStop = false;
            this.gbDadosPessoais.Text = "Dados Pessoais";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(108, 124);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(146, 20);
            this.tbEndereco.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(108, 46);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(146, 20);
            this.tbNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o cargo:";
            // 
            // cbOp
            // 
            this.cbOp.FormattingEnabled = true;
            this.cbOp.Items.AddRange(new object[] {
            "Gerente",
            "Funcionário"});
            this.cbOp.Location = new System.Drawing.Point(108, 19);
            this.cbOp.Name = "cbOp";
            this.cbOp.Size = new System.Drawing.Size(146, 21);
            this.cbOp.TabIndex = 3;
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(327, 56);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btLocalizar.TabIndex = 2;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // gbSistema
            // 
            this.gbSistema.Controls.Add(this.label9);
            this.gbSistema.Controls.Add(this.tbSenha);
            this.gbSistema.Controls.Add(this.label12);
            this.gbSistema.Controls.Add(this.tbUsuario);
            this.gbSistema.Location = new System.Drawing.Point(106, 258);
            this.gbSistema.Name = "gbSistema";
            this.gbSistema.Size = new System.Drawing.Size(335, 81);
            this.gbSistema.TabIndex = 8;
            this.gbSistema.TabStop = false;
            this.gbSistema.Text = "Sistema";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Usuário:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(108, 45);
            this.tbSenha.MaxLength = 8;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(146, 20);
            this.tbSenha.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Senha:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(108, 19);
            this.tbUsuario.MaxLength = 15;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(146, 20);
            this.tbUsuario.TabIndex = 8;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(124, 349);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 10;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(232, 349);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 11;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(337, 349);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // maskLocalizaCpf
            // 
            this.maskLocalizaCpf.Location = new System.Drawing.Point(221, 58);
            this.maskLocalizaCpf.Mask = "000.000.000-00";
            this.maskLocalizaCpf.Name = "maskLocalizaCpf";
            this.maskLocalizaCpf.Size = new System.Drawing.Size(100, 20);
            this.maskLocalizaCpf.TabIndex = 1;
            // 
            // maskCpf
            // 
            this.maskCpf.Location = new System.Drawing.Point(108, 98);
            this.maskCpf.Mask = "000.000.000-00";
            this.maskCpf.Name = "maskCpf";
            this.maskCpf.Size = new System.Drawing.Size(100, 20);
            this.maskCpf.TabIndex = 6;
            // 
            // maskRg
            // 
            this.maskRg.Location = new System.Drawing.Point(108, 72);
            this.maskRg.Mask = "00.000.000-0";
            this.maskRg.Name = "maskRg";
            this.maskRg.Size = new System.Drawing.Size(100, 20);
            this.maskRg.TabIndex = 5;
            // 
            // formCadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 460);
            this.Controls.Add(this.maskLocalizaCpf);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gbSistema);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.gbDadosPessoais);
            this.Controls.Add(this.label1);
            this.Name = "formCadastro_Funcionario";
            this.Text = "Cadastro de funcionarios";
            this.gbDadosPessoais.ResumeLayout(false);
            this.gbDadosPessoais.PerformLayout();
            this.gbSistema.ResumeLayout(false);
            this.gbSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDadosPessoais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOp;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbSistema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.MaskedTextBox maskLocalizaCpf;
        private System.Windows.Forms.MaskedTextBox maskCpf;
        private System.Windows.Forms.MaskedTextBox maskRg;
    }
}