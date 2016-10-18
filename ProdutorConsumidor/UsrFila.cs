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
    public partial class UsrFila : UserControl
    {
        public UsrFila(int pos)
        {
            InitializeComponent();
            Posicao = pos;
        }

        public int Posicao { get; } = 0;


        public void SetaEstado(bool ocupado)
        {
            BackColor = ocupado ? Color.Black : Color.AliceBlue;
        }
    }
}
