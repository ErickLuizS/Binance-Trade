using TrandingBotClasses;
using Microsoft.EntityFrameworkCore;
using TrandingBotClasses.Context;

namespace AppUI
{

    public partial class TelaPrincipal : Form, IAppUI
    {

        bool sidebarExpand;
        string atual;


        public TelaPrincipal()
        {
            InitializeComponent();
            SidebarTimer.Start();
        }

        public void close(Form form)
        {
            form.Close();
        }

        private void BTN_Menu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();//Busca na coleção de formulários 
            //se não o formulario nao existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                panel1.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //se o formulario existe
            else
            {
                formulario.BringToFront();
            }


        }



        private void BTN_Atualizar_Click(object sender, EventArgs e)
        {


            if (atual != "Editar")
            {

                AbrirFormulario<EscolherClienteAtualiazarDados>();

                atual = "Editar";
            }



        }

        private async void TelaPrincipal_LoadAsync(object sender, EventArgs e)
        {
            IAppUI.panel = panel1;
            IAppUI.TP = this;

            atual = "";
            this.SetBevel(false);

            string nomeArquivo = "App.db";
            string caminhoCompleto = Path.GetFullPath(nomeArquivo);
            Usuario.SqlCipher = new SqlCipherContext(caminhoCompleto);







            //  if(p.Clientes.Include(p => p.Conta).Include(p => p.Sheets).ToList() == null) { MessageBox.Show("NULL"); }
            //   




            //if (t != null) { Usuario.Clientes = t; }
            //else { MessageBox.Show("Nenhum cliente cadastrado"); }

            if (Usuario.TestarConexao())
            {

                // Sincroniza os bancos de dados
                var SqlServerContext = Usuario.SqlServer;
                var SqlCipherContext = Usuario.SqlCipher;
                var SqlServer = SqlServerContext.Clientes.Include(p => p.Conta).Include(p => p.Sheets).ToList();
                var SqlCipher = SqlCipherContext.Clientes.Include(p => p.Conta).Include(p => p.Sheets).ToList();
                var ClientesToAddSqlCipher = SqlServer.Except(SqlCipher, new ClienteComparer()).ToList();
                var ClientesToAddSqlServer = SqlCipher.Except(SqlServer, new ClienteComparer()).ToList();

                ClientesToAddSqlCipher.ForEach(e => SqlCipherContext.Clientes.Add(e));
                ClientesToAddSqlServer.ForEach(e => SqlServerContext.Clientes.Add(e));

                SqlCipherContext.SaveChanges();
                SqlServerContext.SaveChanges();



            }
            else { MessageBox.Show("Sem Conexão com o Banco de Dados SQL Server"); }

            if (await Usuario.TestarHorarioServidor() == false)
            {
                MessageBox.Show("Horario do Servidor é diferente do horario Local");
            }

            AbrirFormulario<RealizarOrdens>();

            atual = "Realizar Ordens";
        }

        private void BTN_Cadastro_Click(object sender, EventArgs e)
        {

            if (atual != "Cadastro")
            {
                AbrirFormulario<CadastroCliente>();

                atual = "Cadastro";

            }
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }

            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }

        }

        private void BTN_Trades_Click(object sender, EventArgs e)
        {
            if (atual != "Trades")
            {
                AbrirFormulario<EscolherClienteTrades>();

                atual = "Trades";
            }
        }

        private void BTN_RealizarOrdens_Click(object sender, EventArgs e)
        {
            if (atual != "Realizar Ordens")
            {
                AbrirFormulario<RealizarOrdens>();

                atual = "Realizar Ordens";
            }
        }

        private void BTN_EditarDados_Click(object sender, EventArgs e)
        {

            if (atual != "Escolher Cliente Atualizar Dados")
            {
                AbrirFormulario<EscolherClienteAtualiazarDados>();

                atual = "Escolher Cliente Atualizar Dados";
            }
        }



    }
}
