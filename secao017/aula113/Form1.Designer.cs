namespace aula113
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
            this.lsNomes = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.iptNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iptIndice = new System.Windows.Forms.TextBox();
            this.btnTemValor = new System.Windows.Forms.Button();
            this.btnQtdItens = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnAddEm = new System.Windows.Forms.Button();
            this.btnRemoverEm = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsNomes
            // 
            this.lsNomes.FormattingEnabled = true;
            this.lsNomes.Location = new System.Drawing.Point(12, 12);
            this.lsNomes.Name = "lsNomes";
            this.lsNomes.Size = new System.Drawing.Size(261, 420);
            this.lsNomes.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(279, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // iptNome
            // 
            this.iptNome.Location = new System.Drawing.Point(280, 28);
            this.iptNome.Name = "iptNome";
            this.iptNome.Size = new System.Drawing.Size(148, 20);
            this.iptNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Índice";
            // 
            // iptIndice
            // 
            this.iptIndice.Location = new System.Drawing.Point(280, 67);
            this.iptIndice.Name = "iptIndice";
            this.iptIndice.Size = new System.Drawing.Size(35, 20);
            this.iptIndice.TabIndex = 4;
            // 
            // btnTemValor
            // 
            this.btnTemValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemValor.Location = new System.Drawing.Point(279, 348);
            this.btnTemValor.Name = "btnTemValor";
            this.btnTemValor.Size = new System.Drawing.Size(149, 45);
            this.btnTemValor.TabIndex = 6;
            this.btnTemValor.Text = "Tem o valor?";
            this.btnTemValor.UseVisualStyleBackColor = true;
            this.btnTemValor.Click += new System.EventHandler(this.btnTemValor_Click);
            // 
            // btnQtdItens
            // 
            this.btnQtdItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQtdItens.Location = new System.Drawing.Point(279, 297);
            this.btnQtdItens.Name = "btnQtdItens";
            this.btnQtdItens.Size = new System.Drawing.Size(149, 45);
            this.btnQtdItens.TabIndex = 7;
            this.btnQtdItens.Text = "Quantos itens?";
            this.btnQtdItens.UseVisualStyleBackColor = true;
            this.btnQtdItens.Click += new System.EventHandler(this.btnQtdItens_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(279, 246);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(149, 45);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnAddEm
            // 
            this.btnAddEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEm.Location = new System.Drawing.Point(279, 144);
            this.btnAddEm.Name = "btnAddEm";
            this.btnAddEm.Size = new System.Drawing.Size(149, 45);
            this.btnAddEm.TabIndex = 9;
            this.btnAddEm.Text = "Add em...";
            this.btnAddEm.UseVisualStyleBackColor = true;
            this.btnAddEm.Click += new System.EventHandler(this.btnAddEm_Click);
            // 
            // btnRemoverEm
            // 
            this.btnRemoverEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverEm.Location = new System.Drawing.Point(279, 195);
            this.btnRemoverEm.Name = "btnRemoverEm";
            this.btnRemoverEm.Size = new System.Drawing.Size(149, 45);
            this.btnRemoverEm.TabIndex = 10;
            this.btnRemoverEm.Text = "Remover na...";
            this.btnRemoverEm.UseVisualStyleBackColor = true;
            this.btnRemoverEm.Click += new System.EventHandler(this.btnRemoverEm_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(279, 399);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 33);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(371, 65);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(0, 20);
            this.txtResult.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(360, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(68, 33);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemoverEm);
            this.Controls.Add(this.btnAddEm);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnQtdItens);
            this.Controls.Add(this.btnTemValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptIndice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iptNome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsNomes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox iptNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iptIndice;
        private System.Windows.Forms.Button btnTemValor;
        private System.Windows.Forms.Button btnQtdItens;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnAddEm;
        private System.Windows.Forms.Button btnRemoverEm;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button btnSair;
    }
}

