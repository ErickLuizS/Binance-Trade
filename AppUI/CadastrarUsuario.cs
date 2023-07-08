using AppUI.Properties;

namespace AppUI
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void BTN_Cadastrar_Click(object sender, EventArgs e)
        {
            if (TB_Usuario.Text != null)
            {



                if (TB_Senha.Text != null)
                {
                    Settings.Default.Usuario = TB_Usuario.Text;
                    Settings.Default.Senha = TB_Senha.Text;
                    Settings.Default.BolCadastro = true;
                    TelaPrincipal a = new TelaPrincipal();
                    a.Show();
                    this.Hide();



                }

                else
                {
                    MessageBox.Show("Digite uma Senha");
                }




            }

            else
            {

                MessageBox.Show("Digite um Usuário");




            }


        }
    }
}