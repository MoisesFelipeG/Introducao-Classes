namespace Classes_Nome
{
    partial class FrmPrefeito
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPrefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_datanascimento = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_ruaav = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_LIMPAR = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formPrefeitoToolStripMenuItem,
            this.formLojaToolStripMenuItem,
            this.formAlimentoToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // formPrefeitoToolStripMenuItem
            // 
            this.formPrefeitoToolStripMenuItem.Name = "formPrefeitoToolStripMenuItem";
            this.formPrefeitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formPrefeitoToolStripMenuItem.Text = "Form Prefeito";
            this.formPrefeitoToolStripMenuItem.Click += new System.EventHandler(this.formPrefeitoToolStripMenuItem_Click);
            // 
            // formLojaToolStripMenuItem
            // 
            this.formLojaToolStripMenuItem.Name = "formLojaToolStripMenuItem";
            this.formLojaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formLojaToolStripMenuItem.Text = "Form Loja";
            this.formLojaToolStripMenuItem.Click += new System.EventHandler(this.formLojaToolStripMenuItem_Click);
            // 
            // formAlimentoToolStripMenuItem
            // 
            this.formAlimentoToolStripMenuItem.Name = "formAlimentoToolStripMenuItem";
            this.formAlimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAlimentoToolStripMenuItem.Text = "Form Alimento";
            this.formAlimentoToolStripMenuItem.Click += new System.EventHandler(this.formAlimentoToolStripMenuItem_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(13, 41);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 1;
            this.lbl_nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rua/AV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Complemento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cidade:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "País";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(57, 38);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(385, 20);
            this.txt_nome.TabIndex = 12;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(57, 79);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(385, 20);
            this.txt_cpf.TabIndex = 13;
            // 
            // txt_datanascimento
            // 
            this.txt_datanascimento.Location = new System.Drawing.Point(114, 116);
            this.txt_datanascimento.Name = "txt_datanascimento";
            this.txt_datanascimento.Size = new System.Drawing.Size(385, 20);
            this.txt_datanascimento.TabIndex = 14;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(57, 155);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(385, 20);
            this.txt_cep.TabIndex = 15;
            // 
            // txt_ruaav
            // 
            this.txt_ruaav.Location = new System.Drawing.Point(82, 196);
            this.txt_ruaav.Name = "txt_ruaav";
            this.txt_ruaav.Size = new System.Drawing.Size(385, 20);
            this.txt_ruaav.TabIndex = 16;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(82, 238);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(385, 20);
            this.txt_numero.TabIndex = 17;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(96, 274);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(385, 20);
            this.txt_complemento.TabIndex = 18;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(59, 309);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(385, 20);
            this.txt_bairro.TabIndex = 19;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(65, 341);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(385, 20);
            this.txt_cidade.TabIndex = 20;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(65, 376);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(385, 20);
            this.txt_estado.TabIndex = 21;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(53, 409);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(385, 20);
            this.txt_pais.TabIndex = 22;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(553, 27);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(235, 211);
            this.btn_cadastrar.TabIndex = 23;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_LIMPAR
            // 
            this.btn_LIMPAR.Location = new System.Drawing.Point(553, 258);
            this.btn_LIMPAR.Name = "btn_LIMPAR";
            this.btn_LIMPAR.Size = new System.Drawing.Size(235, 211);
            this.btn_LIMPAR.TabIndex = 24;
            this.btn_LIMPAR.Text = "Limpar";
            this.btn_LIMPAR.UseVisualStyleBackColor = true;
            // 
            // FrmPrefeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btn_LIMPAR);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_ruaav);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_datanascimento);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrefeito";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formPrefeitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formLojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAlimentoToolStripMenuItem;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_datanascimento;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_ruaav;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_LIMPAR;
    }
}

