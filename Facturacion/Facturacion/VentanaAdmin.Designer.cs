namespace Facturacion
{
    partial class VentanaAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(423, 358);
            this.btnSalir.Size = new System.Drawing.Size(177, 57);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.SystemColors.Control;
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAd.Location = new System.Drawing.Point(157, 97);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(175, 18);
            this.lblAd.TabIndex = 3;
            // 
            // lblUs
            // 
            this.lblUs.BackColor = System.Drawing.SystemColors.Control;
            this.lblUs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUs.Location = new System.Drawing.Point(157, 185);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(175, 17);
            this.lblUs.TabIndex = 4;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.SystemColors.Control;
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Location = new System.Drawing.Point(157, 290);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(175, 17);
            this.lblCod.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Contenedor Principal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Administrar Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cambiar Contraseña";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureAdmin
            // 
            this.pictureAdmin.Location = new System.Drawing.Point(77, 342);
            this.pictureAdmin.Name = "pictureAdmin";
            this.pictureAdmin.Size = new System.Drawing.Size(255, 166);
            this.pictureAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAdmin.TabIndex = 12;
            this.pictureAdmin.TabStop = false;
            // 
            // VentanaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 553);
            this.Controls.Add(this.pictureAdmin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VentanaAdmin_FormClosed);
            this.Load += new System.EventHandler(this.VentanaAdmin_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblAd, 0);
            this.Controls.SetChildIndex(this.lblUs, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.pictureAdmin, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureAdmin;
    }
}