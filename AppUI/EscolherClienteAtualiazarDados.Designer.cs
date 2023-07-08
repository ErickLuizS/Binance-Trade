namespace AppUI
{
    partial class EscolherClienteAtualiazarDados
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
            Clientes_dataGridView = new DataGridView();
            Editar = new DataGridViewButtonColumn();
            Nome = new DataGridViewTextBoxColumn();
            ClienteId = new DataGridViewTextBoxColumn();
            GoogleSheetsId = new DataGridViewTextBoxColumn();
            CBinanceId = new DataGridViewTextBoxColumn();
            Conta = new DataGridViewTextBoxColumn();
            Sheets = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).BeginInit();
            SuspendLayout();
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
            Clientes_dataGridView.Columns.AddRange(new DataGridViewColumn[] { Editar, Nome, ClienteId, GoogleSheetsId, CBinanceId, Conta, Sheets });
            Clientes_dataGridView.Dock = DockStyle.Fill;
            Clientes_dataGridView.GridColor = Color.Black;
            Clientes_dataGridView.Location = new Point(0, 0);
            Clientes_dataGridView.MultiSelect = false;
            Clientes_dataGridView.Name = "Clientes_dataGridView";
            Clientes_dataGridView.ReadOnly = true;
            Clientes_dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            Clientes_dataGridView.RowHeadersVisible = false;
            Clientes_dataGridView.RowHeadersWidth = 51;
            Clientes_dataGridView.RowTemplate.Height = 29;
            Clientes_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Clientes_dataGridView.ShowCellErrors = false;
            Clientes_dataGridView.ShowCellToolTips = false;
            Clientes_dataGridView.ShowEditingIcon = false;
            Clientes_dataGridView.ShowRowErrors = false;
            Clientes_dataGridView.Size = new Size(1476, 791);
            Clientes_dataGridView.TabIndex = 0;
            Clientes_dataGridView.CellContentClick += Clientes_dataGridView_CellContentClick;
            // 
            // Editar
            // 
            Editar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Editar.DefaultCellStyle = dataGridViewCellStyle1;
            Editar.FlatStyle = FlatStyle.Popup;
            Editar.HeaderText = "Editar";
            Editar.MinimumWidth = 6;
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Resizable = DataGridViewTriState.False;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            Editar.Width = 6;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Nome.DefaultCellStyle = dataGridViewCellStyle2;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // ClienteId
            // 
            ClienteId.DataPropertyName = "ClienteId";
            ClienteId.HeaderText = "ClienteId";
            ClienteId.MinimumWidth = 6;
            ClienteId.Name = "ClienteId";
            ClienteId.ReadOnly = true;
            ClienteId.Visible = false;
            ClienteId.Width = 125;
            // 
            // GoogleSheetsId
            // 
            GoogleSheetsId.DataPropertyName = "GoogleSheetsId";
            GoogleSheetsId.HeaderText = "GoogleSheetsId";
            GoogleSheetsId.MinimumWidth = 6;
            GoogleSheetsId.Name = "GoogleSheetsId";
            GoogleSheetsId.ReadOnly = true;
            GoogleSheetsId.Visible = false;
            GoogleSheetsId.Width = 125;
            // 
            // CBinanceId
            // 
            CBinanceId.DataPropertyName = "CBinanceId";
            CBinanceId.HeaderText = "CBinanceId";
            CBinanceId.MinimumWidth = 6;
            CBinanceId.Name = "CBinanceId";
            CBinanceId.ReadOnly = true;
            CBinanceId.Visible = false;
            CBinanceId.Width = 125;
            // 
            // Conta
            // 
            Conta.DataPropertyName = "Conta";
            Conta.HeaderText = "Conta";
            Conta.MinimumWidth = 6;
            Conta.Name = "Conta";
            Conta.ReadOnly = true;
            Conta.Visible = false;
            Conta.Width = 125;
            // 
            // Sheets
            // 
            Sheets.DataPropertyName = "Sheets";
            Sheets.HeaderText = "Sheets";
            Sheets.MinimumWidth = 6;
            Sheets.Name = "Sheets";
            Sheets.ReadOnly = true;
            Sheets.Visible = false;
            Sheets.Width = 125;
            // 
            // EscolherClienteAtualiazarDados2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1476, 791);
            Controls.Add(Clientes_dataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EscolherClienteAtualiazarDados2";
            Text = "EscolherClienteAtualiazarDados2";
            Load += EscolherClienteAtualiazarDados_Load;
            ((System.ComponentModel.ISupportInitialize)Clientes_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Clientes_dataGridView;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn ClienteId;
        private DataGridViewTextBoxColumn GoogleSheetsId;
        private DataGridViewTextBoxColumn CBinanceId;
        private DataGridViewTextBoxColumn Conta;
        private DataGridViewTextBoxColumn Sheets;
    }
}