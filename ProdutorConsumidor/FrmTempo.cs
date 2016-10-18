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
    public partial class FrmTempo : Form
    {
        public FrmTempo(Func<decimal,decimal> func)
        {
            InitializeComponent();
            _func = func;
            BtRestart.Click += BtRestart_Click;
            BtStop.Click += BtStop_Click;
        }

        //para o contador
        private void BtStop_Click(object sender, EventArgs e)
        {
            Hide();
        }

        //reinicia o contador
        private void BtRestart_Click(object sender, EventArgs e)
        {
            decimal retorno = 0;
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                retorno = decimal.Parse(textBox1.Text);
            _func.Invoke(retorno);
        }

        private Func<decimal, decimal> _func = null;


    }
}
