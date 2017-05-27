namespace Projeto_CRUD
{
    partial class formCad_Produtos
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
            this.lbFornecedores = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.gbCadProd = new System.Windows.Forms.GroupBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.cbFornecedores = new System.Windows.Forms.ComboBox();
            this.tbProduto = new System.Windows.Forms.TextBox();
            this.lbLocalizar = new System.Windows.Forms.Label();
            this.tbLocalizar = new System.Windows.Forms.TextBox();
            this.gbCadProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFornecedores
            // 
            this.lbFornecedores.AutoSize = true;
            this.lbFornecedores.Location = new System.Drawing.Point(19, 22);
            this.lbFornecedores.Name = "lbFornecedores";
            this.lbFornecedores.Size = new System.Drawing.Size(75, 13);
            this.lbFornecedores.TabIndex = 0;
            this.lbFornecedores.Text = "Fornecedores:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(59, 101);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 1;
            this.lbValor.Text = "Valor:";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(29, 75);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 2;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(47, 49);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(47, 13);
            this.lbProduto.TabIndex = 3;
            this.lbProduto.Text = "Produto:";
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(271, 110);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btLocalizar.TabIndex = 2;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(96, 271);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(177, 271);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 8;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(258, 271);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // gbCadProd
            // 
            this.gbCadProd.Controls.Add(this.tbValor);
            this.gbCadProd.Controls.Add(this.tbQuantidade);
            this.gbCadProd.Controls.Add(this.cbFornecedores);
            this.gbCadProd.Controls.Add(this.tbProduto);
            this.gbCadProd.Controls.Add(this.lbFornecedores);
            this.gbCadProd.Controls.Add(this.lbValor);
            this.gbCadProd.Controls.Add(this.lbQuantidade);
            this.gbCadProd.Controls.Add(this.lbProduto);
            this.gbCadProd.Location = new System.Drawing.Point(93, 138);
            this.gbCadProd.Name = "gbCadProd";
            this.gbCadProd.Size = new System.Drawing.Size(243, 127);
            this.gbCadProd.TabIndex = 3;
            this.gbCadProd.TabStop = false;
            this.gbCadProd.Text = "Cadastro de produtos";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(100, 98);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 6;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(100, 72);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 5;
            // 
            // cbFornecedores
            // 
            this.cbFornecedores.FormattingEnabled = true;
            this.cbFornecedores.Location = new System.Drawing.Point(100, 19);
            this.cbFornecedores.Name = "cbFornecedores";
            this.cbFornecedores.Size = new System.Drawing.Size(121, 21);
            this.cbFornecedores.TabIndex = 3;
            this.cbFornecedores.SelectedIndexChanged += new System.EventHandler(this.cbFornecedores_SelectedIndexChanged);
            // 
            // tbProduto
            // 
            this.tbProduto.Location = new System.Drawing.Point(100, 46);
            this.tbProduto.Name = "tbProduto";
            this.tbProduto.Size = new System.Drawing.Size(100, 20);
            this.tbProduto.TabIndex = 4;
            // 
            // lbLocalizar
            // 
            this.lbLocalizar.AutoSize = true;
            this.lbLocalizar.Location = new System.Drawing.Point(81, 115);
            this.lbLocalizar.Name = "lbLocalizar";
            this.lbLocalizar.Size = new System.Drawing.Size(85, 13);
            this.lbLocalizar.TabIndex = 4;
            this.lbLocalizar.Text = "Digite o produto:";
            // 
            // tbLocalizar
            // 
            this.tbLocalizar.Location = new System.Drawing.Point(165, 111);
            this.tbLocalizar.Name = "tbLocalizar";
            this.tbLocalizar.Size = new System.Drawing.Size(100, 20);
            this.tbLocalizar.TabIndex = 1;
            // 
            // formCad_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 347);
            this.Controls.Add(this.tbLocalizar);
            this.Controls.Add(this.lbLocalizar);
            this.Controls.Add(this.gbCadProd);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btLocalizar);
            this.Name = "formCad_Produtos";
            this.Text = "Cad_Produtos";
            this.gbCadProd.ResumeLayout(false);
            this.gbCadProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFornecedores;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.GroupBox gbCadProd;
        private System.Windows.Forms.TextBox tbProduto;
        private System.Windows.Forms.ComboBox cbFornecedores;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lbLocalizar;
        private System.Windows.Forms.TextBox tbLocalizar;
    }
}