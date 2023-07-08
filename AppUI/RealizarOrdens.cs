using AppUI;
using Binance.Common;
using L2.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Runtime.Intrinsics.X86;
using TrandingBotClasses;
using TrandingBotClasses.Converte_Object_Json;
using static TrandingBotClasses.CBinance;
using Convert = System.Convert;

namespace AppUI
{
    public partial class RealizarOrdens : Form
    {


        List<Cliente> ClientesPendentes = new List<Cliente>();
        decimal quantidade;
        string par;
        decimal stop;
        decimal price;
        string pares;
        string PoQ;
        TiposLado Lado;
        TipoOrdem Tipo;
        JsonConversao jsonConversao = new JsonConversao();
        RealizandoAOrdem RO = new RealizandoAOrdem();
        Completado CO = new Completado();


        public RealizarOrdens()
        {

            InitializeComponent();
        }

        private void RealizarOrdens_Load(object sender, EventArgs e)
        {
            Clientes_dataGridView.DataSource = Usuario.Clientes;
        }

        private void BTN_RealizarOrdem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseja confirmar a operação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                RO.LB_LadoRE.Text = Lado.ToString();
                RO.LB_ParRE.Text = par;
                switch (Tipo)
                {

                    case TipoOrdem.Market:
                        RO.LB_Preco.Visible = false;
                        break;

                    case TipoOrdem.StopLossLimitOrder:
                        RO.LB_Preco.Text = price.ToString();
                        break;


                    case TipoOrdem.StopLossOrder:
                        RO.LB_Preco.Text = price.ToString();
                        break;


                    case TipoOrdem.OcoOrder:
                        RO.LB_Preco.Text = price.ToString();
                        break;
                }


                if (CB_PorcentagemOuQuantidade.Text == "Quantidade")
                {
                    RO.LB_QuantidadeRE.Text = quantidade.ToString();

                }

                if (CB_PorcentagemOuQuantidade.Text == "Porcentagem")
                {

                    RO.LB_QuantidadeRE.Text = NUD_Porcentagem.Value.ToString();
                }


                if (RDBTN_TodosAsContas.Checked == true) { RO.p = Usuario.Clientes.Count(); }

                if (RDBTN_SelecionarContas.Checked == true)
                {

                    List<Cliente> consulta = new List<Cliente>();

                    foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["Column2"].Value);

                        if (isSelected)
                        {
                            Cliente b = row.DataBoundItem as Cliente;

                            consulta.Add(b);
                        }




                    }




