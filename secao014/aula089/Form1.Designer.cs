namespace aula089
{
    partial class formCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbCasa = new System.Windows.Forms.CheckBox();
            this.cbVeiculo = new System.Windows.Forms.CheckBox();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.rdOutro = new System.Windows.Forms.RadioButton();
            this.rdFeminino = new System.Windows.Forms.RadioButton();
            this.rdMasculino = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lsCadastrados = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadAlt = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.gboxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(309, 26);
            this.txtNome.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(14, 98);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(310, 26);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(14, 230);
            this.txtTelefone.Mask = "(00) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 26);
            this.txtTelefone.TabIndex = 7;
            // 
            // cbCasa
            // 
            this.cbCasa.AutoSize = true;
            this.cbCasa.Location = new System.Drawing.Point(14, 280);
            this.cbCasa.Name = "cbCasa";
            this.cbCasa.Size = new System.Drawing.Size(118, 17);
            this.cbCasa.TabIndex = 8;
            this.cbCasa.Text = "Possui casa própria";
            this.cbCasa.UseVisualStyleBackColor = true;
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.AutoSize = true;
            this.cbVeiculo.Location = new System.Drawing.Point(13, 304);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(96, 17);
            this.cbVeiculo.TabIndex = 9;
            this.cbVeiculo.Text = "Possui veículo";
            this.cbVeiculo.UseVisualStyleBackColor = true;
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rdOutro);
            this.gboxSexo.Controls.Add(this.rdFeminino);
            this.gboxSexo.Controls.Add(this.rdMasculino);
            this.gboxSexo.Location = new System.Drawing.Point(13, 347);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(201, 104);
            this.gboxSexo.TabIndex = 10;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rdOutro
            // 
            this.rdOutro.AutoSize = true;
            this.rdOutro.Location = new System.Drawing.Point(7, 68);
            this.rdOutro.Name = "rdOutro";
            this.rdOutro.Size = new System.Drawing.Size(51, 17);
            this.rdOutro.TabIndex = 2;
            this.rdOutro.TabStop = true;
            this.rdOutro.Text = "Outro";
            this.rdOutro.UseVisualStyleBackColor = true;
            // 
            // rdFeminino
            // 
            this.rdFeminino.AutoSize = true;
            this.rdFeminino.Location = new System.Drawing.Point(7, 44);
            this.rdFeminino.Name = "rdFeminino";
            this.rdFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdFeminino.TabIndex = 1;
            this.rdFeminino.TabStop = true;
            this.rdFeminino.Text = "Feminino";
            this.rdFeminino.UseVisualStyleBackColor = true;
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Location = new System.Drawing.Point(7, 20);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdMasculino.TabIndex = 0;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(186, 457);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(66, 47);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lsCadastrados
            // 
            this.lsCadastrados.FormattingEnabled = true;
            this.lsCadastrados.Location = new System.Drawing.Point(475, 32);
            this.lsCadastrados.Name = "lsCadastrados";
            this.lsCadastrados.Size = new System.Drawing.Size(353, 472);
            this.lsCadastrados.TabIndex = 12;
            this.lsCadastrados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsCadastrados_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(471, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cadastrados:";
            // 
            // btnCadAlt
            // 
            this.btnCadAlt.Location = new System.Drawing.Point(12, 457);
            this.btnCadAlt.Name = "btnCadAlt";
            this.btnCadAlt.Size = new System.Drawing.Size(106, 47);
            this.btnCadAlt.TabIndex = 14;
            this.btnCadAlt.Text = "Cadastrar / Alterar";
            this.btnCadAlt.UseVisualStyleBackColor = true;
            this.btnCadAlt.Click += new System.EventHandler(this.btnCadAlt_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(258, 457);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 47);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Location = new System.Drawing.Point(15, 165);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(199, 28);
            this.cbEstadoCivil.TabIndex = 16;
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadAlt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsCadastrados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gboxSexo);
            this.Controls.Add(this.cbVeiculo);
            this.Controls.Add(this.cbCasa);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.CheckBox cbCasa;
        private System.Windows.Forms.CheckBox cbVeiculo;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton rdFeminino;
        private System.Windows.Forms.RadioButton rdMasculino;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rdOutro;
        private System.Windows.Forms.ListBox lsCadastrados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadAlt;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
    }
}

