namespace Facturacion
{
    partial class VentanaUser
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
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(515, 419);
            this.btnSalir.Size = new System.Drawing.Size(177, 52);
            // 
            // pictureUser
            // 
            this.pictureUser.Location = new System.Drawing.Point(169, 365);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(255, 166);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 24;
            this.pictureUser.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 52);
            this.button4.TabIndex = 22;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 52);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cambiar Contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Contenedor Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.SystemColors.Control;
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(249, 313);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(111, 17);
            this.lblCod.TabIndex = 18;
            // 
            // lblUs
            // 
            this.lblUs.BackColor = System.Drawing.SystemColors.Control;
            this.lblUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUs.Location = new System.Drawing.Point(249, 208);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(111, 17);
            this.lblUs.TabIndex = 17;
            // 
            // lblNom
            // 
            this.lblNom.BackColor = System.Drawing.SystemColors.Control;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(249, 120);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(111, 17);
            this.lblNom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // VentanaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 599);
            this.Controls.Add(this.pictureUser);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaUser_FormClosed);
            this.Load += new System.EventHandler(this.VentanaUser_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblNom, 0);
            this.Controls.SetChildIndex(this.lblUs, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.pictureUser, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}