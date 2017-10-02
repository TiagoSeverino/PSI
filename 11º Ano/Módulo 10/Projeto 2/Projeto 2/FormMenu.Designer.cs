namespace Projeto_2
{
    partial class FormMenu
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
            this.AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjetoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequisiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProjetoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RequisiçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewConsultas = new System.Windows.Forms.ListView();
            this.NovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.gestãoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoToolStripMenuItem,
            this.AbrirToolStripMenuItem,
            this.GuardarToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // AbrirToolStripMenuItem
            // 
            this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
            this.AbrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AbrirToolStripMenuItem.Text = "Abrir";
            this.AbrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.GuardarToolStripMenuItem.Text = "Guardar";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // gestãoToolStripMenuItem
            // 
            this.gestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfessoresToolStripMenuItem,
            this.ProjetoresToolStripMenuItem,
            this.RequisiçõesToolStripMenuItem});
            this.gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            this.gestãoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // ProfessoresToolStripMenuItem
            // 
            this.ProfessoresToolStripMenuItem.Name = "ProfessoresToolStripMenuItem";
            this.ProfessoresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ProfessoresToolStripMenuItem.Text = "Professores";
            this.ProfessoresToolStripMenuItem.Click += new System.EventHandler(this.ProfessoresToolStripMenuItem_Click);
            // 
            // ProjetoresToolStripMenuItem
            // 
            this.ProjetoresToolStripMenuItem.Name = "ProjetoresToolStripMenuItem";
            this.ProjetoresToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ProjetoresToolStripMenuItem.Text = "Projetores";
            this.ProjetoresToolStripMenuItem.Click += new System.EventHandler(this.ProjetoresToolStripMenuItem_Click);
            // 
            // RequisiçõesToolStripMenuItem
            // 
            this.RequisiçõesToolStripMenuItem.Name = "RequisiçõesToolStripMenuItem";
            this.RequisiçõesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.RequisiçõesToolStripMenuItem.Text = "Requisições";
            this.RequisiçõesToolStripMenuItem.Click += new System.EventHandler(this.RequisiçõesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfessoresToolStripMenuItem1,
            this.ProjetoresToolStripMenuItem1,
            this.RequisiçõesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ProfessoresToolStripMenuItem1
            // 
            this.ProfessoresToolStripMenuItem1.Name = "ProfessoresToolStripMenuItem1";
            this.ProfessoresToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ProfessoresToolStripMenuItem1.Text = "Professores";
            this.ProfessoresToolStripMenuItem1.Click += new System.EventHandler(this.ProfessoresToolStripMenuItem1_Click);
            // 
            // ProjetoresToolStripMenuItem1
            // 
            this.ProjetoresToolStripMenuItem1.Name = "ProjetoresToolStripMenuItem1";
            this.ProjetoresToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ProjetoresToolStripMenuItem1.Text = "Projetores";
            this.ProjetoresToolStripMenuItem1.Click += new System.EventHandler(this.ProjetoresToolStripMenuItem1_Click);
            // 
            // RequisiçõesToolStripMenuItem1
            // 
            this.RequisiçõesToolStripMenuItem1.Name = "RequisiçõesToolStripMenuItem1";
            this.RequisiçõesToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.RequisiçõesToolStripMenuItem1.Text = "Requisições";
            this.RequisiçõesToolStripMenuItem1.Click += new System.EventHandler(this.RequisiçõesToolStripMenuItem1_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // listViewConsultas
            // 
            this.listViewConsultas.Location = new System.Drawing.Point(12, 27);
            this.listViewConsultas.Name = "listViewConsultas";
            this.listViewConsultas.Size = new System.Drawing.Size(600, 340);
            this.listViewConsultas.TabIndex = 1;
            this.listViewConsultas.UseCompatibleStateImageBehavior = false;
            this.listViewConsultas.View = System.Windows.Forms.View.Details;
            // 
            // NovoToolStripMenuItem
            // 
            this.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem";
            this.NovoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NovoToolStripMenuItem.Text = "Novo";
            this.NovoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 386);
            this.Controls.Add(this.listViewConsultas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjetoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RequisiçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProjetoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RequisiçõesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ListView listViewConsultas;
        private System.Windows.Forms.ToolStripMenuItem NovoToolStripMenuItem;
    }
}

