using TrandingBotClasses;

namespace AppUI
{
    internal static class Program
    {
        /// <summary>
        public static void AppRun() { Application.Run(new TelaPrincipal()); } ///  The main entry point for the application.
                                                                              /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            ApplicationConfiguration.Initialize();
            // Application.Run(new CadastroCliente());

            Application.Run(new TelaPrincipal());


            //if (Properties.Settings.Default.BolCadastro == true)
            //{
            //    Application.Run(new Login());
            //}
            //else
            //{
            //    Application.Run(new CadastrarUsuario());
            //}

        }



    }
}
