using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrandingBotClasses;

namespace AppUI
{
    public partial class RealizandoAOrdem : Form
    {
        public List<Cliente> consulta { get; set; }
        public string par { get; set; }
        public double minimoPar { get; set; }
        public string[] Moeda { get; set; }
        public decimal price { get; set; }
        public decimal stop { get; set; }
        public int i = 0;
        public int p;
        public enum TiposLado { Venda, Compra }
        public enum TipoOrdem { Market, StopLossOrder, StopLossLimitOrder, OcoOrder }
        public enum TipoLista { Todos, Selecionar }
        public TipoLista Lista { get; set; }
        public TiposLado Lado { get; set; }
        public TipoOrdem Tipo { get; set; }
        public string PorcentgemOuQuantidade;
        public string ContaNome { get; set; }

        public RealizandoAOrdem()
        {
            InitializeComponent();
        }
    }
}
