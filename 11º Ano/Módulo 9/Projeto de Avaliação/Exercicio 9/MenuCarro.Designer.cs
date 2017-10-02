namespace Exercicio_9
{
    partial class MenuCarro
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
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbPreco = new System.Windows.Forms.TextBox();
            this.tbCor = new System.Windows.Forms.TextBox();
            this.tbZeroCem = new System.Windows.Forms.TextBox();
            this.tbConsumo = new System.Windows.Forms.TextBox();
            this.tbExtras = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbVendas = new System.Windows.Forms.TextBox();
            this.cbMarcas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(122, 39);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(121, 20);
            this.tbModelo.TabIndex = 0;
            // 
            // tbPreco
            // 
            this.tbPreco.Location = new System.Drawing.Point(122, 65);
            this.tbPreco.Name = "tbPreco";
            this.tbPreco.Size = new System.Drawing.Size(121, 20);
            this.tbPreco.TabIndex = 1;
            this.tbPreco.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            // 
            // tbCor
            // 
            this.tbCor.Location = new System.Drawing.Point(122, 91);
            this.tbCor.Name = "tbCor";
            this.tbCor.Size = new System.Drawing.Size(121, 20);
            this.tbCor.TabIndex = 2;
            // 
            // tbZeroCem
            // 
            this.tbZeroCem.Location = new System.Drawing.Point(122, 117);
            this.tbZeroCem.Name = "tbZeroCem";
            this.tbZeroCem.Size = new System.Drawing.Size(121, 20);
            this.tbZeroCem.TabIndex = 3;
            this.tbZeroCem.TextChanged += new System.EventHandler(this.tbZeroCem_TextChanged);
            // 
            // tbConsumo
            // 
            this.tbConsumo.Location = new System.Drawing.Point(122, 143);
            this.tbConsumo.Name = "tbConsumo";
            this.tbConsumo.Size = new System.Drawing.Size(121, 20);
            this.tbConsumo.TabIndex = 4;
            this.tbConsumo.TextChanged += new System.EventHandler(this.tbConsumo_TextChanged);
            // 
            // tbExtras
            // 
            this.tbExtras.Location = new System.Drawing.Point(122, 172);
            this.tbExtras.Name = "tbExtras";
            this.tbExtras.Size = new System.Drawing.Size(121, 20);
            this.tbExtras.TabIndex = 5;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(122, 198);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(121, 20);
            this.tbStock.TabIndex = 6;
            this.tbStock.TextChanged += new System.EventHandler(this.tbStock_TextChanged);
            // 
            // tbVendas
            // 
            this.tbVendas.Location = new System.Drawing.Point(122, 224);
            this.tbVendas.Name = "tbVendas";
            this.tbVendas.Size = new System.Drawing.Size(121, 20);
            this.tbVendas.TabIndex = 7;
            this.tbVendas.TextChanged += new System.EventHandler(this.tbVendas_TextChanged);
            // 
            // cbMarcas
            // 
            this.cbMarcas.FormattingEnabled = true;
            this.cbMarcas.Location = new System.Drawing.Point(122, 12);
            this.cbMarcas.Name = "cbMarcas";
            this.cbMarcas.Size = new System.Drawing.Size(121, 21);
            this.cbMarcas.TabIndex = 8;
            this.cbMarcas.SelectedIndexChanged += new System.EventHandler(this.cbMarcas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tempo 0-100Km/h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Consumo (L/100Km)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Extras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Vendas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarcas);
            this.Controls.Add(this.tbVendas);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbExtras);
            this.Controls.Add(this.tbConsumo);
            this.Controls.Add(this.tbZeroCem);
            this.Controls.Add(this.tbCor);
            this.Controls.Add(this.tbPreco);
            this.Controls.Add(this.tbModelo);
            this.Name = "MenuCarro";
            this.Text = "MenuCarro";
            this.Load += new System.EventHandler(this.MenuCarro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbModelo;
        public System.Windows.Forms.TextBox tbPreco;
        public System.Windows.Forms.TextBox tbCor;
        public System.Windows.Forms.TextBox tbZeroCem;
        public System.Windows.Forms.TextBox tbConsumo;
        public System.Windows.Forms.TextBox tbExtras;
        public System.Windows.Forms.TextBox tbStock;
        public System.Windows.Forms.TextBox tbVendas;
        public System.Windows.Forms.ComboBox cbMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}