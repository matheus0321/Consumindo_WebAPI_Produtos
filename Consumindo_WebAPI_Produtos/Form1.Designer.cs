namespace Consumindo_WebAPI_Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            this.btnObterProdutos = new System.Windows.Forms.Button();
            this.btnProdutosPorId = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnAtualizaProduto = new System.Windows.Forms.Button();
            this.btnDeletarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - Web API";
            // 
            // txtURI
            // 
            this.txtURI.Location = new System.Drawing.Point(107, 6);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(540, 20);
            this.txtURI.TabIndex = 1;
            // 
            // gdvDados
            // 
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(19, 29);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.Size = new System.Drawing.Size(579, 305);
            this.gdvDados.TabIndex = 2;
            // 
            // btnObterProdutos
            // 
            this.btnObterProdutos.Location = new System.Drawing.Point(19, 340);
            this.btnObterProdutos.Name = "btnObterProdutos";
            this.btnObterProdutos.Size = new System.Drawing.Size(108, 23);
            this.btnObterProdutos.TabIndex = 3;
            this.btnObterProdutos.Text = "Retomar Produto";
            this.btnObterProdutos.UseVisualStyleBackColor = true;
            this.btnObterProdutos.Click += new System.EventHandler(this.btnObterProdutos_Click);
            // 
            // btnProdutosPorId
            // 
            this.btnProdutosPorId.Location = new System.Drawing.Point(133, 340);
            this.btnProdutosPorId.Name = "btnProdutosPorId";
            this.btnProdutosPorId.Size = new System.Drawing.Size(119, 23);
            this.btnProdutosPorId.TabIndex = 4;
            this.btnProdutosPorId.Text = "Obter Produto por Id";
            this.btnProdutosPorId.UseVisualStyleBackColor = true;
            this.btnProdutosPorId.Click += new System.EventHandler(this.btnProdutosPorId_Click);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(258, 340);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(108, 23);
            this.btnIncluirProduto.TabIndex = 6;
            this.btnIncluirProduto.Text = "Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluirProduto_Click);
            // 
            // btnAtualizaProduto
            // 
            this.btnAtualizaProduto.Location = new System.Drawing.Point(376, 340);
            this.btnAtualizaProduto.Name = "btnAtualizaProduto";
            this.btnAtualizaProduto.Size = new System.Drawing.Size(108, 23);
            this.btnAtualizaProduto.TabIndex = 7;
            this.btnAtualizaProduto.Text = "Atualizar Produto";
            this.btnAtualizaProduto.UseVisualStyleBackColor = true;
            this.btnAtualizaProduto.Click += new System.EventHandler(this.btnAtualizaProduto_Click);
            // 
            // btnDeletarProduto
            // 
            this.btnDeletarProduto.Location = new System.Drawing.Point(490, 340);
            this.btnDeletarProduto.Name = "btnDeletarProduto";
            this.btnDeletarProduto.Size = new System.Drawing.Size(108, 23);
            this.btnDeletarProduto.TabIndex = 8;
            this.btnDeletarProduto.Text = "Deletar Produto";
            this.btnDeletarProduto.UseVisualStyleBackColor = true;
            this.btnDeletarProduto.Click += new System.EventHandler(this.btnDeletarProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(598, 371);
            this.Controls.Add(this.btnDeletarProduto);
            this.Controls.Add(this.btnAtualizaProduto);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.btnProdutosPorId);
            this.Controls.Add(this.btnObterProdutos);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consumindo Web Api";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.DataGridView gdvDados;
        private System.Windows.Forms.Button btnObterProdutos;
        private System.Windows.Forms.Button btnProdutosPorId;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnAtualizaProduto;
        private System.Windows.Forms.Button btnDeletarProduto;
    }
}

