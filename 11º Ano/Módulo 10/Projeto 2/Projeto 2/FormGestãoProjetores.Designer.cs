namespace Projeto_2
{
    partial class FormGestãoProjetores
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
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EleminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.labelFunciona = new System.Windows.Forms.Label();
            this.radioButtonFunciona = new System.Windows.Forms.RadioButton();
            this.radioButtonFuncionaNao = new System.Windows.Forms.RadioButton();
            this.ButtonOpção = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoToolStripMenuItem,
            this.AlterarToolStripMenuItem,
            this.EleminarToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // NovoToolStripMenuItem
            // 
            this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
            this.NovoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NovoToolStripMenuItem.Text = "Novo";
            this.NovoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // AlterarToolStripMenuItem
            // 
            this.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem";
            this.AlterarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AlterarToolStripMenuItem.Text = "Alterar";
            this.AlterarToolStripMenuItem.Click += new System.EventHandler(this.AlterarToolStripMenuItem_Click);
            // 
            // EleminarToolStripMenuItem
            // 
            this.EleminarToolStripMenuItem.Name = "EleminarToolStripMenuItem";
            this.EleminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EleminarToolStripMenuItem.Text = "Eleminar";
            this.EleminarToolStripMenuItem.Click += new System.EventHandler(this.EleminarToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 36);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Codigo";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(58, 33);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(234, 20);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(12, 69);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 3;
            this.labelMarca.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(55, 66);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(237, 20);
            this.textBoxMarca.TabIndex = 4;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(12, 100);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 5;
            this.labelModelo.Text = "Modelo";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(60, 97);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(232, 20);
            this.textBoxModelo.TabIndex = 6;
            // 
            // labelFunciona
            // 
            this.labelFunciona.AutoSize = true;
            this.labelFunciona.Location = new System.Drawing.Point(12, 135);
            this.labelFunciona.Name = "labelFunciona";
            this.labelFunciona.Size = new System.Drawing.Size(51, 13);
            this.labelFunciona.TabIndex = 7;
            this.labelFunciona.Text = "Funciona";
            // 
            // radioButtonFunciona
            // 
            this.radioButtonFunciona.AutoSize = true;
            this.radioButtonFunciona.Location = new System.Drawing.Point(69, 133);
            this.radioButtonFunciona.Name = "radioButtonFunciona";
            this.radioButtonFunciona.Size = new System.Drawing.Size(42, 17);
            this.radioButtonFunciona.TabIndex = 8;
            this.radioButtonFunciona.TabStop = true;
            this.radioButtonFunciona.Text = "Sim";
            this.radioButtonFunciona.UseVisualStyleBackColor = true;
            // 
            // radioButtonFuncionaNao
            // 
            this.radioButtonFuncionaNao.AutoSize = true;
            this.radioButtonFuncionaNao.Location = new System.Drawing.Point(117, 133);
            this.radioButtonFuncionaNao.Name = "radioButtonFuncionaNao";
            this.radioButtonFuncionaNao.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFuncionaNao.TabIndex = 9;
            this.radioButtonFuncionaNao.TabStop = true;
            this.radioButtonFuncionaNao.Text = "Não";
            this.radioButtonFuncionaNao.UseVisualStyleBackColor = true;
            // 
            // ButtonOpção
            // 
            this.ButtonOpção.Location = new System.Drawing.Point(15, 156);
            this.ButtonOpção.Name = "ButtonOpção";
            this.ButtonOpção.Size = new System.Drawing.Size(135, 23);
            this.ButtonOpção.TabIndex = 10;
            this.ButtonOpção.Text = "button1";
            this.ButtonOpção.UseVisualStyleBackColor = true;
            this.ButtonOpção.Click += new System.EventHandler(this.ButtonOpção_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(157, 156);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(135, 23);
            this.ButtonSair.TabIndex = 11;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // FormGestãoProjetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 186);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonOpção);
            this.Controls.Add(this.radioButtonFuncionaNao);
            this.Controls.Add(this.radioButtonFunciona);
            this.Controls.Add(this.labelFunciona);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestãoProjetores";
            this.Text = "Gestão Projetores";
            this.Load += new System.EventHandler(this.FormGestãoProjetores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EleminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Label labelFunciona;
        private System.Windows.Forms.RadioButton radioButtonFunciona;
        private System.Windows.Forms.RadioButton radioButtonFuncionaNao;
        private System.Windows.Forms.Button ButtonOpção;
        private System.Windows.Forms.Button ButtonSair;
    }
}