namespace AppUI
{
    partial class RealizarOrdens
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            RDBTN_TodosAsContas = new RadioButton();
            RDBTN_SelecionarContas = new RadioButton();
            BTN_RealizarOrdem = new Button();
            CB_TipoOrdem = new ComboBox();
            NUD_Quantidade = new NumericUpDown();
            CB_Pares = new ComboBox();
            NUD_Stop = new NumericUpDown();
            NUD_Preco = new NumericUpDown();
            LB_Quantidade = new Label();
            LB_Preco = new Label();
            LB_Stop = new Label();
            CB_Lado = new ComboBox();
            LB_Porcentagem = new Label();
            NUD_Porcentagem = new NumericUpDown();
            CB_PorcentagemOuQuantidade = new ComboBox();
            LB_TipoOrdem = new Label();
            LB_Pares = new Label();
            LB_Lado = new Label();
            RBTN_VerPendentes = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LB_OperarSobre = new Label();
            Clientes_dataGridView = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)NUD_Quantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Stop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Preco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Porcentagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // RDBTN_TodosAsContas
            // 
            RDBTN_TodosAsContas.AutoSize = true;
            RDBTN_TodosAsContas.BackColor = Color.White;
            RDBTN_TodosAsContas.ForeColor = Color.Black;
            RDBTN_TodosAsContas.Location = new Point(12, 12);
            RDBTN_TodosAsContas.Name = "RDBTN_TodosAsContas";
            RDBTN_TodosAsContas.Size = new Size(109, 19);
            RDBTN_TodosAsContas.TabIndex = 2;
            RDBTN_TodosAsContas.Text = "Todas as Contas";
            RDBTN_TodosAsContas.UseVisualStyleBackColor = false;
            RDBTN_TodosAsContas.CheckedChanged += RDBTN_Todos_CheckedChanged;
            // 
            // RDBTN_SelecionarContas
            // 
            RDBTN_SelecionarContas.AutoSize = true;
            RDBTN_SelecionarContas.ForeColor = Color.Black;
            RDBTN_SelecionarContas.Location = new Point(136, 12);
            RDBTN_SelecionarContas.Name = "RDBTN_SelecionarContas";
            RDBTN_SelecionarContas.Size = new Size(119, 19);
            RDBTN_SelecionarContas.TabIndex = 3;
            RDBTN_SelecionarContas.Text = "Selecionar Contas";
            RDBTN_SelecionarContas.UseVisualStyleBackColor = true;
            RDBTN_SelecionarContas.CheckedChanged += RDBTN_Selecionar_CheckedChanged;
            // 
            // BTN_RealizarOrdem
            // 
            BTN_RealizarOrdem.Dock = DockStyle.Bottom;
            BTN_RealizarOrdem.FlatStyle = FlatStyle.Popup;
            BTN_RealizarOrdem.ForeColor = Color.Black;
            BTN_RealizarOrdem.Location = new Point(0, 701);
            BTN_RealizarOrdem.Name = "BTN_RealizarOrdem";
            BTN_RealizarOrdem.Size = new Size(606, 34);
            BTN_RealizarOrdem.TabIndex = 7;
            BTN_RealizarOrdem.Text = "Realizar Ordem";
            BTN_RealizarOrdem.UseVisualStyleBackColor = true;
            BTN_RealizarOrdem.Click += BTN_RealizarOrdem_Click;
            // 
            // CB_TipoOrdem
            // 
            CB_TipoOrdem.Cursor = Cursors.Hand;
            CB_TipoOrdem.FormattingEnabled = true;
            CB_TipoOrdem.Items.AddRange(new object[] { "Market", "Stop Loss Order", "Stop Loss Limit Order", "Oco Order" });
            CB_TipoOrdem.Location = new Point(113, 48);
            CB_TipoOrdem.Name = "CB_TipoOrdem";
            CB_TipoOrdem.Size = new Size(121, 23);
            CB_TipoOrdem.TabIndex = 1;
            CB_TipoOrdem.SelectedIndexChanged += CB_TipoOrdem_SelectedIndexChanged;
            // 
            // NUD_Quantidade
            // 
            NUD_Quantidade.Cursor = Cursors.SizeAll;
            NUD_Quantidade.DecimalPlaces = 5;
            NUD_Quantidade.Location = new Point(12, 173);
            NUD_Quantidade.Maximum = new decimal(new int[] { 10000000, 0, 0, 196608 });
            NUD_Quantidade.Name = "NUD_Quantidade";
            NUD_Quantidade.Size = new Size(107, 23);
            NUD_Quantidade.TabIndex = 3;
            NUD_Quantidade.TextAlign = HorizontalAlignment.Center;
            NUD_Quantidade.UpDownAlign = LeftRightAlignment.Left;
            NUD_Quantidade.Visible = false;
            // 
            // CB_Pares
            // 
            CB_Pares.FormattingEnabled = true;
            CB_Pares.Items.AddRange(new object[] { "BTC/USDT", "BTC/BUSD", "ETH/USDT", "BUSD/USDT", "ETH/BUSD", "OP/USDT", "ETH/BTC", "BNX/USDT", "XRP/USDT", "FIL/USDT", "BNB/USDT", "MATIC/USDT", "SOL/USDT", "CFX/USDT", "CFX/USDT", "OP/BUSD", "USDT/TRY", "BTC/EUR", "" });
            CB_Pares.Location = new Point(304, 91);
            CB_Pares.Name = "CB_Pares";
            CB_Pares.Size = new Size(121, 23);
            CB_Pares.TabIndex = 2;
            CB_Pares.SelectedIndexChanged += CB_Pares_SelectedIndexChanged;
            // 
            // NUD_Stop
            // 
            NUD_Stop.Cursor = Cursors.SizeAll;
            NUD_Stop.DecimalPlaces = 5;
            NUD_Stop.Location = new Point(127, 173);
            NUD_Stop.Maximum = new decimal(new int[] { 10000000, 0, 0, 196608 });
            NUD_Stop.Name = "NUD_Stop";
            NUD_Stop.Size = new Size(107, 23);
            NUD_Stop.TabIndex = 5;
            NUD_Stop.TextAlign = HorizontalAlignment.Center;
            NUD_Stop.UpDownAlign = LeftRightAlignment.Left;
            NUD_Stop.Visible = false;
            // 
            // NUD_Preco
            // 
            NUD_Preco.Cursor = Cursors.SizeAll;
            NUD_Preco.DecimalPlaces = 5;
            NUD_Preco.Location = new Point(239, 173);
            NUD_Preco.Maximum = new decimal(new int[] { 10000000, 0, 0, 196608 });
            NUD_Preco.Name = "NUD_Preco";
            NUD_Preco.Size = new Size(107, 23);
            NUD_Preco.TabIndex = 4;
            NUD_Preco.TextAlign = HorizontalAlignment.Center;
            NUD_Preco.UpDownAlign = LeftRightAlignment.Left;
            NUD_Preco.Visible = false;
            // 
            // LB_Quantidade
            // 
            LB_Quantidade.AutoSize = true;
            LB_Quantidade.ForeColor = Color.Black;
            LB_Quantidade.Location = new Point(12, 155);
            LB_Quantidade.Name = "LB_Quantidade";
            LB_Quantidade.Size = new Size(69, 15);
            LB_Quantidade.TabIndex = 15;
            LB_Quantidade.Text = "Quantidade";
            LB_Quantidade.Visible = false;
            // 
            // LB_Preco
            // 
            LB_Preco.AutoSize = true;
            LB_Preco.ForeColor = Color.Black;
            LB_Preco.Location = new Point(239, 155);
            LB_Preco.Name = "LB_Preco";
            LB_Preco.Size = new Size(37, 15);
            LB_Preco.TabIndex = 16;
            LB_Preco.Text = "Preço";
            LB_Preco.Visible = false;
            // 
            // LB_Stop
            // 
            LB_Stop.AutoSize = true;
            LB_Stop.ForeColor = Color.Black;
            LB_Stop.Location = new Point(127, 155);
            LB_Stop.Name = "LB_Stop";
            LB_Stop.Size = new Size(31, 15);
            LB_Stop.TabIndex = 17;
            LB_Stop.Text = "Stop";
            LB_Stop.Visible = false;
            // 
            // CB_Lado
            // 
            CB_Lado.FormattingEnabled = true;
            CB_Lado.Items.AddRange(new object[] { "Compra", "Venda" });
            CB_Lado.Location = new Point(113, 85);
            CB_Lado.Name = "CB_Lado";
            CB_Lado.Size = new Size(121, 23);
            CB_Lado.TabIndex = 18;
            CB_Lado.SelectedIndexChanged += CB_Lado_SelectedIndexChanged;
            // 
            // LB_Porcentagem
            // 
            LB_Porcentagem.AutoSize = true;
            LB_Porcentagem.BackColor = Color.Transparent;
            LB_Porcentagem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Porcentagem.ForeColor = Color.Black;
            LB_Porcentagem.Location = new Point(12, 158);
            LB_Porcentagem.Name = "LB_Porcentagem";
            LB_Porcentagem.Size = new Size(70, 13);
            LB_Porcentagem.TabIndex = 19;
            LB_Porcentagem.Text = "Porcentagem";
            LB_Porcentagem.Visible = false;
            // 
            // NUD_Porcentagem
            // 
            NUD_Porcentagem.Cursor = Cursors.SizeAll;
            NUD_Porcentagem.DecimalPlaces = 5;
            NUD_Porcentagem.Location = new Point(12, 173);
            NUD_Porcentagem.Maximum = new decimal(new int[] { 10000000, 0, 0, 196608 });
            NUD_Porcentagem.Name = "NUD_Porcentagem";
            NUD_Porcentagem.Size = new Size(107, 23);
            NUD_Porcentagem.TabIndex = 20;
            NUD_Porcentagem.TextAlign = HorizontalAlignment.Center;
            NUD_Porcentagem.UpDownAlign = LeftRightAlignment.Left;
            NUD_Porcentagem.Visible = false;
            // 
            // CB_PorcentagemOuQuantidade
            // 
            CB_PorcentagemOuQuantidade.FormattingEnabled = true;
            CB_PorcentagemOuQuantidade.Items.AddRange(new object[] { "Quantidade", "Porcentagem" });
            CB_PorcentagemOuQuantidade.Location = new Point(304, 48);
            CB_PorcentagemOuQuantidade.Name = "CB_PorcentagemOuQuantidade";
            CB_PorcentagemOuQuantidade.Size = new Size(121, 23);
            CB_PorcentagemOuQuantidade.TabIndex = 22;
            CB_PorcentagemOuQuantidade.SelectedIndexChanged += CB_PorcentagemOuQuantidade_SelectedIndexChanged;
            // 
            // LB_TipoOrdem
            // 
            LB_TipoOrdem.AutoSize = true;
            LB_TipoOrdem.ForeColor = Color.Black;
            LB_TipoOrdem.Location = new Point(9, 48);
            LB_TipoOrdem.Name = "LB_TipoOrdem";
            LB_TipoOrdem.Size = new Size(86, 15);
            LB_TipoOrdem.TabIndex = 25;
            LB_TipoOrdem.Text = "Tipo de Ordem";
            // 
            // LB_Pares
            // 
            LB_Pares.AutoSize = true;
            LB_Pares.BackColor = Color.Transparent;
            LB_Pares.ForeColor = Color.Black;
            LB_Pares.Location = new Point(248, 91);
            LB_Pares.Name = "LB_Pares";
            LB_Pares.Size = new Size(35, 15);
            LB_Pares.TabIndex = 26;
            LB_Pares.Text = "Pares";
            // 
            // LB_Lado
            // 
            LB_Lado.AutoSize = true;
            LB_Lado.ForeColor = Color.Black;
            LB_Lado.Location = new Point(9, 89);
            LB_Lado.Name = "LB_Lado";
            LB_Lado.Size = new Size(89, 15);
            LB_Lado.TabIndex = 27;
            LB_Lado.Text = "Lado da Ordem";
            // 
            // RBTN_VerPendentes
            // 
            RBTN_VerPendentes.AutoSize = true;
            RBTN_VerPendentes.ForeColor = Color.Black;
            RBTN_VerPendentes.Location = new Point(271, 12);
            RBTN_VerPendentes.Name = "RBTN_VerPendentes";
            RBTN_VerPendentes.Size = new Size(158, 19);
            RBTN_VerPendentes.TabIndex = 28;
            RBTN_VerPendentes.Text = "Ver Contas não realizadas";
            RBTN_VerPendentes.UseVisualStyleBackColor = true;
            RBTN_VerPendentes.Visible = false;
            RBTN_VerPendentes.CheckedChanged += RBTN_VerPendentes_CheckedChanged;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWorkAsync;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // LB_OperarSobre
            // 
            LB_OperarSobre.AutoSize = true;
            LB_OperarSobre.BackColor = Color.Transparent;
            LB_OperarSobre.ForeColor = Color.Black;
            LB_OperarSobre.Location = new Point(248, 48);
            LB_OperarSobre.Name = "LB_OperarSobre";
            LB_OperarSobre.Size = new Size(46, 30);
            LB_OperarSobre.TabIndex = 29;
            LB_OperarSobre.Text = "Operar \r\nSobre";
            // 
            // Clientes_dataGridView
            // 
            Clientes_dataGridView.AllowUserToAddRows = false;
            Clientes_dataGridView.AllowUserToDeleteRows = false;
            Clientes_dataGridView.AllowUserToResizeColumns = false;
            Clientes_dataGridView.AllowUserToResizeRows = false;
            Clientes_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Clientes_dataGridView.BackgroundColor = Color.White;
            Clientes_dataGridView.BorderStyle = BorderStyle.None;
            Clientes_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            Clientes_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Clientes_dataGridView.ColumnHeadersVisible = false;
            Clientes_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Select, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            Clientes_dataGridView.GridColor = Color.Black;
            Clientes_dataGridView.Location = new Point(351, 158);
            Clientes_dataGridView.Margin = new Padding(3, 2, 3, 2);
            Clientes_dataGridView.MultiSelect = false;
            Clientes_dataGridView.Name = "Clientes_dataGridView";
            Clientes_dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            Clientes_dataGridView.RowHeadersVisible = false;
            Clientes_dataGridView.RowHeadersWidth = 51;
            Clientes_dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Clientes_dataGridView.RowTemplate.Height = 29;
            Clientes_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Clientes_dataGridView.ShowCellErrors = false;
            Clientes_dataGridView.ShowCellToolTips = false;
            Clientes_dataGridView.ShowEditingIcon = false;
            Clientes_dataGridView.ShowRowErrors = false;
            Clientes_dataGridView.Size = new Size(256, 508);
            Clientes_dataGridView.TabIndex = 30;
            Clientes_dataGridView.Visible = false;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Select.HeaderText = "Selecionar";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Resizable = DataGridViewTriState.False;
            Select.Width = 6;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Nome";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn13.HeaderText = "Nome";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "ClienteId";
            dataGridViewTextBoxColumn14.HeaderText = "ClienteId";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Visible = false;
            dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "GoogleSheetsId";
            dataGridViewTextBoxColumn15.HeaderText = "GoogleSheetsId";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Visible = false;
            dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "CBinanceId";
            dataGridViewTextBoxColumn16.HeaderText = "CBinanceId";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Visible = false;
            dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "Conta";
            dataGridViewTextBoxColumn17.HeaderText = "Conta";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Visible = false;
            dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "Sheets";
            dataGridViewTextBoxColumn18.HeaderText = "Sheets";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Visible = false;
            dataGridViewTextBoxColumn18.Width = 125;
            // 
            // RealizarOrdens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(606, 735);
            Controls.Add(Clientes_dataGridView);
            Controls.Add(CB_PorcentagemOuQuantidade);
            Controls.Add(LB_OperarSobre);
            Controls.Add(RBTN_VerPendentes);
            Controls.Add(LB_Lado);
            Controls.Add(LB_Pares);
            Controls.Add(LB_TipoOrdem);
            Controls.Add(CB_Lado);
            Controls.Add(LB_Stop);
            Controls.Add(LB_Preco);
            Controls.Add(LB_Quantidade);
            Controls.Add(NUD_Preco);
            Controls.Add(NUD_Stop);
            Controls.Add(CB_Pares);
            Controls.Add(NUD_Quantidade);
            Controls.Add(CB_TipoOrdem);
            Controls.Add(RDBTN_TodosAsContas);
            Controls.Add(BTN_RealizarOrdem);
            Controls.Add(RDBTN_SelecionarContas);
            Controls.Add(LB_Porcentagem);
            Controls.Add(NUD_Porcentagem);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RealizarOrdens";
            Text = "RealizarOrdens";
            Load += RealizarOrdens_Load;
            ((System.ComponentModel.ISupportInitialize)NUD_Quantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Stop).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Preco).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Porcentagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton RDBTN_TodosAsContas;
        private RadioButton RDBTN_SelecionarContas;
        private Button BTN_RealizarOrdem;
        private ComboBox CB_TipoOrdem;
        private NumericUpDown NUD_Quantidade;
        private NumericUpDown NUD_Stop;
        private NumericUpDown NUD_Preco;
        private Label LB_Quantidade;
        private Label LB_Preco;
        private Label LB_Stop;
        private ComboBox CB_Lado;
        private Label LB_Porcentagem;
        private NumericUpDown NUD_Porcentagem;
        private ComboBox CB_PorcentagemOuQuantidade;
        private Label LB_TipoOrdem;
        private Label LB_Pares;
        private Label LB_Lado;
        private RadioButton RBTN_VerPendentes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public ComboBox CB_Pares;
        private Label LB_OperarSobre;
        private DataGridView Clientes_dataGridView;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}