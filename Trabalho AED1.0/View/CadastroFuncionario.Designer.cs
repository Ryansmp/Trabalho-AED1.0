namespace Trabalho_AED1._0
{
    partial class CadastroFuncionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.IDGestor = new System.Windows.Forms.Label();
            this.TextoNome = new System.Windows.Forms.TextBox();
            this.TextoCPF = new System.Windows.Forms.TextBox();
            this.TextoSenha = new System.Windows.Forms.TextBox();
            this.TextoCargo = new System.Windows.Forms.TextBox();
            this.TextoGestor = new System.Windows.Forms.TextBox();
            this.FinCadastro = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Nome.Location = new System.Drawing.Point(29, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(40, 15);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CPF.Location = new System.Drawing.Point(29, 65);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(28, 15);
            this.CPF.TabIndex = 1;
            this.CPF.Text = "CPF";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Senha.Location = new System.Drawing.Point(29, 127);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(39, 15);
            this.Senha.TabIndex = 2;
            this.Senha.Text = "Senha";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Cargo.Location = new System.Drawing.Point(30, 190);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(39, 15);
            this.Cargo.TabIndex = 3;
            this.Cargo.Text = "Cargo";
            this.Cargo.Click += new System.EventHandler(this.label4_Click);
            // 
            // IDGestor
            // 
            this.IDGestor.AutoSize = true;
            this.IDGestor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IDGestor.Location = new System.Drawing.Point(29, 255);
            this.IDGestor.Name = "IDGestor";
            this.IDGestor.Size = new System.Drawing.Size(55, 15);
            this.IDGestor.TabIndex = 4;
            this.IDGestor.Text = "ID Gestor";
            // 
            // TextoNome
            // 
            this.TextoNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoNome.Location = new System.Drawing.Point(29, 27);
            this.TextoNome.Name = "TextoNome";
            this.TextoNome.Size = new System.Drawing.Size(96, 23);
            this.TextoNome.TabIndex = 5;
            this.TextoNome.TextChanged += new System.EventHandler(this.TextoNome_TextChanged);
            // 
            // TextoCPF
            // 
            this.TextoCPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCPF.Location = new System.Drawing.Point(29, 83);
            this.TextoCPF.Name = "TextoCPF";
            this.TextoCPF.Size = new System.Drawing.Size(96, 23);
            this.TextoCPF.TabIndex = 6;
            this.TextoCPF.TextChanged += new System.EventHandler(this.TextoCPF_TextChanged);
            // 
            // TextoSenha
            // 
            this.TextoSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoSenha.Location = new System.Drawing.Point(29, 145);
            this.TextoSenha.Name = "TextoSenha";
            this.TextoSenha.Size = new System.Drawing.Size(96, 23);
            this.TextoSenha.TabIndex = 7;
            // 
            // TextoCargo
            // 
            this.TextoCargo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoCargo.Location = new System.Drawing.Point(29, 208);
            this.TextoCargo.Name = "TextoCargo";
            this.TextoCargo.Size = new System.Drawing.Size(96, 23);
            this.TextoCargo.TabIndex = 8;
            // 
            // TextoGestor
            // 
            this.TextoGestor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextoGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoGestor.Location = new System.Drawing.Point(29, 273);
            this.TextoGestor.Name = "TextoGestor";
            this.TextoGestor.Size = new System.Drawing.Size(96, 23);
            this.TextoGestor.TabIndex = 9;
            // 
            // FinCadastro
            // 
            this.FinCadastro.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FinCadastro.Location = new System.Drawing.Point(29, 313);
            this.FinCadastro.Name = "FinCadastro";
            this.FinCadastro.Size = new System.Drawing.Size(96, 48);
            this.FinCadastro.TabIndex = 10;
            this.FinCadastro.Text = "Finalizar Cadastro";
            this.FinCadastro.UseVisualStyleBackColor = false;
            this.FinCadastro.Click += new System.EventHandler(this.FinCadastro_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 23);
            this.comboBox1.TabIndex = 11;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 376);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FinCadastro);
            this.Controls.Add(this.TextoGestor);
            this.Controls.Add(this.TextoCargo);
            this.Controls.Add(this.TextoSenha);
            this.Controls.Add(this.TextoCPF);
            this.Controls.Add(this.TextoNome);
            this.Controls.Add(this.IDGestor);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label CPF;
        private Label Senha;
        private Label Cargo;
        private Label IDGestor;
        private TextBox TextoNome;
        private TextBox TextoCPF;
        private TextBox TextoSenha;
        private TextBox TextoCargo;
        private TextBox TextoGestor;
        private Button FinCadastro;
        private ComboBox comboBox1;
    }
}