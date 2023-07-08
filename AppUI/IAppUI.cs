namespace AppUI
{
    public interface IAppUI
    {
        public static Panel panel { get; set; }
        public static TelaPrincipal TP { get; set; }

        /// <summary>
        ///Muda o formulário mostrafo no Panel.<para />
        /// </summary>       
        /// <param name="form">Formulário a ser mostrado.</param>
        public static void MudarPanel(Form form)
        {


            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            panel.Tag = form;
            form.Show();
            form.BringToFront();

        }

        /// <summary>
        ///Deixa a Sidebar não visível.<para />
        /// </summary>
        public static void HideSidebar()
        {

            if (TP.Sidebar.InvokeRequired)
            {
                TP.Sidebar.Invoke(new Action(HideSidebar)); // Executa no thread de interface do usuário
                return;
            }


            TP.Sidebar.Visible = false;
        }

        /// <summary>
        ///Deixa a Sidebar visível.<para />
        /// </summary>
        public static void ShowSidebar()
        {
            if (TP.Sidebar.InvokeRequired)
            {
                TP.Sidebar.Invoke(new Action(ShowSidebar)); // Executa no thread de interface do usuário
                return;
            }

            TP.Sidebar.Visible = true;
        }

    }
}
