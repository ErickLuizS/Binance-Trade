using DocumentFormat.OpenXml.Spreadsheet;
using System.ComponentModel;
using TrandingBotClasses;
using TrandingBotClasses.Converte_Object_Json;

namespace AppUI
{
    public partial class ListaDeTradesSheets : Form
    {

        private Cliente cliente;
        private string Par;
        private int qtyTrades;

        public ListaDeTradesSheets(Cliente cliente, string par)
        {

            InitializeComponent();
            this.cliente = cliente;
            Par = par;
        }

        private async void ListaDeTrades_Load(object sender, EventArgs e)
        {


            var jsonConversao = new JsonConversao();
            cliente.Conta.CreateSpot();

            LB_NomeDaFolha.Text = cliente.Sheets.TabName;

            string r = await cliente.Conta.TradeList(Par);
            var TradesTodos = jsonConversao.ConverteJSonParaObject<List<Trade>>(r);

            Clientes_dataGridView.DataSource = TradesTodos;
            qtyTrades = TradesTodos.Count;

            if (TradesTodos == null) { MessageBox.Show("Não foi realizado operações nessa conta"); }


        }

        private async void BTN_EnviarSelecionados_Click(object sender, EventArgs e)
        {
            backgroundWorkerSelecionados.RunWorkerAsync();
            progressBar1.Visible = true;

        }

        private async void BTN_EnviarTodos_Click(object sender, EventArgs e)
        {
            backgroundWorkerTodos.RunWorkerAsync();
            progressBar1.Visible = true;

        }

        private async void backgroundWorkerTodos_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            List<Trade> Trades = new List<Trade>();

            foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
            {
                Trade b = row.DataBoundItem as Trade;

                Trades.Add(b);
            }

            for (int i = 0; i <= qtyTrades; i++)
            {
                foreach (Trade trade in Trades)
                {

                    backgroundWorkerTodos.ReportProgress(i);
                    await cliente.Sheets.Gravar(
                        trade.symbol,
                        trade.id,
                        trade.orderId,
                        trade.price,
                        trade.qty,
                        trade.quoteQty,
                        trade.comission,
                        trade.comissionAsset,
                        trade.time
                        );


                }
            }

        }

        private void backgroundWorkerTodos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerTodos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
        }

        private async void backgroundWorkerSelecionados_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Trade> Trades = new List<Trade>();
            foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Selecionado"].Value);

                if (isSelected)
                {
                    Trade b = row.DataBoundItem as Trade;

                    Trades.Add(b);
                }
            }

            foreach (Trade trade in Trades)
            {
                await cliente.Sheets.Gravar(
                    trade.symbol,
                    trade.id,
                    trade.orderId,
                    trade.price,
                    trade.qty,
                    trade.quoteQty,
                    trade.comission,
                    trade.comissionAsset,
                    trade.time
                    );
            }
        }
    }
}



