namespace SalaDeDescomprecao.View
{
    partial class AlterarDadosUsuario
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
            this.labelAlterarCpf = new System.Windows.Forms.Label();
            this.textBoxAlterarCpf = new System.Windows.Forms.TextBox();
            this.labelAlterarSenha = new System.Windows.Forms.Label();
            this.textBoxAlterarSenha = new System.Windows.Forms.TextBox();
            this.textBoxAlterarCelular = new System.Windows.Forms.TextBox();
            this.labelAlterarCelular = new System.Windows.Forms.Label();
            this.textBoxAlterarEmail = new System.Windows.Forms.TextBox();
            this.labelAlterarEmail = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.labelAlterarNome = new System.Windows.Forms.Label();
            this.textBoxAlterarNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAlterarCpf
            // 
            this.labelAlterarCpf.AutoSize = true;
            this.labelAlterarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarCpf.Location = new System.Drawing.Point(49, 64);
            this.labelAlterarCpf.Name = "labelAlterarCpf";
            this.labelAlterarCpf.Size = new System.Drawing.Size(37, 16);
            this.labelAlterarCpf.TabIndex = 3;
            this.labelAlterarCpf.Text = "CPF:";
            // 
            // textBoxAlterarCpf
            // 
            this.textBoxAlterarCpf.Location = new System.Drawing.Point(109, 63);
            this.textBoxAlterarCpf.Name = "textBoxAlterarCpf";
            this.textBoxAlterarCpf.ReadOnly = true;
            this.textBoxAlterarCpf.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlterarCpf.TabIndex = 10;
            // 
            // labelAlterarSenha
            // 
            this.labelAlterarSenha.AutoSize = true;
            this.labelAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarSenha.Location = new System.Drawing.Point(49, 223);
            this.labelAlterarSenha.Name = "labelAlterarSenha";
            this.labelAlterarSenha.Size = new System.Drawing.Size(46, 15);
            this.labelAlterarSenha.TabIndex = 12;
            this.labelAlterarSenha.Text = "Senha:";
            // 
            // textBoxAlterarSenha
            // 
            this.textBoxAlterarSenha.Location = new System.Drawing.Point(109, 220);
            this.textBoxAlterarSenha.Name = "textBoxAlterarSenha";
            this.textBoxAlterarSenha.PasswordChar = '*';
            this.textBoxAlterarSenha.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlterarSenha.TabIndex = 16;
            // 
            // textBoxAlterarCelular
            // 
            this.textBoxAlterarCelular.Location = new System.Drawing.Point(109, 181);
            this.textBoxAlterarCelular.Name = "textBoxAlterarCelular";
            this.textBoxAlterarCelular.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlterarCelular.TabIndex = 17;
            // 
            // labelAlterarCelular
            // 
            this.labelAlterarCelular.AutoSize = true;
            this.labelAlterarCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarCelular.Location = new System.Drawing.Point(49, 182);
            this.labelAlterarCelular.Name = "labelAlterarCelular";
            this.labelAlterarCelular.Size = new System.Drawing.Size(49, 15);
            this.labelAlterarCelular.TabIndex = 13;
            this.labelAlterarCelular.Text = "Celular:";
            // 
            // textBoxAlterarEmail
            // 
            this.textBoxAlterarEmail.Location = new System.Drawing.Point(109, 142);
            this.textBoxAlterarEmail.Name = "textBoxAlterarEmail";
            this.textBoxAlterarEmail.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlterarEmail.TabIndex = 18;
            // 
            // labelAlterarEmail
            // 
            this.labelAlterarEmail.AutoSize = true;
            this.labelAlterarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarEmail.Location = new System.Drawing.Point(48, 144);
            this.labelAlterarEmail.Name = "labelAlterarEmail";
            this.labelAlterarEmail.Size = new System.Drawing.Size(46, 15);
            this.labelAlterarEmail.TabIndex = 14;
            this.labelAlterarEmail.Text = "E-mail:";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(133, 272);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterar.TabIndex = 20;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // labelAlterarNome
            // 
            this.labelAlterarNome.AutoSize = true;
            this.labelAlterarNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlterarNome.Location = new System.Drawing.Point(48, 105);
            this.labelAlterarNome.Name = "labelAlterarNome";
            this.labelAlterarNome.Size = new System.Drawing.Size(44, 15);
            this.labelAlterarNome.TabIndex = 15;
            this.labelAlterarNome.Text = "Nome:";
            // 
            // textBoxAlterarNome
            // 
            this.textBoxAlterarNome.Location = new System.Drawing.Point(109, 103);
            this.textBoxAlterarNome.Name = "textBoxAlterarNome";
            this.textBoxAlterarNome.Size = new System.Drawing.Size(177, 20);
            this.textBoxAlterarNome.TabIndex = 19;
            // 
            // AlterarDadosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 329);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.labelAlterarSenha);
            this.Controls.Add(this.textBoxAlterarSenha);
            this.Controls.Add(this.textBoxAlterarCelular);
            this.Controls.Add(this.labelAlterarCelular);
            this.Controls.Add(this.textBoxAlterarEmail);
            this.Controls.Add(this.labelAlterarEmail);
            this.Controls.Add(this.textBoxAlterarNome);
            this.Controls.Add(this.labelAlterarNome);
            this.Controls.Add(this.labelAlterarCpf);
            this.Controls.Add(this.textBoxAlterarCpf);
            this.Name = "AlterarDadosUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlterarCpf;
        private System.Windows.Forms.TextBox textBoxAlterarCpf;
        private System.Windows.Forms.Label labelAlterarSenha;
        private System.Windows.Forms.TextBox textBoxAlterarSenha;
        private System.Windows.Forms.TextBox textBoxAlterarCelular;
        private System.Windows.Forms.Label labelAlterarCelular;
        private System.Windows.Forms.TextBox textBoxAlterarEmail;
        private System.Windows.Forms.Label labelAlterarEmail;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Label labelAlterarNome;
        private System.Windows.Forms.TextBox textBoxAlterarNome;
    }
}