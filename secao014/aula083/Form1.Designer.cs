namespace aula083
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsEmails = new System.Windows.Forms.ListBox();
            this.iptEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbQtdRestantes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(473, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(232, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lsEmails
            // 
            this.lsEmails.FormattingEnabled = true;
            this.lsEmails.Location = new System.Drawing.Point(327, 154);
            this.lsEmails.Name = "lsEmails";
            this.lsEmails.Size = new System.Drawing.Size(120, 95);
            this.lsEmails.TabIndex = 2;
            // 
            // iptEmail
            // 
            this.iptEmail.BackColor = System.Drawing.SystemColors.Desktop;
            this.iptEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iptEmail.Location = new System.Drawing.Point(276, 84);
            this.iptEmail.Name = "iptEmail";
            this.iptEmail.Size = new System.Drawing.Size(191, 20);
            this.iptEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(324, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "No máximo: 5 nomes";
            // 
            // lbQtdRestantes
            // 
            this.lbQtdRestantes.AutoSize = true;
            this.lbQtdRestantes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbQtdRestantes.Location = new System.Drawing.Point(434, 252);
            this.lbQtdRestantes.Name = "lbQtdRestantes";
            this.lbQtdRestantes.Size = new System.Drawing.Size(13, 13);
            this.lbQtdRestantes.TabIndex = 5;
            this.lbQtdRestantes.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(383, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Restam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbQtdRestantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iptEmail);
            this.Controls.Add(this.lsEmails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsEmails;
        private System.Windows.Forms.TextBox iptEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbQtdRestantes;
        private System.Windows.Forms.Label label4;
    }
}

