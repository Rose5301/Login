
namespace ProjetoLogin.Apresentacao
{
    partial class Cadastrar
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
            this.CadastreSe = new System.Windows.Forms.Button();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CadastreSe
            // 
            this.CadastreSe.Location = new System.Drawing.Point(112, 247);
            this.CadastreSe.Name = "CadastreSe";
            this.CadastreSe.Size = new System.Drawing.Size(75, 23);
            this.CadastreSe.TabIndex = 0;
            this.CadastreSe.Text = "Cadastrar";
            this.CadastreSe.UseVisualStyleBackColor = true;
            this.CadastreSe.Click += new System.EventHandler(this.CadastraSe_Click);
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(66, 62);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(167, 20);
            this.txbLogin.TabIndex = 1;
            this.txbLogin.TextChanged += new System.EventHandler(this.txbLogin_TextChanged);
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(66, 185);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.PasswordChar = '*';
            this.txbConfirmar.Size = new System.Drawing.Size(167, 20);
            this.txbConfirmar.TabIndex = 2;
            this.txbConfirmar.TextChanged += new System.EventHandler(this.txbConfirmar_TextChanged);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(66, 144);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(167, 20);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(66, 103);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(167, 20);
            this.txbTelefone.TabIndex = 8;
            this.txbTelefone.TextChanged += new System.EventHandler(this.txbTelefone_TextChanged);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 298);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbConfirmar);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.CadastreSe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CadastreSe;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTelefone;
    }
}