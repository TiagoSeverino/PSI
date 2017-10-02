namespace Projeto_2
{
    partial class FormGestãoProfessores
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
            this.NovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EleminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGrupoDisciplinar = new System.Windows.Forms.TextBox();
            this.BtnOpção = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
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
            // NovoToolStripMenuItem
            // 
            this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
            this.NovoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.NovoToolStripMenuItem.Text = "Novo";
            this.NovoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // AlterarToolStripMenuItem
            // 
            this.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem";
            this.AlterarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.AlterarToolStripMenuItem.Text = "Alterar";
            this.AlterarToolStripMenuItem.Click += new System.EventHandler(this.AlterarToolStripMenuItem_Click);
            // 
            // EleminarToolStripMenuItem
            // 
            this.EleminarToolStripMenuItem.Name = "EleminarToolStripMenuItem";
            this.EleminarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.EleminarToolStripMenuItem.Text = "Eleminar";
            this.EleminarToolStripMenuItem.Click += new System.EventHandler(this.EleminarToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(68, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(224, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 45);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contacto";
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(68, 77);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.Size = new System.Drawing.Size(224, 20);
            this.textBoxContacto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GrupoDisciplinar";
            // 
            // textBoxGrupoDisciplinar
            // 
            this.textBoxGrupoDisciplinar.Location = new System.Drawing.Point(102, 113);
            this.textBoxGrupoDisciplinar.Name = "textBoxGrupoDisciplinar";
            this.textBoxGrupoDisciplinar.Size = new System.Drawing.Size(190, 20);
            this.textBoxGrupoDisciplinar.TabIndex = 6;
            // 
            // BtnOpção
            // 
            this.BtnOpção.Location = new System.Drawing.Point(12, 148);
            this.BtnOpção.Name = "BtnOpção";
            this.BtnOpção.Size = new System.Drawing.Size(145, 23);
            this.BtnOpção.TabIndex = 7;
            this.BtnOpção.Text = "button1";
            this.BtnOpção.UseVisualStyleBackColor = true;
            this.BtnOpção.Click += new System.EventHandler(this.BtnOpção_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(157, 148);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(145, 23);
            this.BtnSair.TabIndex = 8;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FormGestãoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 181);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnOpção);
            this.Controls.Add(this.textBoxGrupoDisciplinar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestãoProfessores";
            this.Text = "Gestão Professores";
            this.Load += new System.EventHandler(this.FormGestãoProfessores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EleminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGrupoDisciplinar;
        private System.Windows.Forms.Button BtnOpção;
        private System.Windows.Forms.Button BtnSair;
    }
}