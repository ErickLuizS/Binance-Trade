namespace AppUI
{
    partial class AtualizarDados
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
            LB_Nome = new Label();
            LB_ApiKey = new Label();
            LB_ApiSecret = new Label();
            LB_SheetID = new Label();
            LB_NomeDaFolha = new Label();
            TB_Nome = new TextBox();
            TB_ApiKey = new TextBox();
            TB_ApiSecret = new TextBox();
            TB_SheetID = new TextBox();
            TB_NomeDaFolha = new TextBox();
            BTN_Editar = new Button();
            BTN_Excluir = new Button();
            SuspendLayout();
            // 
            // LB_Nome
            // 
            LB_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LB_Nome.AutoSize = true;
            LB_Nome.BackColor = Color.Transparent;
            LB_Nome.ForeColor = Color.Black;
            LB_Nome.Location = new Point(22, 8);
            LB_Nome.Name = "LB_Nome";
            LB_Nome.Size = new Size(50, 20);
            LB_Nome.TabIndex = 0;
            LB_Nome.Text = "Nome";
            // 
            // LB_ApiKey
            // 
            LB_ApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LB_ApiKey.AutoSize = true;
            LB_ApiKey.ForeColor = Color.Black;
            LB_ApiKey.Location = new Point(20, 92);
            LB_ApiKey.Name = "LB_ApiKey";
            LB_ApiKey.Size = new Size(60, 20);
            LB_ApiKey.TabIndex = 1;
            LB_ApiKey.Text = "Api Key";
            // 
            // LB_ApiSecret
            // 
            LB_ApiSecret.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LB_ApiSecret.AutoSize = true;
            LB_ApiSecret.ForeColor = Color.Black;
            LB_ApiSecret.Location = new Point(20, 190);
            LB_ApiSecret.Name = "LB_ApiSecret";
            LB_ApiSecret.Size = new Size(77, 20);
            LB_ApiSecret.TabIndex = 2;
            LB_ApiSecret.Text = "Api Secret";
            // 
            // LB_SheetID
            // 
            LB_SheetID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LB_SheetID.AutoSize = true;
            LB_SheetID.ForeColor = Color.Black;
            LB_SheetID.Location = new Point(20, 287);
            LB_SheetID.Name = "LB_SheetID";
            LB_SheetID.Size = new Size(65, 20);
            LB_SheetID.TabIndex = 3;
            LB_SheetID.Text = "Sheet ID";
            // 
            // LB_NomeDaFolha
            // 
            LB_NomeDaFolha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LB_NomeDaFolha.AutoSize = true;
            LB_NomeDaFolha.ForeColor = Color.Black;
            LB_NomeDaFolha.Location = new Point(20, 372);
            LB_NomeDaFolha.Name = "LB_NomeDaFolha";
            LB_NomeDaFolha.Size = new Size(111, 20);
            LB_NomeDaFolha.TabIndex = 4;
            LB_NomeDaFolha.Text = "Nome da Folha";
            // 
            // TB_Nome
            // 
            TB_Nome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TB_Nome.BackColor = Color.White;
            TB_Nome.BorderStyle = BorderStyle.FixedSingle;
            TB_Nome.Location = new Point(22, 32);
            TB_Nome.Margin = new Padding(3, 4, 3, 4);
            TB_Nome.Name = "TB_Nome";
            TB_Nome.Size = new Size(592, 27);
            TB_Nome.TabIndex = 5;
            // 
            // TB_ApiKey
            // 
            TB_ApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TB_ApiKey.BorderStyle = BorderStyle.FixedSingle;
            TB_ApiKey.Location = new Point(22, 116);
            TB_ApiKey.Margin = new Padding(3, 4, 3, 4);
            TB_ApiKey.Name = "TB_ApiKey";
            TB_ApiKey.Size = new Size(592, 27);
            TB_ApiKey.TabIndex = 6;
            // 
            // TB_ApiSecret
            // 
            TB_ApiSecret.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TB_ApiSecret.BorderStyle = BorderStyle.FixedSingle;
            TB_ApiSecret.ForeColor = Color.Black;
            TB_ApiSecret.Location = new Point(22, 214);
            TB_ApiSecret.Margin = new Padding(3, 4, 3, 4);
            TB_ApiSecret.Name = "TB_ApiSecret";
            TB_ApiSecret.Size = new Size(592, 27);
            TB_ApiSecret.TabIndex = 7;
            // 
            // TB_SheetID
            // 
            TB_SheetID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TB_SheetID.BorderStyle = BorderStyle.FixedSingle;
            TB_SheetID.Location = new Point(20, 311);
            TB_SheetID.Margin = new Padding(3, 4, 3, 4);
            TB_SheetID.Name = "TB_SheetID";
            TB_SheetID.Size = new Size(592, 27);
            TB_SheetID.TabIndex = 8;
            // 
            // TB_NomeDaFolha
            // 
            TB_NomeDaFolha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TB_NomeDaFolha.BorderStyle = BorderStyle.FixedSingle;
            TB_NomeDaFolha.Location = new Point(20, 396);
            TB_NomeDaFolha.Margin = new Padding(3, 4, 3, 4);
            TB_NomeDaFolha.Name = "TB_NomeDaFolha";
            TB_NomeDaFolha.Size = new Size(592, 27);
            TB_NomeDaFolha.TabIndex = 9;
            // 
            // BTN_Editar
            // 
            BTN_Editar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Editar.BackColor = Color.Transparent;
            BTN_Editar.FlatStyle = FlatStyle.Flat;
            BTN_Editar.ForeColor = Color.Black;
            BTN_Editar.Location = new Point(22, 459);
            BTN_Editar.Margin = new Padding(3, 4, 3, 4);
            BTN_Editar.Name = "BTN_Editar";
            BTN_Editar.Size = new Size(122, 47);
            BTN_Editar.TabIndex = 10;
            BTN_Editar.Text = "Editar";
            BTN_Editar.UseVisualStyleBackColor = false;
            BTN_Editar.Click += BTN_Editar_Click;
            // 
            // BTN_Excluir
            // 
            BTN_Excluir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_Excluir.BackColor = Color.Transparent;
            BTN_Excluir.FlatStyle = FlatStyle.Flat;
            BTN_Excluir.ForeColor = Color.Black;
            BTN_Excluir.Location = new Point(490, 459);
            BTN_Excluir.Margin = new Padding(3, 4, 3, 4);
            BTN_Excluir.Name = "BTN_Excluir";
            BTN_Excluir.Size = new Size(122, 47);
            BTN_Excluir.TabIndex = 11;
            BTN_Excluir.Text = "Excluir";
            BTN_Excluir.UseVisualStyleBackColor = false;
            BTN_Excluir.Click += BTN_Excluir_Click;
            // 
            // AtualizarDados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(635, 574);
            Controls.Add(BTN_Excluir);
            Controls.Add(BTN_Editar);
            Controls.Add(TB_NomeDaFolha);
            Controls.Add(TB_SheetID);
            Controls.Add(TB_ApiSecret);
            Controls.Add(TB_ApiKey);
            Controls.Add(TB_Nome);
            Controls.Add(LB_NomeDaFolha);
            Controls.Add(LB_SheetID);
            Controls.Add(LB_ApiSecret);
            Controls.Add(LB_ApiKey);
            Controls.Add(LB_Nome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AtualizarDados";
            Text = "AtualizarDados";
            TopMost = true;
            Load += AtualizarDados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_Nome;
        private Label LB_ApiKey;
        private Label LB_ApiSecret;
        private Label LB_SheetID;
        private Label LB_NomeDaFolha;
        private TextBox TB_Nome;
        private TextBox TB_ApiKey;
        private TextBox TB_ApiSecret;
        private TextBox TB_SheetID;
        private TextBox TB_NomeDaFolha;
        private Button BTN_Editar;
        private Button BTN_Excluir;
    }
}