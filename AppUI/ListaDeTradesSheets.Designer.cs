namespace AppUI
{
    partial class ListaDeTradesSheets
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
            BTN_EnviarSelecionados = new Button();
            Clientes_dataGridView = new DataGridView();
            Selecionado = new DataGridViewCheckBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            ClienteId = new DataGridViewTextBoxColumn();
            GoogleSheetsId = new DataGridViewTextBoxColumn();
            TabName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            QuoteQty = new DataGridViewTextBoxColumn();
            Comission = new DataGridViewTextBoxColumn();
            ComissionAsset = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            LB_FolhaDaConta = new Label();
            LB_NomeDaFolha = new Label();
            BTN_EnviarTodos = new Button();
            backgroundWorkerTodos = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            backgroundWorkerSelecionados = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // BTN_EnviarSelecionados
            // 
            BTN_EnviarSelecionados.BackColor = Color.Transparent;
            BTN_EnviarSelecionados.FlatStyle = FlatStyle.Flat;
            BTN_EnviarSelecionados.ForeColor = Color.Black;
            BTN_EnviarSelecionados.Location = new Point(11, 551);
            BTN_EnviarSelecionados.Margin = new Padding(3, 4, 3, 4);
            BTN_EnviarSelecionados.Name = "BTN_EnviarSelecionados";
            BTN_EnviarSelecionados.Size = new Size(151, 41);
            BTN_EnviarSelecionados.TabIndex = 0;
            BTN_EnviarSelecionados.Text = "Enviar Selecionados";
            BTN_EnviarSelecionados.UseVisualStyleBackColor = false;
            BTN_EnviarSelecionados.Click += BTN_EnviarSelecionados_Click;
            // 
            // Clientes_dataGridView
            // 
            Clientes_dataGridView.AllowUserToAddRows = false;
            Clientes_dataGridView.AllowUserToDeleteRows = false;
            Clientes_dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Clientes_dataGridView.BackgroundColor = Color.White;
            Clientes_dataGridView.BorderStyle = BorderStyle.None;
            Clientes_dataGridView.ColumnHeadersHeight = 29;
            Clientes_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Selecionado, Nome, ClienteId, GoogleSheetsId, TabName, Price, Qty, QuoteQty, Comission, ComissionAsset, Time });
            Clientes_dataGridView.GridColor = Color.White;
            Clientes_dataGridView.Location = new Point(1, 12);
            Clientes_dataGridView.Margin = new Padding(3, 4, 3, 4);
            Clientes_dataGridView.Name = "Clientes_dataGridView";
            Clientes_dataGridView.RowHeadersVisible = false;
            Clientes_dataGridView.RowHeadersWidth = 51;
            Clientes_dataGridView.RowTemplate.Height = 25;
            Clientes_dataGridView.Size = new Size(1098, 451);
            Clientes_dataGridView.TabIndex = 1;
            // 
            // Selecionado
            // 
            Selecionado.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Selecionado.HeaderText = "Selecionado";
            Selecionado.MinimumWidth = 6;
            Selecionado.Name = "Selecionado";
            Selecionado.Resizable = DataGridViewTriState.True;
            Selecionado.Width = 97;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "TradeId";
            Nome.HeaderText = "TradeId";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // ClienteId
            // 
            ClienteId.DataPropertyName = "symbol";
            ClienteId.HeaderText = "Symbol";
            ClienteId.MinimumWidth = 6;
            ClienteId.Name = "ClienteId";
            ClienteId.Visible = false;
            ClienteId.Width = 125;
            // 
            // GoogleSheetsId
            // 
            GoogleSheetsId.DataPropertyName = "id";
            GoogleSheetsId.HeaderText = "Id";
            GoogleSheetsId.MinimumWidth = 6;
            GoogleSheetsId.Name = "GoogleSheetsId";
            GoogleSheetsId.Resizable = DataGridViewTriState.True;
            GoogleSheetsId.Visible = false;
            GoogleSheetsId.Width = 125;
            // 
            // TabName
            // 
            TabName.DataPropertyName = "orderId";
            TabName.HeaderText = "Order Id";
            TabName.MinimumWidth = 6;
            TabName.Name = "TabName";
            TabName.Width = 125;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.DataPropertyName = "price";
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Qty
            // 
            Qty.DataPropertyName = "qty";
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 6;
            Qty.Name = "Qty";
            Qty.Width = 125;
            // 
            // QuoteQty
            // 
            QuoteQty.DataPropertyName = "quoteQty";
            QuoteQty.HeaderText = "QuoteQty";
            QuoteQty.MinimumWidth = 6;
            QuoteQty.Name = "QuoteQty";
            QuoteQty.Width = 125;
            // 
            // Comission
            // 
            Comission.DataPropertyName = "comission";
            Comission.HeaderText = "Comission";
            Comission.MinimumWidth = 6;
            Comission.Name = "Comission";
            Comission.Width = 125;
            // 
            // ComissionAsset
            // 
            ComissionAsset.DataPropertyName = "comissionAsset";
            ComissionAsset.HeaderText = "ComissionAsset";
            ComissionAsset.MinimumWidth = 6;
            ComissionAsset.Name = "ComissionAsset";
            ComissionAsset.Width = 125;
            // 
            // Time
            // 
            Time.DataPropertyName = "time";
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // LB_FolhaDaConta
            // 
            LB_FolhaDaConta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LB_FolhaDaConta.AutoSize = true;
            LB_FolhaDaConta.ForeColor = Color.Black;
            LB_FolhaDaConta.Location = new Point(11, 504);
            LB_FolhaDaConta.Name = "LB_FolhaDaConta";
            LB_FolhaDaConta.Size = new Size(109, 20);
            LB_FolhaDaConta.TabIndex = 2;
            LB_FolhaDaConta.Text = "Folha da Conta";
            // 
            // LB_NomeDaFolha
            // 
            LB_NomeDaFolha.AutoSize = true;
            LB_NomeDaFolha.Location = new Point(214, 449);
            LB_NomeDaFolha.Name = "LB_NomeDaFolha";
            LB_NomeDaFolha.Size = new Size(0, 20);
            LB_NomeDaFolha.TabIndex = 3;
            // 
            // BTN_EnviarTodos
            // 
            BTN_EnviarTodos.BackColor = Color.Transparent;
            BTN_EnviarTodos.FlatStyle = FlatStyle.Flat;
            BTN_EnviarTodos.ForeColor = Color.Black;
            BTN_EnviarTodos.Location = new Point(11, 600);
            BTN_EnviarTodos.Margin = new Padding(3, 4, 3, 4);
            BTN_EnviarTodos.Name = "BTN_EnviarTodos";
            BTN_EnviarTodos.Size = new Size(151, 33);
            BTN_EnviarTodos.TabIndex = 4;
            BTN_EnviarTodos.Text = "Enviar Todos";
            BTN_EnviarTodos.UseMnemonic = false;
            BTN_EnviarTodos.UseVisualStyleBackColor = false;
            BTN_EnviarTodos.Click += BTN_EnviarTodos_Click;
            // 
            // backgroundWorkerTodos
            // 
            backgroundWorkerTodos.WorkerReportsProgress = true;
            backgroundWorkerTodos.DoWork += backgroundWorkerTodos_DoWork;
            backgroundWorkerTodos.ProgressChanged += backgroundWorkerTodos_ProgressChanged;
            backgroundWorkerTodos.RunWorkerCompleted += backgroundWorkerTodos_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1, 469);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1181, 31);
            progressBar1.TabIndex = 5;
            progressBar1.Visible = false;
            // 
            // backgroundWorkerSelecionados
            // 
            backgroundWorkerSelecionados.WorkerReportsProgress = true;
            backgroundWorkerSelecionados.DoWork += backgroundWorkerSelecionados_DoWork;
            // 
            // ListaDeTradesSheets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1233, 649);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(BTN_EnviarTodos);
            Controls.Add(LB_NomeDaFolha);
            Controls.Add(LB_FolhaDaConta);
            Controls.Add(Clientes_dataGridView);
            Controls.Add(BTN_EnviarSelecionados);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListaDeTradesSheets";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeTrades";
            TopMost = true;
            Load += ListaDeTrades_Load;
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTN_EnviarSelecionados;
        private DataGridView Clientes_dataGridView;
        private Label LB_FolhaDaConta;
        private Label LB_NomeDaFolha;
        private Button BTN_EnviarTodos;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTodos;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelecionados;
        private DataGridViewCheckBoxColumn Selecionado;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ClienteId;
        private DataGridViewTextBoxColumn GoogleSheetsId;
        private DataGridViewTextBoxColumn TabName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn QuoteQty;
        private DataGridViewTextBoxColumn Comission;
        private DataGridViewTextBoxColumn ComissionAsset;
        private DataGridViewTextBoxColumn Time;
    }
}