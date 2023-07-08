using TrandingBotClasses;

namespace AppUI
{
    public partial class AtualizarDados : Form
    {
        private readonly Cliente cliente;
        private readonly Guid id;
        private bool sqlConectado = false;

        public AtualizarDados(Cliente cliente)
        {
            this.cliente = cliente;
            this.id = cliente.ClienteId;

            InitializeComponent();
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            if (!Usuario.TestarConexao())
            {
                MessageBox.Show("Sem conexão com o SQL Server");
                return;
            }

            var clienteSqlServer = Usuario.SqlServer.Clientes.FirstOrDefault(s => s.ClienteId == id);
            var clienteSqlCipher = Usuario.SqlCipher.Clientes.FirstOrDefault(s => s.ClienteId == id);

            if (clienteSqlServer != null)
            {
                AtualizarCliente(clienteSqlServer);
                sqlConectado = true;
            }

            if (clienteSqlCipher != null)
            {
                AtualizarCliente(clienteSqlCipher);
            }
        }

        private void AtualizarCliente(Cliente cliente)
        {
            if (!string.IsNullOrEmpty(TB_Nome.Text))
            {
                cliente.Nome = TB_Nome.Text;
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome");
            }

            if (!string.IsNullOrEmpty(TB_ApiKey.Text))
            {
                cliente.Conta.apiKey = TB_ApiKey.Text;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma Api Key");
            }

            if (!string.IsNullOrEmpty(TB_ApiSecret.Text))
            {
                cliente.Conta.apiSecret = TB_ApiSecret.Text;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma Api Secret");
            }

            if (string.IsNullOrEmpty(TB_SheetID.Text) && MessageBox.Show("Deseja inserir um SheetId?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                cliente.Sheets.SheetID = TB_SheetID.Text;
            }

            if (string.IsNullOrEmpty(TB_NomeDaFolha.Text) && MessageBox.Show("Deseja inserir um Folha?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                cliente.Sheets.TabName = TB_NomeDaFolha.Text;
            }

            if (sqlConectado)
            {
                Usuario.SqlServer.SaveChanges();
            }

            Usuario.SqlCipher.SaveChanges();
        }

        private void AtualizarDados_Load(object sender, EventArgs e)
        {
            TB_Nome.Text = cliente.Nome;
            TB_ApiKey.Text = cliente.Conta.apiKey;
            TB_ApiSecret.Text = cliente.Conta.apiSecret;
            TB_NomeDaFolha.Text = cliente.Sheets.TabName;
            TB_SheetID.Text = cliente.Sheets.SheetID;
        }

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            var clienteSqlServer = Usuario.SqlServer.Clientes.FirstOrDefault(s => s.ClienteId == id);
            if (clienteSqlServer != null)
            {
                Usuario.SqlServer.Clientes.Remove(clienteSqlServer);
                Usuario.SqlServer.SaveChanges();
            }

            var clienteSqlCipher = Usuario.SqlCipher.Clientes.FirstOrDefault(s => s.ClienteId == id);
            if (clienteSqlCipher != null)
            {
                Usuario.SqlCipher.Clientes.Remove(clienteSqlCipher);
                Usuario.SqlCipher.SaveChanges();
            }
        }
    }
}
