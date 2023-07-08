namespace AppUI
{
    partial class CadastrarUsuario
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
            LB_Usuario = new Label();
            LB_Senha = new Label();
            TB_Usuario = new TextBox();
            TB_Senha = new TextBox();
            BTN_Cadastrar = new Button();
            SuspendLayout();
            // 
            // LB_Usuario
            // 
            LB_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Usuario.AutoSize = true;
            LB_Usuario.BackColor = Color.Transparent;
            LB_Usuario.ForeColor = Color.Black;
            LB_Usuario.Location = new Point(466, 206);
            LB_Usuario.Name = "LB_Usuario";
            LB_Usuario.Size = new Size(59, 20);
            LB_Usuario.TabIndex = 0;
            LB_Usuario.Text = "Usuario";
            // 
            // LB_Senha
            // 
            LB_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Senha.AutoSize = true;
            LB_Senha.BackColor = Color.Transparent;
            LB_Senha.ForeColor = Color.Black;
            LB_Senha.Location = new Point(466, 337);
            LB_Senha.Name = "LB_Senha";
            LB_Senha.Size = new Size(49, 20);
            LB_Senha.TabIndex = 1;
            LB_Senha.Text = "Senha";
            // 
            // TB_Usuario
            // 
            TB_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Usuario.BorderStyle = BorderStyle.FixedSingle;
            TB_Usuario.Location = new Point(466, 230);
            TB_Usuario.Margin = new Padding(3, 4, 3, 4);
            TB_Usuario.Name = "TB_Usuario";
            TB_Usuario.Size = new Size(419, 27);
            TB_Usuario.TabIndex = 2;
            // 
            // TB_Senha
            // 
            TB_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TB_Senha.BorderStyle = BorderStyle.FixedSingle;
            TB_Senha.Location = new Point(466, 361);
            TB_Senha.Margin = new Padding(3, 4, 3, 4);
            TB_Senha.Name = "TB_Senha";
            TB_Senha.Size = new Size(419, 27);
            TB_Senha.TabIndex = 3;
            // 
            // BTN_Cadastrar
            // 
            BTN_Cadastrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BTN_Cadastrar.FlatStyle = FlatStyle.Flat;
            BTN_Cadastrar.ForeColor = Color.Black;
            BTN_Cadastrar.Location = new Point(607, 469);
            BTN_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cadastrar.Name = "BTN_Cadastrar";
            BTN_Cadastrar.Size = new Size(130, 72);
            BTN_Cadastrar.TabIndex = 4;
            BTN_Cadastrar.Text = "Cadastrar";
            BTN_Cadastrar.UseVisualStyleBackColor = true;
            BTN_Cadastrar.Click += BTN_Cadastrar_Click;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1308, 879);
            Controls.Add(BTN_Cadastrar);
            Controls.Add(TB_Senha);
            Controls.Add(TB_Usuario);
            Controls.Add(LB_Senha);
            Controls.Add(LB_Usuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastrarUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "CadastrarUsuario";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_Usuario;
        private Label LB_Senha;
        private TextBox TB_Usuario;
        private TextBox TB_Senha;
        private Button BTN_Cadastrar;
    }
}