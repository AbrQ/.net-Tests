namespace Facturacion
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxAccount = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(150, 338);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(101, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(413, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(61, 108);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(93, 24);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(48, 210);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // txtBoxAccount
            // 
            this.txtBoxAccount.Location = new System.Drawing.Point(160, 110);
            this.txtBoxAccount.Name = "txtBoxAccount";
            this.txtBoxAccount.Size = new System.Drawing.Size(216, 22);
            this.txtBoxAccount.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(160, 212);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(216, 22);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facturacion.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(404, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxAccount);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtBoxAccount;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

