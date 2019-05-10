namespace VentanaLogin
{
    partial class Ventana2
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
            this.checkPHP = new System.Windows.Forms.CheckBox();
            this.checkJava = new System.Windows.Forms.CheckBox();
            this.rdbtnTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rdbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.lblCursos = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.btnCompar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkPHP
            // 
            this.checkPHP.AutoSize = true;
            this.checkPHP.Location = new System.Drawing.Point(33, 65);
            this.checkPHP.Name = "checkPHP";
            this.checkPHP.Size = new System.Drawing.Size(48, 17);
            this.checkPHP.TabIndex = 0;
            this.checkPHP.Text = "PHP";
            this.checkPHP.UseVisualStyleBackColor = true;
            // 
            // checkJava
            // 
            this.checkJava.AutoSize = true;
            this.checkJava.Location = new System.Drawing.Point(33, 121);
            this.checkJava.Name = "checkJava";
            this.checkJava.Size = new System.Drawing.Size(49, 17);
            this.checkJava.TabIndex = 1;
            this.checkJava.Text = "Java";
            this.checkJava.UseVisualStyleBackColor = true;
            // 
            // rdbtnTarjetaCredito
            // 
            this.rdbtnTarjetaCredito.AutoSize = true;
            this.rdbtnTarjetaCredito.Location = new System.Drawing.Point(167, 65);
            this.rdbtnTarjetaCredito.Name = "rdbtnTarjetaCredito";
            this.rdbtnTarjetaCredito.Size = new System.Drawing.Size(108, 17);
            this.rdbtnTarjetaCredito.TabIndex = 2;
            this.rdbtnTarjetaCredito.TabStop = true;
            this.rdbtnTarjetaCredito.Text = "Tarjeta de crédito";
            this.rdbtnTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rdbtnEfectivo
            // 
            this.rdbtnEfectivo.AutoSize = true;
            this.rdbtnEfectivo.Location = new System.Drawing.Point(167, 121);
            this.rdbtnEfectivo.Name = "rdbtnEfectivo";
            this.rdbtnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbtnEfectivo.TabIndex = 3;
            this.rdbtnEfectivo.TabStop = true;
            this.rdbtnEfectivo.Text = "Efectivo";
            this.rdbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.Location = new System.Drawing.Point(12, 26);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(129, 15);
            this.lblCursos.TabIndex = 4;
            this.lblCursos.Text = "Cursos disponibles";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.Location = new System.Drawing.Point(164, 26);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(111, 15);
            this.lblMetodoPago.TabIndex = 5;
            this.lblMetodoPago.Text = "Metodo de pago";
            // 
            // btnCompar
            // 
            this.btnCompar.Location = new System.Drawing.Point(33, 196);
            this.btnCompar.Name = "btnCompar";
            this.btnCompar.Size = new System.Drawing.Size(75, 23);
            this.btnCompar.TabIndex = 6;
            this.btnCompar.Text = "Comprar";
            this.btnCompar.UseVisualStyleBackColor = true;
            this.btnCompar.Click += new System.EventHandler(this.btnCompar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(177, 196);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCompar);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblCursos);
            this.Controls.Add(this.rdbtnEfectivo);
            this.Controls.Add(this.rdbtnTarjetaCredito);
            this.Controls.Add(this.checkJava);
            this.Controls.Add(this.checkPHP);
            this.Name = "Ventana2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkPHP;
        private System.Windows.Forms.CheckBox checkJava;
        private System.Windows.Forms.RadioButton rdbtnTarjetaCredito;
        private System.Windows.Forms.RadioButton rdbtnEfectivo;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Button btnCompar;
        private System.Windows.Forms.Button btnVolver;
    }
}