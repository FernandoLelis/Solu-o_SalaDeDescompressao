namespace SalaDeDescomprecao.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.labelCpfLogin = new System.Windows.Forms.Label();
            this.textBoxCpfLogin = new System.Windows.Forms.TextBox();
            this.labelSenhaLogin = new System.Windows.Forms.Label();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRealizarCadastro = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.labelSair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(119, 211);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(75, 23);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelCpfLogin
            // 
            this.labelCpfLogin.AutoSize = true;
            this.labelCpfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpfLogin.Location = new System.Drawing.Point(60, 131);
            this.labelCpfLogin.Name = "labelCpfLogin";
            this.labelCpfLogin.Size = new System.Drawing.Size(33, 15);
            this.labelCpfLogin.TabIndex = 1;
            this.labelCpfLogin.Text = "CPF:";
            this.labelCpfLogin.Click += new System.EventHandler(this.labelCpfLogin_Click);
            // 
            // textBoxCpfLogin
            // 
            this.textBoxCpfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCpfLogin.Location = new System.Drawing.Point(101, 128);
            this.textBoxCpfLogin.Name = "textBoxCpfLogin";
            this.textBoxCpfLogin.Size = new System.Drawing.Size(142, 21);
            this.textBoxCpfLogin.TabIndex = 2;
            this.textBoxCpfLogin.TextChanged += new System.EventHandler(this.textBoxCpfLogin_TextChanged);
            // 
            // labelSenhaLogin
            // 
            this.labelSenhaLogin.AutoSize = true;
            this.labelSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenhaLogin.Location = new System.Drawing.Point(60, 167);
            this.labelSenhaLogin.Name = "labelSenhaLogin";
            this.labelSenhaLogin.Size = new System.Drawing.Size(46, 15);
            this.labelSenhaLogin.TabIndex = 1;
            this.labelSenhaLogin.Text = "Senha:";
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(103, 164);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(140, 21);
            this.textBoxSenhaLogin.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelRealizarCadastro
            // 
            this.labelRealizarCadastro.AutoSize = true;
            this.labelRealizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRealizarCadastro.Location = new System.Drawing.Point(120, 250);
            this.labelRealizarCadastro.Name = "labelRealizarCadastro";
            this.labelRealizarCadastro.Size = new System.Drawing.Size(73, 15);
            this.labelRealizarCadastro.TabIndex = 1;
            this.labelRealizarCadastro.Text = "Cadastre-se";
            this.labelRealizarCadastro.Click += new System.EventHandler(this.labelRealizarCadastro_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.labelSair);
            this.groupBoxLogin.Controls.Add(this.pictureBox1);
            this.groupBoxLogin.Controls.Add(this.textBoxSenhaLogin);
            this.groupBoxLogin.Controls.Add(this.buttonEntrar);
            this.groupBoxLogin.Controls.Add(this.labelRealizarCadastro);
            this.groupBoxLogin.Controls.Add(this.labelCpfLogin);
            this.groupBoxLogin.Controls.Add(this.labelSenhaLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxCpfLogin);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(308, 294);
            this.groupBoxLogin.TabIndex = 5;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSair.Location = new System.Drawing.Point(297, -1);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(15, 15);
            this.labelSair.TabIndex = 4;
            this.labelSair.Text = "X";
            this.labelSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelSair.Click += new System.EventHandler(this.labelSair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 318);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label labelCpfLogin;
        private System.Windows.Forms.TextBox textBoxCpfLogin;
        private System.Windows.Forms.Label labelSenhaLogin;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRealizarCadastro;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelSair;
    }
}