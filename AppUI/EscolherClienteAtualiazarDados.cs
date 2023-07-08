using TrandingBotClasses;

namespace AppUI
{
    public partial class EscolherClienteAtualiazarDados : Form
    {
        public EscolherClienteAtualiazarDados()
        {
            InitializeComponent();
        }

        private void Clientes_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Clientes_dataGridView.Columns[e.ColumnIndex].Name == "Editar")
            {


                var Index = Clientes_dataGridView.CurrentCell.ColumnIndex;
                foreach (DataGridViewRow row in Clientes_dataGridView.Rows)
                {
                    if (row.Index == Index)
                    {


                        Cliente b = row.DataBoundItem as Cliente;


                        IBotUI.MudarPanel(new AtualizarDados(b));



                    }
                }
            }
        }

        private void EscolherClienteAtualiazarDados_Load(object sender, EventArgs e)
        {
            Clientes_dataGridView.DataSource = Usuario.Clientes;
        }
    }
}
