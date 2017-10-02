namespace Exercicio_9
{
    partial class Main
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
            this.btnNovoCarro = new System.Windows.Forms.Button();
            this.btnNovaMarca = new System.Windows.Forms.Button();
            this.btnEleminarCarro = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbProcuraCarro = new System.Windows.Forms.TextBox();
            this.lbProcura = new System.Windows.Forms.Label();
            this.numUDStock = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionaStock = new System.Windows.Forms.Button();
            this.btnAdicionaVendas = new System.Windows.Forms.Button();
            this.numUDVendas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoCarro
            // 
            this.btnNovoCarro.Location = new System.Drawing.Point(93, 12);
            this.btnNovoCarro.Name = "btnNovoCarro";
            this.btnNovoCarro.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCarro.TabIndex = 0;
            this.btnNovoCarro.Text = "Novo Carro";
            this.btnNovoCarro.UseVisualStyleBackColor = true;
            this.btnNovoCarro.Click += new System.EventHandler(this.btnNovoCarro_Click);
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Location = new System.Drawing.Point(12, 12);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(75, 23);
            this.btnNovaMarca.TabIndex = 1;
            this.btnNovaMarca.Text = "Nova Marca";
            this.btnNovaMarca.UseVisualStyleBackColor = true;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovaMarca_Click);
            // 
            // btnEleminarCarro
            // 
            this.btnEleminarCarro.Location = new System.Drawing.Point(174, 12);
            this.btnEleminarCarro.Name = "btnEleminarCarro";
            this.btnEleminarCarro.Size = new System.Drawing.Size(95, 23);
            this.btnEleminarCarro.TabIndex = 2;
            this.btnEleminarCarro.Text = "Eleminar Carro";
            this.btnEleminarCarro.UseVisualStyleBackColor = true;
            this.btnEleminarCarro.Click += new System.EventHandler(this.btnEleminarCarro_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(810, 418);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marca";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Modelo";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço (€)";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cor";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "0-100(s)";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Consumo (L/100Km)";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Extras";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Stock";
            this.columnHeader9.Width = 73;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Vendas";
            this.columnHeader10.Width = 86;
            // 
            // tbProcuraCarro
            // 
            this.tbProcuraCarro.Location = new System.Drawing.Point(353, 15);
            this.tbProcuraCarro.Name = "tbProcuraCarro";
            this.tbProcuraCarro.Size = new System.Drawing.Size(135, 20);
            this.tbProcuraCarro.TabIndex = 5;
            this.tbProcuraCarro.TextChanged += new System.EventHandler(this.tbProcuraCarro_TextChanged);
            // 
            // lbProcura
            // 
            this.lbProcura.AutoSize = true;
            this.lbProcura.Location = new System.Drawing.Point(275, 18);
            this.lbProcura.Name = "lbProcura";
            this.lbProcura.Size = new System.Drawing.Size(72, 13);
            this.lbProcura.TabIndex = 6;
            this.lbProcura.Text = "Procura Carro";
            // 
            // numUDStock
            // 
            this.numUDStock.Location = new System.Drawing.Point(617, 16);
            this.numUDStock.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUDStock.Name = "numUDStock";
            this.numUDStock.Size = new System.Drawing.Size(49, 20);
            this.numUDStock.TabIndex = 8;
            // 
            // btnAdicionaStock
            // 
            this.btnAdicionaStock.Location = new System.Drawing.Point(494, 13);
            this.btnAdicionaStock.Name = "btnAdicionaStock";
            this.btnAdicionaStock.Size = new System.Drawing.Size(117, 23);
            this.btnAdicionaStock.TabIndex = 9;
            this.btnAdicionaStock.Text = "Adicionar Stock";
            this.btnAdicionaStock.UseVisualStyleBackColor = true;
            this.btnAdicionaStock.Click += new System.EventHandler(this.btnAdicionaStock_Click);
            // 
            // btnAdicionaVendas
            // 
            this.btnAdicionaVendas.Location = new System.Drawing.Point(672, 13);
            this.btnAdicionaVendas.Name = "btnAdicionaVendas";
            this.btnAdicionaVendas.Size = new System.Drawing.Size(89, 23);
            this.btnAdicionaVendas.TabIndex = 10;
            this.btnAdicionaVendas.Text = "Venda";
            this.btnAdicionaVendas.UseVisualStyleBackColor = true;
            this.btnAdicionaVendas.Click += new System.EventHandler(this.btnAdicionaVendas_Click);
            // 
            // numUDVendas
            // 
            this.numUDVendas.Location = new System.Drawing.Point(767, 15);
            this.numUDVendas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUDVendas.Name = "numUDVendas";
            this.numUDVendas.Size = new System.Drawing.Size(55, 20);
            this.numUDVendas.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 471);
            this.Controls.Add(this.numUDVendas);
            this.Controls.Add(this.btnAdicionaVendas);
            this.Controls.Add(this.btnAdicionaStock);
            this.Controls.Add(this.numUDStock);
            this.Controls.Add(this.lbProcura);
            this.Controls.Add(this.tbProcuraCarro);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEleminarCarro);
            this.Controls.Add(this.btnNovaMarca);
            this.Controls.Add(this.btnNovoCarro);
            this.Name = "Main";
            this.Text = "OniCar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCarro;
        private System.Windows.Forms.Button btnNovaMarca;
        private System.Windows.Forms.Button btnEleminarCarro;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tbProcuraCarro;
        private System.Windows.Forms.Label lbProcura;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.NumericUpDown numUDStock;
        private System.Windows.Forms.Button btnAdicionaStock;
        private System.Windows.Forms.Button btnAdicionaVendas;
        private System.Windows.Forms.NumericUpDown numUDVendas;
    }
}

