namespace MercanetCurrency
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
            this.Novo = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.Label();
            this.abreviatura = new System.Windows.Forms.Label();
            this.cotacao = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_abreviatura = new System.Windows.Forms.TextBox();
            this.txt_cotacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(13, 13);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(75, 23);
            this.Novo.TabIndex = 0;
            this.Novo.Text = "NOVO";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(118, 13);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 1;
            this.Salvar.Text = "SALVAR";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(218, 13);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 2;
            this.Excluir.Text = "EXCLUIR";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(13, 94);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 3;
            this.Codigo.Text = "Código";
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(13, 145);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 4;
            this.descricao.Text = "Descrição";
            // 
            // abreviatura
            // 
            this.abreviatura.AutoSize = true;
            this.abreviatura.Location = new System.Drawing.Point(13, 197);
            this.abreviatura.Name = "abreviatura";
            this.abreviatura.Size = new System.Drawing.Size(61, 13);
            this.abreviatura.TabIndex = 5;
            this.abreviatura.Text = "Abreviatura";
            // 
            // cotacao
            // 
            this.cotacao.AutoSize = true;
            this.cotacao.Location = new System.Drawing.Point(13, 250);
            this.cotacao.Name = "cotacao";
            this.cotacao.Size = new System.Drawing.Size(47, 13);
            this.cotacao.TabIndex = 6;
            this.cotacao.Text = "Cotação";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(118, 91);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 7;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(118, 137);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(175, 20);
            this.txt_descricao.TabIndex = 8;
            // 
            // txt_abreviatura
            // 
            this.txt_abreviatura.Location = new System.Drawing.Point(118, 189);
            this.txt_abreviatura.Name = "txt_abreviatura";
            this.txt_abreviatura.Size = new System.Drawing.Size(100, 20);
            this.txt_abreviatura.TabIndex = 9;
            // 
            // txt_cotacao
            // 
            this.txt_cotacao.Location = new System.Drawing.Point(118, 242);
            this.txt_cotacao.Name = "txt_cotacao";
            this.txt_cotacao.Size = new System.Drawing.Size(100, 20);
            this.txt_cotacao.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_cotacao);
            this.Controls.Add(this.txt_abreviatura);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.cotacao);
            this.Controls.Add(this.abreviatura);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Novo);
            this.Name = "Form1";
            this.Text = "Cadastro de moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label abreviatura;
        private System.Windows.Forms.Label cotacao;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_abreviatura;
        private System.Windows.Forms.TextBox txt_cotacao;
    }
}

