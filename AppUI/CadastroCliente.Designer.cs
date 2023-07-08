namespace AppUI
{
    partial class CadastroCliente
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
            TBX_Nome = new TextBox();
            LB_Nome = new Label();
            TBX_NomeDaTabela = new TextBox();
            LB_NomeDaTabela = new Label();
            LB_NomeDaFolha = new Label();
            TBX_NomeDaFolha = new TextBox();
            LB_ApiKey = new Label();
            TBX_ApiKey = new TextBox();
            LB_ApiSecret = new Label();
            TBX_ApiSecret = new TextBox();
            BTN_Cadastrar = new Button();
            SuspendLayout();
            // 
            // TBX_Nome
            // 
            TBX_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TBX_Nome.BackColor = Color.White;
            TBX_Nome.BorderStyle = BorderStyle.FixedSingle;
            TBX_Nome.Location = new Point(14, 76);
            TBX_Nome.Margin = new Padding(3, 4, 3, 4);
            TBX_Nome.Name = "TBX_Nome";
            TBX_Nome.Size = new Size(546, 27);
            TBX_Nome.TabIndex = 0;
            // 
            // LB_Nome
            // 
            LB_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Nome.AutoSize = true;
            LB_Nome.ForeColor = Color.Black;
            LB_Nome.Location = new Point(14, 52);
            LB_Nome.Name = "LB_Nome";
            LB_Nome.Size = new Size(50, 20);
            LB_Nome.TabIndex = 1;
            LB_Nome.Text = "Nome";
            // 
            // TBX_NomeDaTabela
            // 
            TBX_NomeDaTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TBX_NomeDaTabela.BackColor = Color.White;
            TBX_NomeDaTabela.BorderStyle = BorderStyle.FixedSingle;
            TBX_NomeDaTabela.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TBX_NomeDaTabela.Location = new Point(14, 148);
            TBX_NomeDaTabela.Margin = new Padding(3, 4, 3, 4);
            TBX_NomeDaTabela.Name = "TBX_NomeDaTabela";
            TBX_NomeDaTabela.Size = new Size(546, 27);
            TBX_NomeDaTabela.TabIndex = 2;
            // 
            // LB_NomeDaTabela
            // 
            LB_NomeDaTabela.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_NomeDaTabela.AutoSize = true;
            LB_NomeDaTabela.ForeColor = Color.Black;
            LB_NomeDaTabela.Location = new Point(14, 124);
            LB_NomeDaTabela.Name = "LB_NomeDaTabela";
            LB_NomeDaTabela.Size = new Size(120, 20);
            LB_NomeDaTabela.TabIndex = 3;
            LB_NomeDaTabela.Text = "Nome Da Tabela";
            // 
            // LB_NomeDaFolha
            // 
            LB_NomeDaFolha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_NomeDaFolha.AutoSize = true;
            LB_NomeDaFolha.ForeColor = Color.Black;
            LB_NomeDaFolha.Location = new Point(14, 195);
            LB_NomeDaFolha.Name = "LB_NomeDaFolha";
            LB_NomeDaFolha.Size = new Size(111, 20);
            LB_NomeDaFolha.TabIndex = 4;
            LB_NomeDaFolha.Text = "Nome da Folha";
            // 
            // TBX_NomeDaFolha
            // 
            TBX_NomeDaFolha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TBX_NomeDaFolha.BackColor = Color.White;
            TBX_NomeDaFolha.BorderStyle = BorderStyle.FixedSingle;
            TBX_NomeDaFolha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TBX_NomeDaFolha.Location = new Point(14, 219);
            TBX_NomeDaFolha.Margin = new Padding(3, 4, 3, 4);
            TBX_NomeDaFolha.Name = "TBX_NomeDaFolha";
            TBX_NomeDaFolha.Size = new Size(546, 27);
            TBX_NomeDaFolha.TabIndex = 5;
            // 
            // LB_ApiKey
            // 
            LB_ApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_ApiKey.AutoSize = true;
            LB_ApiKey.ForeColor = Color.Black;
            LB_ApiKey.Location = new Point(14, 265);
            LB_ApiKey.Name = "LB_ApiKey";
            LB_ApiKey.Size = new Size(60, 20);
            LB_ApiKey.TabIndex = 6;
            LB_ApiKey.Text = "Api Key";
            // 
            // TBX_ApiKey
            // 
            TBX_ApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TBX_ApiKey.BackColor = Color.White;
            TBX_ApiKey.BorderStyle = BorderStyle.FixedSingle;
            TBX_ApiKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TBX_ApiKey.Location = new Point(14, 289);
            TBX_ApiKey.Margin = new Padding(3, 4, 3, 4);
            TBX_ApiKey.Name = "TBX_ApiKey";
            TBX_ApiKey.Size = new Size(546, 27);
            TBX_ApiKey.TabIndex = 7;
            // 
            // LB_ApiSecret
            // 
            LB_ApiSecret.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_ApiSecret.AutoSize = true;
            LB_ApiSecret.ForeColor = Color.Black;
            LB_ApiSecret.Location = new Point(14, 337);
            LB_ApiSecret.Name = "LB_ApiSecret";
            LB_ApiSecret.Size = new Size(77, 20);
            LB_ApiSecret.TabIndex = 8;
            LB_ApiSecret.Text = "Api Secret";
            // 
            // TBX_ApiSecret
            // 
            TBX_ApiSecret.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TBX_ApiSecret.BackColor = Color.White;
            TBX_ApiSecret.BorderStyle = BorderStyle.FixedSingle;
            TBX_ApiSecret.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TBX_ApiSecret.Location = new Point(14, 361);
            TBX_ApiSecret.Margin = new Padding(3, 4, 3, 4);
            TBX_ApiSecret.Name = "TBX_ApiSecret";
            TBX_ApiSecret.Size = new Size(546, 27);
            TBX_ApiSecret.TabIndex = 9;
            // 
            // BTN_Cadastrar
            // 
            BTN_Cadastrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Cadastrar.FlatStyle = FlatStyle.Flat;
            BTN_Cadastrar.ForeColor = Color.Black;
            BTN_Cadastrar.Location = new Point(207, 415);
            BTN_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cadastrar.Name = "BTN_Cadastrar";
            BTN_Cadastrar.Size = new Size(139, 52);
            BTN_Cadastrar.TabIndex = 11;
            BTN_Cadastrar.Text = "Cadastrar";
            BTN_Cadastrar.UseVisualStyleBackColor = true;
            BTN_Cadastrar.Click += BTN_Cadastrar_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(570, 480);
            ControlBox = false;
            Controls.Add(BTN_Cadastrar);
            Controls.Add(TBX_ApiSecret);
            Controls.Add(LB_ApiSecret);
            Controls.Add(TBX_ApiKey);
            Controls.Add(LB_ApiKey);
            Controls.Add(TBX_NomeDaFolha);
            Controls.Add(LB_NomeDaFolha);
            Controls.Add(LB_NomeDaTabela);
            Controls.Add(TBX_NomeDaTabela);
            Controls.Add(LB_Nome);
            Controls.Add(TBX_Nome);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CadastroCliente";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBX_Nome;
        private Label LB_Nome;
        private TextBox TBX_NomeDaTabela;
        private Label LB_NomeDaTabela;
        private Label LB_NomeDaFolha;
        private TextBox TBX_NomeDaFolha;
        private Label LB_ApiKey;
        private TextBox TBX_ApiKey;
        private Label LB_ApiSecret;
        private TextBox TBX_ApiSecret;
        private Button BTN_Cadastrar;
    }
}