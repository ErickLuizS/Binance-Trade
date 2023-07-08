namespace AppUI
{
    partial class Completado
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
            LB_QuantidadeRE = new Label();
            LB_ParRE = new Label();
            LB_TipoRE = new Label();
            LB_LadoRE = new Label();
            LB_PriceRE = new Label();
            BTN_Ok = new Button();
            LB_Quantidade = new Label();
            LB_Par = new Label();
            LB_Tipo = new Label();
            LB_Lado = new Label();
            LB_Preco = new Label();
            SuspendLayout();
            // 
            // LB_QuantidadeRE
            // 
            LB_QuantidadeRE.AutoSize = true;
            LB_QuantidadeRE.ForeColor = Color.DimGray;
            LB_QuantidadeRE.Location = new Point(158, 261);
            LB_QuantidadeRE.Name = "LB_QuantidadeRE";
            LB_QuantidadeRE.Size = new Size(104, 20);
            LB_QuantidadeRE.TabIndex = 0;
            LB_QuantidadeRE.Text = "QuantidadeRE";
            // 
            // LB_ParRE
            // 
            LB_ParRE.AutoSize = true;
            LB_ParRE.ForeColor = Color.DimGray;
            LB_ParRE.Location = new Point(297, 261);
            LB_ParRE.Name = "LB_ParRE";
            LB_ParRE.Size = new Size(46, 20);
            LB_ParRE.TabIndex = 1;
            LB_ParRE.Text = "ParRE";
            // 
            // LB_TipoRE
            // 
            LB_TipoRE.AutoSize = true;
            LB_TipoRE.BackColor = Color.Transparent;
            LB_TipoRE.ForeColor = Color.DimGray;
            LB_TipoRE.Location = new Point(373, 261);
            LB_TipoRE.Name = "LB_TipoRE";
            LB_TipoRE.Size = new Size(56, 20);
            LB_TipoRE.TabIndex = 2;
            LB_TipoRE.Text = "TipoRE";
            // 
            // LB_LadoRE
            // 
            LB_LadoRE.AutoSize = true;
            LB_LadoRE.ForeColor = Color.DimGray;
            LB_LadoRE.Location = new Point(455, 261);
            LB_LadoRE.Name = "LB_LadoRE";
            LB_LadoRE.Size = new Size(59, 20);
            LB_LadoRE.TabIndex = 3;
            LB_LadoRE.Text = "LadoRE";
            LB_LadoRE.Click += LB_LadoRE_Click;
            // 
            // LB_PriceRE
            // 
            LB_PriceRE.AutoSize = true;
            LB_PriceRE.ForeColor = Color.DimGray;
            LB_PriceRE.Location = new Point(544, 261);
            LB_PriceRE.Name = "LB_PriceRE";
            LB_PriceRE.Size = new Size(63, 20);
            LB_PriceRE.TabIndex = 4;
            LB_PriceRE.Text = "PrecoRE";
            // 
            // BTN_Ok
            // 
            BTN_Ok.FlatStyle = FlatStyle.Flat;
            BTN_Ok.ForeColor = Color.Black;
            BTN_Ok.Location = new Point(344, 373);
            BTN_Ok.Margin = new Padding(3, 4, 3, 4);
            BTN_Ok.Name = "BTN_Ok";
            BTN_Ok.Size = new Size(124, 68);
            BTN_Ok.TabIndex = 5;
            BTN_Ok.Text = "OK";
            BTN_Ok.UseVisualStyleBackColor = true;
            BTN_Ok.Click += BTN_Ok_Click;
            // 
            // LB_Quantidade
            // 
            LB_Quantidade.AutoSize = true;
            LB_Quantidade.ForeColor = Color.Black;
            LB_Quantidade.Location = new Point(158, 241);
            LB_Quantidade.Name = "LB_Quantidade";
            LB_Quantidade.Size = new Size(87, 20);
            LB_Quantidade.TabIndex = 6;
            LB_Quantidade.Text = "Quantidade";
            // 
            // LB_Par
            // 
            LB_Par.AutoSize = true;
            LB_Par.ForeColor = Color.Black;
            LB_Par.Location = new Point(297, 241);
            LB_Par.Name = "LB_Par";
            LB_Par.Size = new Size(29, 20);
            LB_Par.TabIndex = 7;
            LB_Par.Text = "Par";
            // 
            // LB_Tipo
            // 
            LB_Tipo.AutoSize = true;
            LB_Tipo.ForeColor = Color.Black;
            LB_Tipo.Location = new Point(373, 241);
            LB_Tipo.Name = "LB_Tipo";
            LB_Tipo.Size = new Size(39, 20);
            LB_Tipo.TabIndex = 8;
            LB_Tipo.Text = "Tipo";
            // 
            // LB_Lado
            // 
            LB_Lado.AutoSize = true;
            LB_Lado.ForeColor = Color.Black;
            LB_Lado.Location = new Point(455, 241);
            LB_Lado.Name = "LB_Lado";
            LB_Lado.Size = new Size(42, 20);
            LB_Lado.TabIndex = 9;
            LB_Lado.Text = "Lado";
            // 
            // LB_Preco
            // 
            LB_Preco.AutoSize = true;
            LB_Preco.ForeColor = Color.Black;
            LB_Preco.Location = new Point(544, 241);
            LB_Preco.Name = "LB_Preco";
            LB_Preco.Size = new Size(46, 20);
            LB_Preco.TabIndex = 10;
            LB_Preco.Text = "Preço";
            // 
            // Completado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(LB_Preco);
            Controls.Add(LB_Lado);
            Controls.Add(LB_Tipo);
            Controls.Add(LB_Par);
            Controls.Add(LB_Quantidade);
            Controls.Add(BTN_Ok);
            Controls.Add(LB_PriceRE);
            Controls.Add(LB_LadoRE);
            Controls.Add(LB_TipoRE);
            Controls.Add(LB_ParRE);
            Controls.Add(LB_QuantidadeRE);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Completado";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label LB_QuantidadeRE;
        public Label LB_ParRE;
        public Label LB_TipoRE;
        public Label LB_LadoRE;
        public Label LB_PriceRE;
        private Button BTN_Ok;
        private Label LB_Quantidade;
        private Label LB_Par;
        private Label LB_Tipo;
        private Label LB_Lado;
        private Label LB_Preco;
    }
}