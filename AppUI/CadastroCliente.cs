using L2.Services;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using TrandingBotClasses;

namespace AppUI
{
    public partial class CadastroCliente : Form
    {
        private Cryptography cryptography;

        public CadastroCliente()
        {
            InitializeComponent();
            cryptography = new Cryptography(Cryptography.Key);
        }

        private void BTN_Cadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBX_Nome.Text))
            {
                MessageBox.Show("Por favor, insira um Nome");
                return;
            }

            if (string.IsNullOrEmpty(TBX_ApiKey.Text))
            {
                MessageBox.Show("Por favor, insira uma Api Key");
                return;
            }

            if (string.IsNullOrEmpty(TBX_ApiSecret.Text))
            {
                MessageBox.Show("Por favor, insira uma Api Secret");
                return;
            }

            Cliente cliente = new Cliente
            {
                ClienteId = Guid.NewGuid(),
                Conta = new CBinance { CBinanceId = Guid.NewGuid() },
                Nome = TBX_Nome.Text
            };

            string apiKeyCriptografado = cryptography.Encrypt(TBX_ApiKey.Text);
            cliente.Conta.apiKey = apiKeyCriptografado;

            string apiSecretCriptografado = cryptography.Encrypt(TBX_ApiSecret.Text);
            cliente.Conta.apiSecret = apiSecretCriptografado;

            if (string.IsNullOrEmpty(TBX_NomeDaFolha.Text))
            {
                if (MessageBox.Show("Deseja inserir um SheetId?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                string sheetIdCriptografado = cryptography.Encrypt(TBX_NomeDaFolha.Text);
                cliente.Sheets.SheetID = sheetIdCriptografado;
            }

            if (string.IsNullOrEmpty(TBX_NomeDaTabela.Text))
            {
                if (MessageBox.Show("Deseja inserir uma Folha?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
            else
            {
                cliente.Sheets = new GoogleSheets { TabName = TBX_NomeDaTabela.Text };
            }

            if (Usuario.TestarConexao())
            {
                Usuario.SqlServer.Clientes.Add(cliente);
                Usuario.SqlServer.SaveChanges();
            }

            Usuario.SqlCipher.Clientes.Add(cliente);
            Usuario.SqlCipher.SaveChanges();
        }
    }
}