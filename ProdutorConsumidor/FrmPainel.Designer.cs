namespace ProdutorConsumidor
{
    partial class FrmPainel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtIniciar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxQtFila = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxQtConsumidor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxTpConsumidor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxQtProdutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxTpProdutor = new System.Windows.Forms.TextBox();
            this.PlControle = new System.Windows.Forms.Panel();
            this.CkProdAleatorio = new System.Windows.Forms.CheckBox();
            this.CkConsAleatorio = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtIniciar);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 622);
            this.panel1.TabIndex = 0;
            // 
            // BtIniciar
            // 
            this.BtIniciar.Location = new System.Drawing.Point(49, 417);
            this.BtIniciar.Name = "BtIniciar";
            this.BtIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtIniciar.TabIndex = 11;
            this.BtIniciar.Text = "Iniciar";
            this.BtIniciar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxQtFila);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(31, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 73);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fila";
            // 
            // TxQtFila
            // 
            this.TxQtFila.Location = new System.Drawing.Point(18, 43);
            this.TxQtFila.Name = "TxQtFila";
            this.TxQtFila.Size = new System.Drawing.Size(100, 20);
            this.TxQtFila.TabIndex = 0;
            this.TxQtFila.Tag = "Quantidade de item na fila";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quantidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CkConsAleatorio);
            this.groupBox2.Controls.Add(this.TxQtConsumidor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxTpConsumidor);
            this.groupBox2.Location = new System.Drawing.Point(31, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 145);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consumidor";
            // 
            // TxQtConsumidor
            // 
            this.TxQtConsumidor.Location = new System.Drawing.Point(18, 43);
            this.TxQtConsumidor.Name = "TxQtConsumidor";
            this.TxQtConsumidor.Size = new System.Drawing.Size(100, 20);
            this.TxQtConsumidor.TabIndex = 0;
            this.TxQtConsumidor.Tag = "Quantidade de consumidores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantidade";
            // 
            // TxTpConsumidor
            // 
            this.TxTpConsumidor.Location = new System.Drawing.Point(18, 97);
            this.TxTpConsumidor.Name = "TxTpConsumidor";
            this.TxTpConsumidor.Size = new System.Drawing.Size(100, 20);
            this.TxTpConsumidor.TabIndex = 2;
            this.TxTpConsumidor.Tag = "Tempo de consumo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkProdAleatorio);
            this.groupBox1.Controls.Add(this.TxQtProdutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxTpProdutor);
            this.groupBox1.Location = new System.Drawing.Point(31, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtor";
            // 
            // TxQtProdutor
            // 
            this.TxQtProdutor.Location = new System.Drawing.Point(18, 43);
            this.TxQtProdutor.Name = "TxQtProdutor";
            this.TxQtProdutor.Size = new System.Drawing.Size(100, 20);
            this.TxQtProdutor.TabIndex = 0;
            this.TxQtProdutor.Tag = "Quantidade produtores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade";
            // 
            // TxTpProdutor
            // 
            this.TxTpProdutor.Location = new System.Drawing.Point(18, 97);
            this.TxTpProdutor.Name = "TxTpProdutor";
            this.TxTpProdutor.Size = new System.Drawing.Size(100, 20);
            this.TxTpProdutor.TabIndex = 2;
            this.TxTpProdutor.Tag = "Tempo de produção";
            // 
            // PlControle
            // 
            this.PlControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlControle.Location = new System.Drawing.Point(200, 0);
            this.PlControle.Name = "PlControle";
            this.PlControle.Size = new System.Drawing.Size(982, 622);
            this.PlControle.TabIndex = 1;
            // 
            // CkProdAleatorio
            // 
            this.CkProdAleatorio.AutoSize = true;
            this.CkProdAleatorio.Location = new System.Drawing.Point(18, 123);
            this.CkProdAleatorio.Name = "CkProdAleatorio";
            this.CkProdAleatorio.Size = new System.Drawing.Size(67, 17);
            this.CkProdAleatorio.TabIndex = 4;
            this.CkProdAleatorio.Text = "Aleatorio";
            this.CkProdAleatorio.UseVisualStyleBackColor = true;
            // 
            // CkConsAleatorio
            // 
            this.CkConsAleatorio.AutoSize = true;
            this.CkConsAleatorio.Location = new System.Drawing.Point(18, 122);
            this.CkConsAleatorio.Name = "CkConsAleatorio";
            this.CkConsAleatorio.Size = new System.Drawing.Size(67, 17);
            this.CkConsAleatorio.TabIndex = 5;
            this.CkConsAleatorio.Text = "Aleatorio";
            this.CkConsAleatorio.UseVisualStyleBackColor = true;
            // 
            // FrmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 622);
            this.Controls.Add(this.PlControle);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPainel";
            this.Text = "Painel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtIniciar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxQtFila;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxQtConsumidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxTpConsumidor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxQtProdutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxTpProdutor;
        private System.Windows.Forms.Panel PlControle;
        private System.Windows.Forms.CheckBox CkConsAleatorio;
        private System.Windows.Forms.CheckBox CkProdAleatorio;
    }
}

