namespace Classes_Nome
{
    partial class FrmAlimento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formPrefeitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formLojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_ingredientes = new System.Windows.Forms.TextBox();
            this.txt_calorias = new System.Windows.Forms.TextBox();
            this.txt_valorcompra = new System.Windows.Forms.TextBox();
            this.txt_valor10 = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingredientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calorias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "valor de compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "valor com 10% de aumento:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(17, 63);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(388, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // txt_ingredientes
            // 
            this.txt_ingredientes.Location = new System.Drawing.Point(17, 115);
            this.txt_ingredientes.Name = "txt_ingredientes";
            this.txt_ingredientes.Size = new System.Drawing.Size(388, 20);
            this.txt_ingredientes.TabIndex = 9;
            // 
            // txt_calorias
            // 
            this.txt_calorias.Location = new System.Drawing.Point(17, 211);
            this.txt_calorias.Name = "txt_calorias";
            this.txt_calorias.Size = new System.Drawing.Size(388, 20);
            this.txt_calorias.TabIndex = 10;
            // 
            // txt_valorcompra
            // 
            this.txt_valorcompra.Location = new System.Drawing.Point(12, 288);
            this.txt_valorcompra.Name = "txt_valorcompra";
            this.txt_valorcompra.Size = new System.Drawing.Size(393, 20);
            this.txt_valorcompra.TabIndex = 11;
            // 
            // txt_valor10
            // 
            this.txt_valor10.Location = new System.Drawing.Point(17, 371);
            this.txt_valor10.Name = "txt_valor10";
            this.txt_valor10.Size = new System.Drawing.Size(388, 20);
            this.txt_valor10.TabIndex = 12;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(511, 47);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(284, 213);
            this.btn_cadastrar.TabIndex = 13;
            this.btn_cadastrar.Text = "Cadastrar:";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(511, 272);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(284, 213);
            this.btn_limpar.TabIndex = 14;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            // 
            // FrmAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(845, 503);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_valor10);
            this.Controls.Add(this.txt_valorcompra);
            this.Controls.Add(this.txt_calorias);
            this.Controls.Add(this.txt_ingredientes);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAlimento";
            this.Text = "Form3";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_ingredientes;
        private System.Windows.Forms.TextBox txt_calorias;
        private System.Windows.Forms.TextBox txt_valorcompra;
        private System.Windows.Forms.TextBox txt_valor10;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_limpar;
    }
}