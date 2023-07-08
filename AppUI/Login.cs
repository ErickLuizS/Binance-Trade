using AppUI.Properties;

namespace AppUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {

            if (Settings.Default.Usuario == TBX_Usúario.Text)
            {
                if (Settings.Default.Senha == TBX_Senha.Text)
                {
                    Application.Run(new TelaPrincipal());
                    Close();
                    ;

                }
                else { MessageBox.Show("Senha de usuario errada "); }
            }
            else { MessageBox.Show("Nome de usuario errado "); }

        }

    }
}