                    RO.p = consulta.Count();



                }





                backgroundWorker1.RunWorkerAsync();

                IAppUI.MudarPanel(RO);



            }

            else
            {

            }

        }

        private void RDBTN_Selecionar_CheckedChanged(object sender, EventArgs e)
        {

            Clientes_dataGridView.DataSource = Usuario.Clientes;
            Clientes_dataGridView.Visible = true;
        }

        private void RDBTN_Todos_CheckedChanged(object sender, EventArgs e)
        {
            Clientes_dataGridView.Visible = false;
        }

        private void CB_TipoOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (CB_TipoOrdem.Text)
            {

                case "Market":

                    Tipo = TipoOrdem.Market;

                    break;

                case "Stop Loss Order":

                    Tipo = TipoOrdem.StopLossOrder;
                    NUD_Stop.Visible = true;
                    LB_Stop.Visible = true;
                    LB_Preco.Visible = false;
                    NUD_Preco.Visible = false;

                    break;

                case "  Stop Loss Limit Order":

                    Tipo = TipoOrdem.StopLossLimitOrder;
                    NUD_Stop.Visible = true;
                    LB_Stop.Visible = true;
                    LB_Preco.Visible = true;
                    NUD_Preco.Visible = true;

                    break;


                case "Oco Order":

                    Tipo = TipoOrdem.OcoOrder;
                    NUD_Stop.Visible = true;
                    LB_Stop.Visible = true;
                    LB_Preco.Visible = true;
                    NUD_Preco.Visible = true;
                    break;


            }

        }

        private void CB_Pares_SelectedIndexChanged(object sender, EventArgs e)
        {
            pares = CB_Pares.Text;
        }

        private void CB_Lado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Lado.Text)
            {


                case "Venda":
                    Lado = TiposLado.venda;
                    break;


                case "Compra":
                    Lado = TiposLado.compra;
                    break;




            }



        }

        private void CB_PorcentagemOuQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (CB_PorcentagemOuQuantidade.Text)
            {
                case "Quantidade":

                    LB_Porcentagem.Visible = false;
                    NUD_Porcentagem.Visible = false;
                    LB_Quantidade.Visible = true;
                    NUD_Quantidade.Visible = true;
                    PoQ = "Quantidade";
                    break;


                case "Porcentagem":

                    LB_Quantidade.Visible = false;
                    NUD_Quantidade.Visible = false;
                    LB_Porcentagem.Visible = true;
                    NUD_Porcentagem.Visible = true;
                    PoQ = "Porcentagem";
                    break;



            }



        }

        private void RBTN_VerPendentes_CheckedChanged(object sender, EventArgs e)
        {
            Clientes_dataGridView.DataSource = ClientesPendentes;

        }

        private async void backgroundWorker1_DoWorkAsync(object sender, DoWorkEventArgs e)
        {
            IAppUI.HideSidebar();
            if (await Usuario.TestarHorarioServidor())
            {

                par = pares.Replace("/", "");
                double minimoPar = (double)await MBinance.MinimoPar(par);
                string[] Moeda = pares.Split('/');
                price = NUD_Preco.Value;
                stop = NUD_Stop.Value;
                int i = 0;
                int p = Usuario.Clientes.Count();


                if (RDBTN_TodosAsContas.Checked == true)
                {




                    foreach (var cliente in Usuario.Clientes)
                    {
                        RO.LB_Nome.Text = cliente.Nome;

                        if (PoQ == "Quantidade")
                        {


                            quantidade = NUD_Quantidade.Value;
                            if (quantidade < (decimal)minimoPar)
                            {
                                MessageBox.Show("Quantidade Insuficiente");
                                break;
                            }

                        }

                        if (PoQ == "Porcentagem")
                        {

                            double saldo = await cliente.Conta.Moeda(Moeda[1]);
                            if (saldo > minimoPar)
                            {
                                double quantidadeParaOperar = Cliente.porcentagem((double)NUD_Porcentagem.Value, saldo);

                                double preçoDeMoeda = await MBinance.PrecoSimbolo(par);
                                double Qtd = quantidadeParaOperar / preçoDeMoeda;

                                quantidade = decimal.Round((decimal)Qtd, 6);
                            }
                            else
                            {
                                MessageBox.Show("Operaçao do Cliente " + cliente.Nome + "não realizada" + "Quantidade Invalida");
                                ClientesPendentes.Add(cliente);
                            }

                        }


                        try
                        {


                            await cliente.Conta.RealizarOrdens(Tipo, Lado, par, quantidade, price, stop);

                            i++;
                        }

                        catch (BinanceClientException Erro)
                        {
                            ClientesPendentes.Add(cliente);
                            if (Erro.Message == "Invalid Quantid")
                            {

                                MessageBox.Show("Operaçao do Cliente " + cliente.Nome + "não realizada" + "Quantidade Invalida");


                            }

                            MessageBox.Show("Operaçao do Cliente " + cliente.Nome + "não realizada" + " " + Erro.Message);

                        }
                        if (Usuario.TestarConexao()) {
                            if (i >= p)
                            {


                                foreach (var clienteTrades in Usuario.Clientes)
                                {

                                    string JsonTrades = await clienteTrades.Conta.TradeList(par);
                                    var TodosTrades = jsonConversao.ConverteJSonParaObject<List<Trade>>(JsonTrades);
                                    var UltimoElemento = TodosTrades.Count - 1;
                                    var UltimoTrade = TodosTrades[UltimoElemento];

                                    clienteTrades.Conta.Trades.Add(UltimoTrade);


                                    var idtest = clienteTrades.Conta.Trades.Where(t => t.TradeId == UltimoTrade.TradeId).ToList();
                                    var UltimoElementoTrade = idtest.Count - 1;



                                    Usuario.SqlServer.Trades.Add(idtest[UltimoElementoTrade]);



                                    Usuario.SqlServer.SaveChanges();




                                };


                                i = 0;


                            }
                        }
                    }

                    ClientesPendentesCheck();
                }


                if (RDBTN_SelecionarContas.Checked == true)

                {
                    List<Cliente> consulta = new List<Cliente>();
                    
                    foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["Column2"].Value);

                        if (isSelected)
                        {
                            Cliente b = row.DataBoundItem as Cliente;

                            consulta.Add(b);
                        }
                    }

                    p = consulta.Count();
                    foreach (var cliente in consulta)
                    {
                        RO.LB_Nome.Text = cliente.Nome;

                        if (PoQ == "Quantidade")
                        {


                            quantidade = NUD_Quantidade.Value;

                            if (quantidade < (decimal)minimoPar)
                            {
                                MessageBox.Show("Quantidade Insuficiente");
                                break;
                            }

                        }

                        if (PoQ == "Porcentagem")
                        {


                            double saldo = await cliente.Conta.Moeda(Moeda[1]);
                            if (saldo > minimoPar)
                            {
                                double quantidadeParaOperar = Cliente.porcentagem((double)NUD_Porcentagem.Value, saldo);

                                double preçoDeMoeda = await MBinance.PrecoSimbolo(par);
                                double Qtd = quantidadeParaOperar / preçoDeMoeda;

                                quantidade = decimal.Round((decimal)Qtd, 6);
                            }
                            else
                            {
                                MessageBox.Show("Saldo Insuficiente");
                                ClientesPendentes.Add(cliente);

                            }

                        }
                        try
                        {

                            await cliente.Conta.RealizarOrdens(Tipo, Lado, par, quantidade, price, stop);
                            i++;
                        }

                        catch (BinanceClientException Erro)
                        {
                            ClientesPendentes.Add(cliente);

                            if (Erro.Message == "Invalid Quantid")
                            {

                                MessageBox.Show("Operaçao do Cliente " + cliente.Nome + "não realizada" + "Quantidade Invalida");

                            }

                            MessageBox.Show("Operaçao do Cliente " + cliente.Nome + "não realizada" + " " + Erro.Message);

                        }
                       
                        if (Usuario.TestarConexao())
                        {
                            if (i >= p)
                            {


                                foreach (var clienteTrades in Usuario.Clientes)
                                {

                                    string JsonTrades = await clienteTrades.Conta.TradeList(par);
                                    var TodosTrades = jsonConversao.ConverteJSonParaObject<List<Trade>>(JsonTrades);
                                    var UltimoElemento = TodosTrades.Count - 1;
                                    var UltimoTrade = TodosTrades[UltimoElemento];

                                    clienteTrades.Conta.Trades.Add(UltimoTrade);


                                    var idtest = clienteTrades.Conta.Trades.Where(t => t.TradeId == UltimoTrade.TradeId).ToList();
                                    var UltimoElementoTrade = idtest.Count - 1;



                                    Usuario.SqlServer.Trades.Add(idtest[UltimoElementoTrade]);



                                    Usuario.SqlServer.SaveChanges();




                                };


                                i = 0;


                            }


                        }

                        ClientesPendentesCheck();


                    }

                }
                else { MessageBox.Show("Timestamp diferente do servidor"); backgroundWorker1.CancelAsync(); }
            }

        }
        private void ClientesPendentesCheck()
        {
            if (ClientesPendentes != null) { RBTN_VerPendentes.Visible = true; }
            else { RBTN_VerPendentes.Visible = false; }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Caso cancelado...
            if (e.Cancelled)
            {
                RO.Hide();
                MessageBox.Show("Operação Cancelada pelo Usuário!");
                IBotUI.ShowSidebar();

            }
            else if (e.Error != null)
            {

                RO.Hide();
                MessageBox.Show("Aconteceu um erro durante a execução do processo!");
                IBotUI.ShowSidebar();

            }
            else
            {
                RO.Hide();
                IBotUI.ShowSidebar();
                CO.LB_LadoRE.Text = Lado.ToString();
                CO.LB_ParRE.Text = par;

                if (CB_PorcentagemOuQuantidade.Text == "Quantidade")
                {
                    CO.LB_QuantidadeRE.Text = quantidade.ToString();




                }

                if (CB_PorcentagemOuQuantidade.Text == "Porcentagem")
                {

                    CO.LB_QuantidadeRE.Text = NUD_Porcentagem.Value.ToString();
                }


                switch (Tipo)
                {

                    case TipoOrdem.Market:
                        CO.LB_PriceRE.Visible = false;
                        break;

                    case TipoOrdem.StopLossLimitOrder:
                        CO.LB_PriceRE.Text = price.ToString();
                        break;


                    case TipoOrdem.StopLossOrder:
                        CO.LB_PriceRE.Text = price.ToString();
                        break;


                    case TipoOrdem.OcoOrder:
                        CO.LB_PriceRE.Text = price.ToString();
                        break;
                }

                IAppUI.MudarPanel(CO);

            }
        }


    }
}





