namespace Projeto_2
{
    partial class FormgestãoRequisições
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
            this.comboBoxNúmeroProfessor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCódigoProjetor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDataRequisição = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDuraçãoRequisição = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonEntregue = new System.Windows.Forms.RadioButton();
            this.radioButtonEntregueNão = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EleminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonOpção = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuraçãoRequisição)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNúmeroProfessor
            // 
            this.comboBoxNúmeroProfessor.FormattingEnabled = true;
            this.comboBoxNúmeroProfessor.Location = new System.Drawing.Point(126, 36);
            this.comboBoxNúmeroProfessor.Name = "comboBoxNúmeroProfessor";
            this.comboBoxNúmeroProfessor.Size = new System.Drawing.Size(146, 21);
            this.comboBoxNúmeroProfessor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Do Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Projetor";
            // 
            // comboBoxCódigoProjetor
            // 
            this.comboBoxCódigoProjetor.FormattingEnabled = true;
            this.comboBoxCódigoProjetor.Location = new System.Drawing.Point(97, 74);
            this.comboBoxCódigoProjetor.Name = "comboBoxCódigoProjetor";
            this.comboBoxCódigoProjetor.Size = new System.Drawing.Size(175, 21);
            this.comboBoxCódigoProjetor.TabIndex = 3;
            // 
            // dateTimePickerDataRequisição
            // 
            this.dateTimePickerDataRequisição.Location = new System.Drawing.Point(121, 112);
            this.dateTimePickerDataRequisição.Name = "dateTimePickerDataRequisição";
            this.dateTimePickerDataRequisição.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDataRequisição.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Da Requisição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duração Da Requisição";
            // 
            // numericUpDownDuraçãoRequisição
            // 
            this.numericUpDownDuraçãoRequisição.Location = new System.Drawing.Point(139, 150);
            this.numericUpDownDuraçãoRequisição.Name = "numericUpDownDuraçãoRequisição";
            this.numericUpDownDuraçãoRequisição.Size = new System.Drawing.Size(133, 20);
            this.numericUpDownDuraçãoRequisição.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Já Foi Entregue?";
            // 
            // radioButtonEntregue
            // 
            this.radioButtonEntregue.AutoSize = true;
            this.radioButtonEntregue.Location = new System.Drawing.Point(121, 181);
            this.radioButtonEntregue.Name = "radioButtonEntregue";
            this.radioButtonEntregue.Size = new System.Drawing.Size(42, 17);
            this.radioButtonEntregue.TabIndex = 9;
            this.radioButtonEntregue.TabStop = true;
            this.radioButtonEntregue.Text = "Sim";
            this.radioButtonEntregue.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntregueNão
            // 
            this.radioButtonEntregueNão.AutoSize = true;
            this.radioButtonEntregueNão.Location = new System.Drawing.Point(194, 181);
            this.radioButtonEntregueNão.Name = "radioButtonEntregueNão";
            this.radioButtonEntregueNão.Size = new System.Drawing.Size(45, 17);
            this.radioButtonEntregueNão.TabIndex = 10;
            this.radioButtonEntregueNão.TabStop = true;
            this.radioButtonEntregueNão.Text = "Não";
            this.radioButtonEntregueNão.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data Entrega";
            // 
            // dateTimePickerDataEntrega
            // 
            this.dateTimePickerDataEntrega.Location = new System.Drawing.Point(91, 211);
            this.dateTimePickerDataEntrega.Name = "dateTimePickerDataEntrega";
            this.dateTimePickerDataEntrega.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerDataEntrega.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 13;
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
            // ButtonOpção
            // 
            this.ButtonOpção.Location = new System.Drawing.Point(15, 241);
            this.ButtonOpção.Name = "ButtonOpção";
            this.ButtonOpção.Size = new System.Drawing.Size(125, 23);
            this.ButtonOpção.TabIndex = 14;
            this.ButtonOpção.Text = "button1";
            this.ButtonOpção.UseVisualStyleBackColor = true;
            this.ButtonOpção.Click += new System.EventHandler(this.ButtonOpção_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.Location = new System.Drawing.Point(147, 241);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(125, 23);
            this.ButtonSair.TabIndex = 15;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.UseVisualStyleBackColor = true;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // FormgestãoRequisições
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonOpção);
            this.Controls.Add(this.dateTimePickerDataEntrega);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonEntregueNão);
            this.Controls.Add(this.radioButtonEntregue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownDuraçãoRequisição);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDataRequisição);
            this.Controls.Add(this.comboBoxCódigoProjetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNúmeroProfessor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormgestãoRequisições";
            this.Text = "FormgestãoRequisições";
            this.Load += new System.EventHandler(this.FormgestãoRequisições_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuraçãoRequisição)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNúmeroProfessor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCódigoProjetor;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRequisição;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDuraçãoRequisição;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonEntregue;
        private System.Windows.Forms.RadioButton radioButtonEntregueNão;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataEntrega;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EleminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.Button ButtonOpção;
        private System.Windows.Forms.Button ButtonSair;
    }
}