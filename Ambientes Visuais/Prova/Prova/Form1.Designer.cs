namespace Prova
{
    partial class Locadora
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.lbdescicao = new System.Windows.Forms.Label();
            this.gbDadosVeiculo = new System.Windows.Forms.GroupBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.cbTipoCli = new System.Windows.Forms.ComboBox();
            this.lbTipoCli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.gbValores = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btRemoever = new System.Windows.Forms.Button();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbCNH = new System.Windows.Forms.Label();
            this.tbCNH = new System.Windows.Forms.TextBox();
            this.clCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValorAluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masktbDataFim = new System.Windows.Forms.MaskedTextBox();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.maskTbDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiarias = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.painelPrincipal.SuspendLayout();
            this.gbDadosVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            this.gbValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.lbdescicao);
            this.painelPrincipal.Location = new System.Drawing.Point(34, 13);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(813, 48);
            this.painelPrincipal.TabIndex = 0;
            // 
            // lbdescicao
            // 
            this.lbdescicao.AutoSize = true;
            this.lbdescicao.Location = new System.Drawing.Point(378, 14);
            this.lbdescicao.Name = "lbdescicao";
            this.lbdescicao.Size = new System.Drawing.Size(55, 13);
            this.lbdescicao.TabIndex = 0;
            this.lbdescicao.Text = "Descrição";
            // 
            // gbDadosVeiculo
            // 
            this.gbDadosVeiculo.Controls.Add(this.lbCNH);
            this.gbDadosVeiculo.Controls.Add(this.textBox1);
            this.gbDadosVeiculo.Controls.Add(this.lbDiarias);
            this.gbDadosVeiculo.Controls.Add(this.tbCNH);
            this.gbDadosVeiculo.Controls.Add(this.maskTbDataInicio);
            this.gbDadosVeiculo.Controls.Add(this.masktbDataFim);
            this.gbDadosVeiculo.Controls.Add(this.lbNome);
            this.gbDadosVeiculo.Controls.Add(this.btRemoever);
            this.gbDadosVeiculo.Controls.Add(this.tbNome);
            this.gbDadosVeiculo.Controls.Add(this.cbTipoCli);
            this.gbDadosVeiculo.Controls.Add(this.btIncluir);
            this.gbDadosVeiculo.Controls.Add(this.lbTipoCli);
            this.gbDadosVeiculo.Controls.Add(this.lbDataFim);
            this.gbDadosVeiculo.Controls.Add(this.label1);
            this.gbDadosVeiculo.Controls.Add(this.lbCod);
            this.gbDadosVeiculo.Controls.Add(this.tbCodigo);
            this.gbDadosVeiculo.Location = new System.Drawing.Point(34, 79);
            this.gbDadosVeiculo.Name = "gbDadosVeiculo";
            this.gbDadosVeiculo.Size = new System.Drawing.Size(274, 288);
            this.gbDadosVeiculo.TabIndex = 1;
            this.gbDadosVeiculo.TabStop = false;
            this.gbDadosVeiculo.Text = "Veiculo";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(168, 23);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 2;
            this.tbCodigo.Leave += new System.EventHandler(this.tbCodigo_Leave);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(77, 29);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(43, 13);
            this.lbCod.TabIndex = 3;
            this.lbCod.Text = "Código:";
            // 
            // cbTipoCli
            // 
            this.cbTipoCli.FormattingEnabled = true;
            this.cbTipoCli.Items.AddRange(new object[] {
            "Coorporativo",
            "Particular",
            ""});
            this.cbTipoCli.Location = new System.Drawing.Point(168, 137);
            this.cbTipoCli.Name = "cbTipoCli";
            this.cbTipoCli.Size = new System.Drawing.Size(100, 21);
            this.cbTipoCli.TabIndex = 8;
            // 
            // lbTipoCli
            // 
            this.lbTipoCli.AutoSize = true;
            this.lbTipoCli.Location = new System.Drawing.Point(39, 140);
            this.lbTipoCli.Name = "lbTipoCli";
            this.lbTipoCli.Size = new System.Drawing.Size(81, 13);
            this.lbTipoCli.TabIndex = 9;
            this.lbTipoCli.Text = "Tipo de Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Cartão a Vista",
            "Cartão a Prazo"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(165, 16);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(100, 21);
            this.cbFormaPagamento.TabIndex = 11;
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCod,
            this.clMarca,
            this.clModelo,
            this.clValorAluguel,
            this.clDataInicio,
            this.clDataFim});
            this.dgvVeiculo.Location = new System.Drawing.Point(339, 79);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.Size = new System.Drawing.Size(498, 225);
            this.dgvVeiculo.TabIndex = 2;
            // 
            // gbValores
            // 
            this.gbValores.Controls.Add(this.btFinalizar);
            this.gbValores.Controls.Add(this.tbTotal);
            this.gbValores.Controls.Add(this.lbTotal);
            this.gbValores.Controls.Add(this.cbFormaPagamento);
            this.gbValores.Controls.Add(this.label2);
            this.gbValores.Location = new System.Drawing.Point(34, 377);
            this.gbValores.Name = "gbValores";
            this.gbValores.Size = new System.Drawing.Size(274, 100);
            this.gbValores.TabIndex = 3;
            this.gbValores.TabStop = false;
            this.gbValores.Text = "Pagamento";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(83, 39);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(165, 43);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 4;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(112, 249);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 4;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btRemoever
            // 
            this.btRemoever.Location = new System.Drawing.Point(193, 249);
            this.btRemoever.Name = "btRemoever";
            this.btRemoever.Size = new System.Drawing.Size(75, 23);
            this.btRemoever.TabIndex = 5;
            this.btRemoever.Text = "Remover";
            this.btRemoever.UseVisualStyleBackColor = true;
            // 
            // btFinalizar
            // 
            this.btFinalizar.Location = new System.Drawing.Point(190, 71);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btFinalizar.TabIndex = 4;
            this.btFinalizar.Text = "Finalizar";
            this.btFinalizar.UseVisualStyleBackColor = true;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(82, 180);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(168, 177);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 5;
            // 
            // lbCNH
            // 
            this.lbCNH.AutoSize = true;
            this.lbCNH.Location = new System.Drawing.Point(82, 206);
            this.lbCNH.Name = "lbCNH";
            this.lbCNH.Size = new System.Drawing.Size(33, 13);
            this.lbCNH.TabIndex = 10;
            this.lbCNH.Text = "CNH:";
            // 
            // tbCNH
            // 
            this.tbCNH.Location = new System.Drawing.Point(168, 203);
            this.tbCNH.Name = "tbCNH";
            this.tbCNH.Size = new System.Drawing.Size(100, 20);
            this.tbCNH.TabIndex = 11;
            // 
            // clCod
            // 
            this.clCod.HeaderText = "Código";
            this.clCod.Name = "clCod";
            // 
            // clMarca
            // 
            this.clMarca.HeaderText = "Marca";
            this.clMarca.Name = "clMarca";
            // 
            // clModelo
            // 
            this.clModelo.HeaderText = "Modelo";
            this.clModelo.Name = "clModelo";
            // 
            // clValorAluguel
            // 
            this.clValorAluguel.HeaderText = "Valor do Aluguel";
            this.clValorAluguel.Name = "clValorAluguel";
            // 
            // clDataInicio
            // 
            this.clDataInicio.HeaderText = "Data de Inicio";
            this.clDataInicio.Name = "clDataInicio";
            // 
            // clDataFim
            // 
            this.clDataFim.HeaderText = "Data do Fim";
            this.clDataFim.Name = "clDataFim";
            // 
            // masktbDataFim
            // 
            this.masktbDataFim.Location = new System.Drawing.Point(168, 82);
            this.masktbDataFim.Mask = "00/00/0000";
            this.masktbDataFim.Name = "masktbDataFim";
            this.masktbDataFim.Size = new System.Drawing.Size(100, 20);
            this.masktbDataFim.TabIndex = 10;
            this.masktbDataFim.ValidatingType = typeof(System.DateTime);
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Location = new System.Drawing.Point(56, 84);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(64, 13);
            this.lbDataFim.TabIndex = 6;
            this.lbDataFim.Text = "Data de fim:";
            // 
            // maskTbDataInicio
            // 
            this.maskTbDataInicio.Location = new System.Drawing.Point(168, 53);
            this.maskTbDataInicio.Mask = "00/00/0000";
            this.maskTbDataInicio.Name = "maskTbDataInicio";
            this.maskTbDataInicio.Size = new System.Drawing.Size(100, 20);
            this.maskTbDataInicio.TabIndex = 11;
            this.maskTbDataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data de Inicio:";
            // 
            // lbDiarias
            // 
            this.lbDiarias.AutoSize = true;
            this.lbDiarias.Location = new System.Drawing.Point(75, 111);
            this.lbDiarias.Name = "lbDiarias";
            this.lbDiarias.Size = new System.Drawing.Size(42, 13);
            this.lbDiarias.TabIndex = 12;
            this.lbDiarias.Text = "Diarias:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Locadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 478);
            this.Controls.Add(this.gbValores);
            this.Controls.Add(this.dgvVeiculo);
            this.Controls.Add(this.gbDadosVeiculo);
            this.Controls.Add(this.painelPrincipal);
            this.Name = "Locadora";
            this.Text = "Locadora de Veiculos";
            this.painelPrincipal.ResumeLayout(false);
            this.painelPrincipal.PerformLayout();
            this.gbDadosVeiculo.ResumeLayout(false);
            this.gbDadosVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            this.gbValores.ResumeLayout(false);
            this.gbValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Label lbdescicao;
        private System.Windows.Forms.GroupBox gbDadosVeiculo;
        private System.Windows.Forms.Label lbTipoCli;
        private System.Windows.Forms.ComboBox cbTipoCli;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVeiculo;
        private System.Windows.Forms.GroupBox gbValores;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btRemoever;
        private System.Windows.Forms.Button btFinalizar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbCNH;
        private System.Windows.Forms.TextBox tbCNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValorAluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataFim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDiarias;
        private System.Windows.Forms.MaskedTextBox maskTbDataInicio;
        private System.Windows.Forms.MaskedTextBox masktbDataFim;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Label label1;
    }
}

