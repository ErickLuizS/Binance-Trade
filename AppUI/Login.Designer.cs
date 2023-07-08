namespace AppUI
{
    partial class Login
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
            TBX_Usúario = new TextBox();
            TBX_Senha = new TextBox();
            BTN_Entrar = new Button();
            BTN_Cadastrar = new Button();
            SuspendLayout();
            // 
            // LB_Usuario
            // 
            LB_Usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Usuario.AutoSize = true;
            LB_Usuario.BackColor = Color.White;
            LB_Usuario.ForeColor = Color.Black;
            LB_Usuario.Location = new Point(436, 293);
            LB_Usuario.Name = "LB_Usuario";
            LB_Usuario.Size = new Size(59, 20);
            LB_Usuario.TabIndex = 0;
            LB_Usuario.Text = "Usuário";
            // 
            // LB_Senha
            // 
            LB_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LB_Senha.AutoSize = true;
            LB_Senha.BackColor = Color.Transparent;
            LB_Senha.ForeColor = Color.Black;
            LB_Senha.Location = new Point(436, 430);
            LB_Senha.Name = "LB_Senha";
            LB_Senha.Size = new Size(49, 20);
            LB_Senha.TabIndex = 1;
            LB_Senha.Text = "Senha";
            // 
            // TBX_Usúario
            // 
            TBX_Usúario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TBX_Usúario.BorderStyle = BorderStyle.FixedSingle;
            TBX_Usúario.Cursor = Cursors.IBeam;
            TBX_Usúario.Location = new Point(436, 470);
            TBX_Usúario.Margin = new Padding(3, 4, 3, 4);
            TBX_Usúario.Name = "TBX_Usúario";
            TBX_Usúario.Size = new Size(429, 27);
            TBX_Usúario.TabIndex = 2;
            // 
            // TBX_Senha
            // 
            TBX_Senha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TBX_Senha.BorderStyle = BorderStyle.FixedSingle;
            TBX_Senha.Location = new Point(436, 333);
            TBX_Senha.Margin = new Padding(3, 4, 3, 4);
            TBX_Senha.Name = "TBX_Senha";
            TBX_Senha.Size = new Size(429, 27);
            TBX_Senha.TabIndex = 3;
            TBX_Senha.TextAlign = HorizontalAlignment.Right;
            TBX_Senha.UseSystemPasswordChar = true;
            // 
            // BTN_Entrar
            // 
            BTN_Entrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BTN_Entrar.BackColor = Color.Transparent;
            BTN_Entrar.FlatStyle = FlatStyle.Flat;
            BTN_Entrar.ForeColor = Color.Black;
            BTN_Entrar.Location = new Point(436, 549);
            BTN_Entrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Entrar.Name = "BTN_Entrar";
            BTN_Entrar.Size = new Size(138, 45);
            BTN_Entrar.TabIndex = 4;
            BTN_Entrar.Text = "Entrar";
            BTN_Entrar.UseVisualStyleBackColor = false;
            BTN_Entrar.Click += BTN_Entrar_Click;
            // 
            // BTN_Cadastrar
            // 
            BTN_Cadastrar.Anchor = AnchorStyles.Bottom;
            BTN_Cadastrar.FlatStyle = FlatStyle.Flat;
            BTN_Cadastrar.ForeColor = Color.Black;
            BTN_Cadastrar.Location = new Point(727, 549);
            BTN_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            BTN_Cadastrar.Name = "BTN_Cadastrar";
            BTN_Cadastrar.Size = new Size(138, 45);
            BTN_Cadastrar.TabIndex = 5;
            BTN_Cadastrar.Text = "Cadastrar";
            BTN_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AccessibleRole = AccessibleRole.Cursor;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            CausesValidation = false;
            ClientSize = new Size(1354, 893);
            Controls.Add(BTN_Cadastrar);
            Controls.Add(BTN_Entrar);
            Controls.Add(TBX_Senha);
            Controls.Add(TBX_Usúario);
            Controls.Add(LB_Senha);
            Controls.Add(LB_Usuario);
            Margin = new Padding(3, 4, 3, 4);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_Usuario;
        private Label LB_Senha;
        protected TextBox TBX_Usúario;
        private TextBox TBX_Senha;
        private Button BTN_Entrar;
        private Button BTN_Cadastrar;
    }
}