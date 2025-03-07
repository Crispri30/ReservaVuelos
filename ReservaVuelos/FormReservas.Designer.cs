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
            this.lblCodigoReserva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.txtCantReserva = new System.Windows.Forms.TextBox();
            this.btnCrearReserva = new System.Windows.Forms.Button();
            this.listBoxReserva = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRealizaReserva = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoReserva
            // 
            this.lblCodigoReserva.AutoSize = true;
            this.lblCodigoReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoReserva.Location = new System.Drawing.Point(35, 175);
            this.lblCodigoReserva.Name = "lblCodigoReserva";
            this.lblCodigoReserva.Size = new System.Drawing.Size(172, 19);
            this.lblCodigoReserva.TabIndex = 0;
            this.lblCodigoReserva.Text = "Codigo de la reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de asientos a reservar:";
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoReserva.Location = new System.Drawing.Point(297, 172);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(216, 26);
            this.txtCodigoReserva.TabIndex = 2;
            // 
            // txtCantReserva
            // 
            this.txtCantReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantReserva.Location = new System.Drawing.Point(297, 216);
            this.txtCantReserva.Name = "txtCantReserva";
            this.txtCantReserva.Size = new System.Drawing.Size(216, 26);
            this.txtCantReserva.TabIndex = 3;
            // 
            // btnCrearReserva
            // 
            this.btnCrearReserva.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrearReserva.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearReserva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCrearReserva.Location = new System.Drawing.Point(297, 298);
            this.btnCrearReserva.Name = "btnCrearReserva";
            this.btnCrearReserva.Size = new System.Drawing.Size(216, 67);
            this.btnCrearReserva.TabIndex = 4;
            this.btnCrearReserva.Text = "Generar reserva";
            this.btnCrearReserva.UseVisualStyleBackColor = false;
            this.btnCrearReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxReserva
            // 
            this.listBoxReserva.BackColor = System.Drawing.Color.GhostWhite;
            this.listBoxReserva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReserva.FormattingEnabled = true;
            this.listBoxReserva.ItemHeight = 14;
            this.listBoxReserva.Location = new System.Drawing.Point(535, 104);
            this.listBoxReserva.Name = "listBoxReserva";
            this.listBoxReserva.Size = new System.Drawing.Size(243, 284);
            this.listBoxReserva.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CC Airways";
            // 
            // lblRealizaReserva
            // 
            this.lblRealizaReserva.AutoSize = true;
            this.lblRealizaReserva.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealizaReserva.Location = new System.Drawing.Point(322, 81);
            this.lblRealizaReserva.Name = "lblRealizaReserva";
            this.lblRealizaReserva.Size = new System.Drawing.Size(165, 22);
            this.lblRealizaReserva.TabIndex = 7;
            this.lblRealizaReserva.Text = "Realizar Reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReservaVuelos.Properties.Resources.avion_logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRealizaReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxReserva);
            this.Controls.Add(this.btnCrearReserva);
            this.Controls.Add(this.txtCantReserva);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCodigoReserva);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.TextBox txtCantReserva;
        private System.Windows.Forms.Button btnCrearReserva;
        private System.Windows.Forms.ListBox listBoxReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRealizaReserva;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}