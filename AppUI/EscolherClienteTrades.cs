using AppUI;
using DocumentFormat.OpenXml.Drawing;
using TrandingBotClasses;


namespace AppUI
{


    public partial class EscolherClienteTrades : Form
    {
        string par;

        public EscolherClienteTrades()
        {
            InitializeComponent();
        }


        private void EscolherClienteTrades_Load(object sender, EventArgs e)
        {
            Clientes_dataGridView.DataSource = Usuario.Clientes;

        }

        private void Clientes_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (par == null) { MessageBox.Show("Par não selecionado"); }
            else
            {

                if (Clientes_dataGridView.Columns[e.ColumnIndex].Name == "Select")
                {


                    var c = Clientes_dataGridView.CurrentCell.ColumnIndex;
                    foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
                    {
                        if (row.Index == c)
                        {

                            Cliente cliente = row.DataBoundItem as Cliente;

                            if (cliente.Sheets.SheetID == null || cliente.Sheets.TabName == null)
                            {
                                MessageBox.Show("Sem planilha cadastrada");
                                break;
                            }
                            else
                            {
                                IBotUI.MudarPanel(new ListaDeTradesSheets(cliente, par));
                                break;
                            }


                        }

                    }

                }
            }
        }

        private void CB_Pares_SelectedIndexChanged(object sender, EventArgs e)
        {
            par = CB_Pares.Text.Replace("/", "");
        }
    }
}
