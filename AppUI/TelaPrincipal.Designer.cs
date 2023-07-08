namespace AppUI
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            Sidebar = new Panel();
            PL_Cadastrar = new Panel();
            BTN_Cadastro = new Button();
            imageList1 = new ImageList(components);
            PL_BTNRealizarOrdens = new Panel();
            BTN_RealizarOrdens = new Button();
            PN_BTNTrades = new Panel();
            BTN_Trades = new Button();
            PL_BTNLogin = new Panel();
            BTN_AtualizarDados = new Button();
            PNBTN_Cadastro = new Panel();
            PL_BTNMenu = new Panel();
            BTN_Menu = new Button();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            PL_Cadastrar.SuspendLayout();
            PL_BTNRealizarOrdens.SuspendLayout();
            PN_BTNTrades.SuspendLayout();
            PL_BTNLogin.SuspendLayout();
            PL_BTNMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.AllowDrop = true;
            Sidebar.BackColor = Color.White;
            Sidebar.Controls.Add(PL_Cadastrar);
            Sidebar.Controls.Add(PL_BTNRealizarOrdens);
            Sidebar.Controls.Add(PN_BTNTrades);
            Sidebar.Controls.Add(PL_BTNLogin);
            Sidebar.Controls.Add(PNBTN_Cadastro);
            Sidebar.Controls.Add(PL_BTNMenu);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.Margin = new Padding(3, 4, 3, 4);
            Sidebar.MaximumSize = new Size(163, 0);
            Sidebar.MinimumSize = new Size(50, 0);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(163, 845);
            Sidebar.TabIndex = 3;
            // 
            // PL_Cadastrar
            // 
            PL_Cadastrar.Controls.Add(BTN_Cadastro);
            PL_Cadastrar.Location = new Point(7, 154);
            PL_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            PL_Cadastrar.Name = "PL_Cadastrar";
            PL_Cadastrar.Size = new Size(171, 50);
            PL_Cadastrar.TabIndex = 5;
            // 
            // BTN_Cadastro
            // 
            BTN_Cadastro.BackColor = Color.White;
            BTN_Cadastro.FlatAppearance.BorderSize = 0;
            BTN_Cadastro.FlatStyle = FlatStyle.Flat;
            BTN_Cadastro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Cadastro.ForeColor = Color.Black;
            BTN_Cadastro.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Cadastro.ImageKey = "cadastro.png";
            BTN_Cadastro.ImageList = imageList1;
            BTN_Cadastro.Location = new Point(0, 1);
            BTN_Cadastro.Margin = new Padding(3, 4, 3, 4);
            BTN_Cadastro.Name = "BTN_Cadastro";
            BTN_Cadastro.Size = new Size(171, 45);
            BTN_Cadastro.TabIndex = 0;
            BTN_Cadastro.Text = "Cadastro";
            BTN_Cadastro.UseVisualStyleBackColor = false;
            BTN_Cadastro.Click += BTN_Cadastro_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "menu-aberto.png");
            imageList1.Images.SetKeyName(1, "planilha.png");
            imageList1.Images.SetKeyName(2, "botao-editar.png");
            imageList1.Images.SetKeyName(3, "cadastro.png");
            imageList1.Images.SetKeyName(4, "RealizarOrdens.png");
            // 
            // PL_BTNRealizarOrdens
            // 
            PL_BTNRealizarOrdens.Controls.Add(BTN_RealizarOrdens);
            PL_BTNRealizarOrdens.Location = new Point(7, 51);
            PL_BTNRealizarOrdens.Margin = new Padding(3, 4, 3, 4);
            PL_BTNRealizarOrdens.Name = "PL_BTNRealizarOrdens";
            PL_BTNRealizarOrdens.Size = new Size(169, 43);
            PL_BTNRealizarOrdens.TabIndex = 4;
            // 
            // BTN_RealizarOrdens
            // 
            BTN_RealizarOrdens.FlatAppearance.BorderSize = 0;
            BTN_RealizarOrdens.FlatStyle = FlatStyle.Flat;
            BTN_RealizarOrdens.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_RealizarOrdens.ForeColor = Color.FromArgb(64, 64, 64);
            BTN_RealizarOrdens.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_RealizarOrdens.ImageIndex = 4;
            BTN_RealizarOrdens.ImageList = imageList1;
            BTN_RealizarOrdens.ImeMode = ImeMode.On;
            BTN_RealizarOrdens.Location = new Point(0, 0);
            BTN_RealizarOrdens.Margin = new Padding(3, 4, 3, 4);
            BTN_RealizarOrdens.Name = "BTN_RealizarOrdens";
            BTN_RealizarOrdens.RightToLeft = RightToLeft.No;
            BTN_RealizarOrdens.Size = new Size(157, 43);
            BTN_RealizarOrdens.TabIndex = 0;
            BTN_RealizarOrdens.Text = "Realizar Ordens";
            BTN_RealizarOrdens.TextAlign = ContentAlignment.MiddleRight;
            BTN_RealizarOrdens.UseVisualStyleBackColor = true;
            BTN_RealizarOrdens.Click += BTN_RealizarOrdens_Click;
            // 
            // PN_BTNTrades
            // 
            PN_BTNTrades.Controls.Add(BTN_Trades);
            PN_BTNTrades.Location = new Point(7, 101);
            PN_BTNTrades.Margin = new Padding(3, 4, 3, 4);
            PN_BTNTrades.Name = "PN_BTNTrades";
            PN_BTNTrades.Size = new Size(171, 45);
            PN_BTNTrades.TabIndex = 3;
            // 
            // BTN_Trades
            // 
            BTN_Trades.FlatAppearance.BorderSize = 0;
            BTN_Trades.FlatStyle = FlatStyle.Flat;
            BTN_Trades.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Trades.ForeColor = Color.FromArgb(64, 64, 64);
            BTN_Trades.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Trades.ImageIndex = 1;
            BTN_Trades.ImageList = imageList1;
            BTN_Trades.Location = new Point(0, 0);
            BTN_Trades.Margin = new Padding(3, 4, 3, 4);
            BTN_Trades.Name = "BTN_Trades";
            BTN_Trades.Size = new Size(171, 45);
            BTN_Trades.TabIndex = 0;
            BTN_Trades.Text = "Trades";
            BTN_Trades.UseVisualStyleBackColor = true;
            BTN_Trades.Click += BTN_Trades_Click;
            // 
            // PL_BTNLogin
            // 
            PL_BTNLogin.Controls.Add(BTN_AtualizarDados);
            PL_BTNLogin.Location = new Point(7, 207);
            PL_BTNLogin.Margin = new Padding(3, 4, 3, 4);
            PL_BTNLogin.Name = "PL_BTNLogin";
            PL_BTNLogin.Size = new Size(171, 45);
            PL_BTNLogin.TabIndex = 2;
            // 
            // BTN_AtualizarDados
            // 
            BTN_AtualizarDados.FlatAppearance.BorderSize = 0;
            BTN_AtualizarDados.FlatStyle = FlatStyle.Flat;
            BTN_AtualizarDados.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_AtualizarDados.ForeColor = Color.Black;
            BTN_AtualizarDados.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_AtualizarDados.ImageKey = "botao-editar.png";
            BTN_AtualizarDados.ImageList = imageList1;
            BTN_AtualizarDados.ImeMode = ImeMode.On;
            BTN_AtualizarDados.Location = new Point(0, 0);
            BTN_AtualizarDados.Margin = new Padding(3, 4, 3, 4);
            BTN_AtualizarDados.Name = "BTN_AtualizarDados";
            BTN_AtualizarDados.Size = new Size(171, 45);
            BTN_AtualizarDados.TabIndex = 0;
            BTN_AtualizarDados.Text = "Atualizar";
            BTN_AtualizarDados.UseVisualStyleBackColor = true;
            BTN_AtualizarDados.Click += BTN_Atualizar_Click;
            // 
            // PNBTN_Cadastro
            // 
            PNBTN_Cadastro.BackColor = Color.SlateGray;
            PNBTN_Cadastro.Location = new Point(7, 155);
            PNBTN_Cadastro.Margin = new Padding(3, 4, 3, 4);
            PNBTN_Cadastro.Name = "PNBTN_Cadastro";
            PNBTN_Cadastro.Size = new Size(171, 45);
            PNBTN_Cadastro.TabIndex = 0;
            // 
            // PL_BTNMenu
            // 
            PL_BTNMenu.BackColor = Color.White;
            PL_BTNMenu.CausesValidation = false;
            PL_BTNMenu.Controls.Add(BTN_Menu);
            PL_BTNMenu.ForeColor = Color.White;
            PL_BTNMenu.Location = new Point(7, 4);
            PL_BTNMenu.Margin = new Padding(3, 4, 3, 4);
            PL_BTNMenu.Name = "PL_BTNMenu";
            PL_BTNMenu.Size = new Size(171, 37);
            PL_BTNMenu.TabIndex = 1;
            // 
            // BTN_Menu
            // 
            BTN_Menu.BackgroundImageLayout = ImageLayout.None;
            BTN_Menu.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 192);
            BTN_Menu.FlatAppearance.BorderSize = 0;
            BTN_Menu.FlatStyle = FlatStyle.Flat;
            BTN_Menu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_Menu.ForeColor = Color.FromArgb(64, 64, 64);
            BTN_Menu.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_Menu.ImageIndex = 0;
            BTN_Menu.ImageList = imageList1;
            BTN_Menu.Location = new Point(0, 0);
            BTN_Menu.Margin = new Padding(3, 4, 3, 4);
            BTN_Menu.Name = "BTN_Menu";
            BTN_Menu.RightToLeft = RightToLeft.No;
            BTN_Menu.Size = new Size(169, 36);
            BTN_Menu.TabIndex = 0;
            BTN_Menu.Text = "Menu";
            BTN_Menu.UseVisualStyleBackColor = true;
            BTN_Menu.Click += BTN_Menu_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(1061, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(163, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 845);
            panel1.TabIndex = 7;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 10;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1061, 845);
            Controls.Add(panel1);
            Controls.Add(Sidebar);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaPrincipal";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                                                                                                      ";
            TopMost = true;
            Load += TelaPrincipal_LoadAsync;
            Sidebar.ResumeLayout(false);
            PL_Cadastrar.ResumeLayout(false);
            PL_BTNRealizarOrdens.ResumeLayout(false);
            PN_BTNTrades.ResumeLayout(false);
            PL_BTNLogin.ResumeLayout(false);
            PL_BTNMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PL_BTNMenu;
        private Button BTN_Menu;
        private ImageList imageList1;
        private Panel PL_BTNLogin;
        private MenuStrip menuStrip1;
        private Panel PNBTN_Cadastro;
        private Button BTN_Cadastro;
        public Panel panel1;
        private Panel PN_BTNTrades;
        private Button BTN_Trades;
        private Panel PL_BTNRealizarOrdens;
        private Button BTN_RealizarOrdens;
        public Panel Sidebar;
        private Button BTN_AtualizarDados;
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel PL_Cadastrar;
    }
}