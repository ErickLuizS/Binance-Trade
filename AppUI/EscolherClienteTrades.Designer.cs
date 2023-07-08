namespace AppUI
{
    partial class EscolherClienteTrades
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            CB_Pares = new ComboBox();
            label1 = new Label();
            Selecionar = new DataGridViewButtonColumn();
            Nome = new DataGridViewTextBoxColumn();
            ClienteId = new DataGridViewTextBoxColumn();
            GoogleSheetsId = new DataGridViewTextBoxColumn();
            CBinanceId = new DataGridViewTextBoxColumn();
            Conta = new DataGridViewTextBoxColumn();
            Sheets = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            Clientes_dataGridView = new DataGridView();
            Select = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // CB_Pares
            // 
            CB_Pares.FlatStyle = FlatStyle.System;
            CB_Pares.FormattingEnabled = true;
            CB_Pares.Items.AddRange(new object[] { "BTC/USDT", "BTC/BUSD", "ETH/USDT", "BUSD/USDT", "ETH/BUSD", "OP/USDT", "ETH/BTC", "BNX/USDT", "XRP/USDT", "FIL/USDT", "BNB/USDT", "MATIC/USDT", "SOL/USDT", "CFX/USDT", "CFX/USDT", "OP/BUSD", "USDT/TRY", "BTC/EUR" });
            CB_Pares.Location = new Point(14, 53);
            CB_Pares.Margin = new Padding(3, 4, 3, 4);
            CB_Pares.Name = "CB_Pares";
            CB_Pares.Size = new Size(138, 28);
            CB_Pares.TabIndex = 3;
            CB_Pares.SelectedIndexChanged += CB_Pares_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 4;
            label1.Text = "Par";
            // 
            // Selecionar
            // 
            Selecionar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Selecionar.DataPropertyName = "\u007f";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Selecionar.DefaultCellStyle = dataGridViewCellStyle1;
            Selecionar.FlatStyle = FlatStyle.Flat;
            Selecionar.Frozen = true;
            Selecionar.HeaderText = "Selecionar";
            Selecionar.MinimumWidth = 6;
            Selecionar.Name = "Selecionar";
            Selecionar.Resizable = DataGridViewTriState.False;
            Selecionar.Text = "Selecionar";
            Selecionar.UseColumnTextForButtonValue = true;
            Selecionar.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Nome.DefaultCellStyle = dataGridViewCellStyle2;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // ClienteId
            // 
            ClienteId.DataPropertyName = "ClienteId";
            ClienteId.HeaderText = "ClienteId";
            ClienteId.MinimumWidth = 6;
            ClienteId.Name = "ClienteId";
            ClienteId.Visible = false;
            ClienteId.Width = 125;
            // 
            // GoogleSheetsId
            // 
            GoogleSheetsId.DataPropertyName = "GoogleSheetsId";
            GoogleSheetsId.HeaderText = "GoogleSheetsId";
            GoogleSheetsId.MinimumWidth = 6;
            GoogleSheetsId.Name = "GoogleSheetsId";
            GoogleSheetsId.Visible = false;
            GoogleSheetsId.Width = 125;
            // 
            // CBinanceId
            // 
            CBinanceId.DataPropertyName = "CBinanceId";
            CBinanceId.HeaderText = "CBinanceId";
            CBinanceId.MinimumWidth = 6;
            CBinanceId.Name = "CBinanceId";
            CBinanceId.Visible = false;
            CBinanceId.Width = 125;
            // 
            // Conta
            // 
            Conta.DataPropertyName = "Conta";
            Conta.HeaderText = "Conta";
            Conta.MinimumWidth = 6;
            Conta.Name = "Conta";
            Conta.Visible = false;
            Conta.Width = 125;
            // 
            // Sheets
            // 
            Sheets.DataPropertyName = "Sheets";
            Sheets.HeaderText = "Sheets";
            Sheets.MinimumWidth = 6;
            Sheets.Name = "Sheets";
            Sheets.Visible = false;
            Sheets.Width = 125;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            Editar.DefaultCellStyle = dataGridViewCellStyle3;
            Editar.FlatStyle = FlatStyle.System;
            Editar.HeaderText = "Selecionar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.Text = "Selecionar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ClienteId";
            dataGridViewTextBoxColumn2.HeaderText = "ClienteId";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Visible = false;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "GoogleSheetsId";
            dataGridViewTextBoxColumn3.HeaderText = "GoogleSheetsId";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Visible = false;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "CBinanceId";
            dataGridViewTextBoxColumn4.HeaderText = "CBinanceId";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Conta";
            dataGridViewTextBoxColumn5.HeaderText = "Conta";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Visible = false;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Sheets";
            dataGridViewTextBoxColumn6.HeaderText = "Sheets";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Visible = false;
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewButtonColumn1.HeaderText = "Selecionar";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "Selecionar";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn7.HeaderText = "Nome";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "ClienteId";
            dataGridViewTextBoxColumn8.HeaderText = "ClienteId";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Visible = false;
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "GoogleSheetsId";
            dataGridViewTextBoxColumn9.HeaderText = "GoogleSheetsId";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Visible = false;
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "CBinanceId";
            dataGridViewTextBoxColumn10.HeaderText = "CBinanceId";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Visible = false;
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Conta";
            dataGridViewTextBoxColumn11.HeaderText = "Conta";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Visible = false;
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Sheets";
            dataGridViewTextBoxColumn12.HeaderText = "Sheets";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Visible = false;
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // Clientes_dataGridView
            // 
            Clientes_dataGridView.AllowUserToAddRows = false;
            Clientes_dataGridView.AllowUserToDeleteRows = false;
            Clientes_dataGridView.AllowUserToResizeColumns = false;
            Clientes_dataGridView.AllowUserToResizeRows = false;
            Clientes_dataGridView.BackgroundColor = Color.White;
            Clientes_dataGridView.BorderStyle = BorderStyle.None;
            Clientes_dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            Clientes_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Clientes_dataGridView.ColumnHeadersVisible = false;
            Clientes_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Select, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18 });
            Clientes_dataGridView.GridColor = Color.Black;
            Clientes_dataGridView.Location = new Point(14, 88);
            Clientes_dataGridView.MultiSelect = false;
            Clientes_dataGridView.Name = "Clientes_dataGridView";
            Clientes_dataGridView.ReadOnly = true;
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
            Clientes_dataGridView.Size = new Size(467, 701);
            Clientes_dataGridView.TabIndex = 5;
            Clientes_dataGridView.CellClick += Clientes_dataGridView_CellContentClick;
            Clientes_dataGridView.CellContentClick += Clientes_dataGridView_CellContentClick;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            Select.DefaultCellStyle = dataGridViewCellStyle7;
            Select.FlatStyle = FlatStyle.Popup;
            Select.HeaderText = "Selecionar";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Resizable = DataGridViewTriState.False;
            Select.Text = "Selecionar";
            Select.UseColumnTextForButtonValue = true;
            Select.Width = 6;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "Nome";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewTextBoxColumn13.HeaderText = "Nome";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
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
            // EscolherClienteTrades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(563, 793);
            Controls.Add(Clientes_dataGridView);
            Controls.Add(label1);
            Controls.Add(CB_Pares);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "EscolherClienteTrades";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EscolherClienteTrades";
            Load += EscolherClienteTrades_Load;
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ComboBox CB_Pares;
        private Label label1;
        private DataGridViewButtonColumn Selecionar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ClienteId;
        private DataGridViewTextBoxColumn GoogleSheetsId;
        private DataGridViewTextBoxColumn CBinanceId;
        private DataGridViewTextBoxColumn Conta;
        private DataGridViewTextBoxColumn Sheets;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridView Clientes_dataGridView;
        private DataGridViewButtonColumn Select;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}