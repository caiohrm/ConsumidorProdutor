using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutorConsumidor
{
    public partial class Pessoa : UserControl
    {
        private  decimal _tempo;
        private int _tempoExecutado = 0;

        public Pessoa(decimal tempo)
        {
            InitializeComponent();
            this.DoubleClick += Pessoa_DoubleClick;
            label1.DoubleClick += Pessoa_DoubleClick;
            _tempo = tempo;
            timer = new Timer();
            timer.Tick += _timer_Tick;
            timer.Start();
        }

        public delegate void EventoPilha(Pessoa pessoa);

        public event EventoPilha ExecutaPilha;

        /// <summary>
        /// Abre o controle do tempo para reiniciar ou parar o tempo de execução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pessoa_DoubleClick(object sender, EventArgs e)
        {
            timer.Stop();
            ControleTempo = ControleTempo ?? new FrmTempo(delegate (decimal retorno)
            {
                if (retorno > 0)
                {
                    _tempo = retorno;
                    _tempoExecutado = 0;
                }
                timer.Start();
                ControleTempo.Hide();
                return 0;
            });
            ControleTempo.ShowDialog();
        }
        
        private FrmTempo ControleTempo { get; set; }

        private Timer timer = null;
        
        //tempo executado
        void _timer_Tick(object sender, EventArgs e)
        {
            _tempoExecutado += 1;
            this.Invoke((MethodInvoker)delegate
            {
                decimal ret = (_tempo - _tempoExecutado);
                 SetTime(ret.ToString());
                if (ret == 0)
                {
                    _tempoExecutado = 0;
                    timer.Stop();
                    ExecutaPilha?.Invoke(this);
                }
            });
        }

        //seta o tempo restante para o label
        private void SetTime(string time)
        {
            label1.Text = time;
        }

        public void Reinicia()
        {
            _tempoExecutado = 0;
            timer.Start();
        }
    }
}
