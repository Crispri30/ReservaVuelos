namespace ReservaVuelos
{
    partial class FormReservas
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
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.txtCantReserva = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxReserva = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de la reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de asientos a reservar";
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(228, 64);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoReserva.TabIndex = 2;
            // 
            // txtCantReserva
            // 
            this.txtCantReserva.Location = new System.Drawing.Point(228, 142);
            this.txtCantReserva.Name = "txtCantReserva";
            this.txtCantReserva.Size = new System.Drawing.Size(100, 20);
            this.txtCantReserva.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxReserva
            // 
            this.listBoxReserva.FormattingEnabled = true;
            this.listBoxReserva.Location = new System.Drawing.Point(406, 64);
            this.listBoxReserva.Name = "listBoxReserva";
            this.listBoxReserva.Size = new System.Drawing.Size(347, 290);
            this.listBoxReserva.TabIndex = 5;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantReserva);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.TextBox txtCantReserva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxReserva;
    }
}