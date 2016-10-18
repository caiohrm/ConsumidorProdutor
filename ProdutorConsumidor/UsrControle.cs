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
    public partial class UsrControle : UserControl
    {
        public UsrControle(int qteProdutor, int tpProdutor,bool prodaleatorio,int qteConsumidor,int tpConsumidor,bool consaleatorio ,int fila)
        {
            InitializeComponent();
            _qteProdutor = qteProdutor;
            _tpProdutor = tpProdutor;
            _prodaleatorio = prodaleatorio;
            _qteConsumidor = qteConsumidor;
            _tpConsumidor = tpConsumidor;
            _consaleatorio = consaleatorio;
            _fila = fila;
            Inicializa();
        }

        private int _qteProdutor = -1;
        int _tpProdutor = -1;
        private bool _prodaleatorio;
        int _qteConsumidor = -1;
        int _tpConsumidor = -1;
        private bool _consaleatorio;
        int _fila = -1;

        //lista de produtores
        private List<Pessoa> _lstProdutor = null;
        public List<Pessoa> LstProdutor => (_lstProdutor ?? (_lstProdutor = new List<Pessoa>()));
        //lista de consumidores
        private List<Pessoa> _lstConsumidor = null;
        public List<Pessoa> LstConsumidor => (_lstConsumidor ?? (_lstConsumidor = new List<Pessoa>()));
        //Lista de posições da fila
        public List<UsrFila> _ltFilas = null;
        public List<UsrFila> LstFilas => (_ltFilas ?? (_ltFilas = new List<UsrFila>()));
        //Pilha de posições desocupadas na fila
        private Queue<UsrFila> _pilhaLivre = null;
        private Queue<UsrFila> PilhaLivre => (_pilhaLivre ?? (_pilhaLivre = new Queue<UsrFila>()));
        //Pilha de posições ocupadas na fila
        private Queue<UsrFila> _pilhaOcupada = null;
        private Queue<UsrFila> PilhaOcupada => (_pilhaOcupada ?? (_pilhaOcupada = new Queue<UsrFila>()));
        private Queue<Pessoa> _produtor = null;
        private Queue<Pessoa> Produtor => (_produtor ?? (_produtor = new Queue<Pessoa>()));
        private Queue<Pessoa> _consumidor = null;
        private Queue<Pessoa> Consumidor => (_consumidor ?? (_consumidor = new Queue<Pessoa>()));
        private int width = 0;
        private int height = 0;
        /// <summary>
        /// Inicializa quantidade de produtores,consumidores e fila
        /// </summary>
        private void Inicializa()
        {
            //inicializa produtores
            for (int i = 0; i < _qteProdutor; i++)
            {
                //cria produtor
                Pessoa pessoa = new Pessoa(_prodaleatorio ? GetRandom(_tpProdutor) : _tpProdutor);
                pessoa.ExecutaPilha += Pessoa_ProdutorPilha;
                LstProdutor.Add(pessoa);
                //define localização do produtor no painel
                pessoa.Location = new Point(width,height);
                PlProdutor.Controls.Add(pessoa);
                width += pessoa.Width;
                if (width >= 800)
                {
                    width = 0;
                    height += pessoa.Height;
                }
            }
            PlProdutor.Height = (height == 0 ? 92 : height + 92) + 10;
            height = 0;
            width = 0;
            //inicializa consumidores
            for (int i = 0; i < _qteConsumidor; i++)
            {
                //cria consumidor
                Pessoa pessoa = new Pessoa(_consaleatorio  ? GetRandom(_tpConsumidor) : _tpConsumidor);
                pessoa.ExecutaPilha += Pessoa_ConsomePilha;
                LstConsumidor.Add(pessoa);
                //define localização do consumidor no painel
                pessoa.Location = new Point(width, height);
                PlConsumidor.Controls.Add(pessoa);
                width += pessoa.Width;
                if (width >= 800)
                {
                    width = 0;
                    height += pessoa.Height ;
                }
            }
            PlConsumidor.Height = (height == 0 ? 92 : height + 92) + 10;
            height = 0;
            width = 0;
            for (int i = 0; i < _fila; i++)
            {
                //cria posição da fila
                UsrFila fila = new UsrFila(i);
                fila.SetaEstado(false);
                PilhaLivre.Enqueue(fila);
                LstFilas.Add(fila);
                //define posição da fila no painel
                fila.Location = new Point(width,height);
                PlFila.Controls.Add(fila);
                width += fila.Width;
                if (width >= 800)
                {
                    width = 0;
                    height += fila.Height;
                }
            }
            PlFila.Height = (height == 0 ? 92 : height + 92) + 10;
        }

        private Random random = null;
        /// <summary>
        /// retorna um valor aleatorio com um limite maximo 
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        private int GetRandom(int max)
        {
            int ret = 0;
            random = random ?? new Random();
            ret = random.Next(max);
            //verifica se valor maior que zero, caso contrario seleciona um novo valor aleatorio
            ret = ret > 0 ? ret : GetRandom(max);
            return ret;
        }

        private void Pessoa_ConsomePilha(Pessoa pessoa)
        {
            if (!PilhaOcupada.Any())
            {
                Consumidor.Enqueue(pessoa);
                return;
            }
            UsrFila fila = PilhaOcupada.Dequeue();
            if (fila == null)
                return;
            fila.SetaEstado(false);
            pessoa.Reinicia();
            PilhaLivre.Enqueue(fila);
            EventoProdutor();
        }

        private void Pessoa_ProdutorPilha(Pessoa pessoa)
        {
            if (!PilhaLivre.Any())
            {
                Produtor.Enqueue(pessoa);
                return;
            }
            UsrFila fila = PilhaLivre.Dequeue();
            if (fila == null)
                return;
            fila.SetaEstado(true);
            pessoa.Reinicia();
            PilhaOcupada.Enqueue(fila);
            EventoConsumidor();
        }

        private void EventoProdutor()
        {
            if (Produtor.Any())
            {
                Pessoa pessoa = Produtor.Dequeue();
                Pessoa_ProdutorPilha(pessoa);
            }
        }

        private void EventoConsumidor()
        {
            if (Consumidor.Any())
            {
                Pessoa pessoa = Consumidor.Dequeue();
                Pessoa_ConsomePilha(pessoa);
            }
        }
    }
}
