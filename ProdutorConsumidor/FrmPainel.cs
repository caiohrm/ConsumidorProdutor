using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutorConsumidor
{
    public partial class FrmPainel : Form
    {
        public FrmPainel()
        {
            InitializeComponent();
            TxQtConsumidor.KeyPress += Item_KeyPress;
            TxQtProdutor.KeyPress += Item_KeyPress;
            TxQtFila.KeyPress += Item_KeyPress;
            TxTpConsumidor.KeyPress += TxTpConsumidor_KeyPress;
            TxTpProdutor.KeyPress += TxTpConsumidor_KeyPress;
            BtIniciar.Click += BtIniciar_Click;
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {
            if(ValidaCampos(groupBox1.Controls) &&
            ValidaCampos(groupBox2.Controls) && ValidaCampos(groupBox3.Controls))
            {
                int qteprodutor = int.Parse(TxQtProdutor.Text);
                int qteConsumidor = int.Parse(TxQtConsumidor.Text);
                int tempoProdutor = int.Parse(TxTpProdutor.Text);
                int tempoConsumidor = int.Parse(TxTpConsumidor.Text);
                int fila = int.Parse(TxQtFila.Text);
                if(UsrControle != null)
                    UsrControle.Dispose();
                UsrControle = new UsrControle(qteprodutor, tempoProdutor,CkProdAleatorio.Checked ,qteConsumidor, tempoConsumidor,CkConsAleatorio.Checked ,fila);
                UsrControle.Dock = DockStyle.Fill;
                PlControle.Controls.Clear();
                PlControle.Controls.Add(UsrControle);
            }
        }
        
        private UserControl UsrControle { get; set; }
        
        /// <summary>
        /// Verifica se campo está vazio
        /// </summary>
        /// <param name="controls"></param>
        private bool ValidaCampos(Control.ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                TextBox text = item as TextBox;
                if (text != null && string.IsNullOrWhiteSpace(text.Text))
                {
                    MessageBox.Show($"{text.Tag} não pode ser vazio");
                    text.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida campo de tempo permitindo numeros decimais e inteiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxTpConsumidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidaNumeros(10, 2, sender as TextBox, e);
        }


        /// <summary>
        /// Valida campo de quantidade permitindo apenas numeros inteiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            ValidaNumeros(10, 0, sender as TextBox, e);
        }


        /// <summary>
        /// Valida campo de quantidade permitindo apenas numeros inteiros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidaNumeros(int _maxprecisao, int _maxdecimais,TextBox TxEditor, KeyPressEventArgs e)
        {
            int pos;
            string texto = TxEditor.Text;
            bool hassepar = ((pos = texto.IndexOf(',')) > -1);
            pos = (pos == -1 ? texto.Length : pos);
            bool allselec = (texto.Length > 0 && TxEditor.SelectedText.Length == texto.Length);
            e.KeyChar = (e.KeyChar == '.' ? e.KeyChar = ',' : e.KeyChar);
            if (!hassepar && char.IsDigit(e.KeyChar) && !allselec && TxEditor.SelectionStart > 0 && TxEditor.SelectionStart <= pos && _maxprecisao <= pos)
                e.Handled = true;
            else
                if (hassepar && char.IsDigit(e.KeyChar) && !allselec && TxEditor.SelectionStart > 0 && TxEditor.SelectionStart <= pos && _maxprecisao <= pos)
                e.Handled = true;
            else
                    if (hassepar && char.IsDigit(e.KeyChar) && !allselec && TxEditor.SelectionStart > 0 && TxEditor.SelectionStart > pos && _maxdecimais <= (texto.Length - pos - 1))
                e.Handled = true;
            if ((!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8)) && (!allselec) && (hassepar || e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
