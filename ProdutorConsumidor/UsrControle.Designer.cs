namespace ProdutorConsumidor
{
    partial class UsrControle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlProdutor = new System.Windows.Forms.Panel();
            this.PlConsumidor = new System.Windows.Forms.Panel();
            this.PlFila = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PlProdutor
            // 
            this.PlProdutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlProdutor.Location = new System.Drawing.Point(0, 0);
            this.PlProdutor.Name = "PlProdutor";
            this.PlProdutor.Size = new System.Drawing.Size(237, 54);
            this.PlProdutor.TabIndex = 0;
            // 
            // PlConsumidor
            // 
            this.PlConsumidor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlConsumidor.Location = new System.Drawing.Point(0, 84);
            this.PlConsumidor.Name = "PlConsumidor";
            this.PlConsumidor.Size = new System.Drawing.Size(237, 66);
            this.PlConsumidor.TabIndex = 1;
            // 
            // PlFila
            // 
            this.PlFila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlFila.Location = new System.Drawing.Point(0, 54);
            this.PlFila.Name = "PlFila";
            this.PlFila.Size = new System.Drawing.Size(237, 30);
            this.PlFila.TabIndex = 2;
            // 
            // UsrControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlFila);
            this.Controls.Add(this.PlConsumidor);
            this.Controls.Add(this.PlProdutor);
            this.Name = "UsrControle";
            this.Size = new System.Drawing.Size(237, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlProdutor;
        private System.Windows.Forms.Panel PlConsumidor;
        private System.Windows.Forms.Panel PlFila;
    }
}
