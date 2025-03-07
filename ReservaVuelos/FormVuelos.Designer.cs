namespace ReservaVuelos
{
    partial class FormVuelos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNumDis = new System.Windows.Forms.TextBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.bttForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha del vuelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asientos disponibles";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(143, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(143, 97);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtOrigen.TabIndex = 6;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(143, 157);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 7;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(143, 214);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // txtNumDis
            // 
            this.txtNumDis.Location = new System.Drawing.Point(145, 275);
            this.txtNumDis.Name = "txtNumDis";
            this.txtNumDis.Size = new System.Drawing.Size(100, 20);
            this.txtNumDis.TabIndex = 9;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(12, 309);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(95, 57);
            this.bttAgregar.TabIndex = 10;
            this.bttAgregar.Text = "Agregar vuelo";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(280, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(487, 342);
            this.listBox.TabIndex = 11;
            // 
            // bttForm2
            // 
            this.bttForm2.Location = new System.Drawing.Point(123, 309);
            this.bttForm2.Name = "bttForm2";
            this.bttForm2.Size = new System.Drawing.Size(122, 58);
            this.bttForm2.TabIndex = 12;
            this.bttForm2.Text = "Form para registrar reservas";
            this.bttForm2.UseVisualStyleBackColor = true;
            this.bttForm2.Click += new System.EventHandler(this.bttForm2_Click);
            // 
            // FormVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttForm2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.txtNumDis);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVuelos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNumDis;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button bttForm2;
    }
}

