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
            this.lblCodigoVuelo = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblFechaVuelo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtNumDis = new System.Windows.Forms.TextBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.bttForm2 = new System.Windows.Forms.Button();
            this.lblTituloBienvenida = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoVuelo
            // 
            this.lblCodigoVuelo.AutoSize = true;
            this.lblCodigoVuelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVuelo.Location = new System.Drawing.Point(27, 176);
            this.lblCodigoVuelo.Name = "lblCodigoVuelo";
            this.lblCodigoVuelo.Size = new System.Drawing.Size(144, 19);
            this.lblCodigoVuelo.TabIndex = 0;
            this.lblCodigoVuelo.Text = "Codigo del vuelo:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(27, 211);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(66, 19);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(27, 248);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(74, 19);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            this.lblDestino.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFechaVuelo
            // 
            this.lblFechaVuelo.AutoSize = true;
            this.lblFechaVuelo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVuelo.Location = new System.Drawing.Point(27, 284);
            this.lblFechaVuelo.Name = "lblFechaVuelo";
            this.lblFechaVuelo.Size = new System.Drawing.Size(135, 19);
            this.lblFechaVuelo.TabIndex = 3;
            this.lblFechaVuelo.Text = "Fecha del vuelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Asientos disponibles:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(208, 173);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(321, 26);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigen.Location = new System.Drawing.Point(208, 208);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(321, 26);
            this.txtOrigen.TabIndex = 6;
            this.txtOrigen.TextChanged += new System.EventHandler(this.txtOrigen_TextChanged);
            // 
            // txtDestino
            // 
            this.txtDestino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(208, 245);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(321, 26);
            this.txtDestino.TabIndex = 7;
            // 
            // txtNumDis
            // 
            this.txtNumDis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDis.Location = new System.Drawing.Point(208, 316);
            this.txtNumDis.Name = "txtNumDis";
            this.txtNumDis.Size = new System.Drawing.Size(321, 26);
            this.txtNumDis.TabIndex = 9;
            // 
            // bttAgregar
            // 
            this.bttAgregar.BackColor = System.Drawing.Color.LightBlue;
            this.bttAgregar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAgregar.Location = new System.Drawing.Point(208, 363);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(140, 59);
            this.bttAgregar.TabIndex = 10;
            this.bttAgregar.Text = "Agregar vuelo";
            this.bttAgregar.UseVisualStyleBackColor = false;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.BackColor = System.Drawing.Color.GhostWhite;
            this.listBoxVuelos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.ItemHeight = 14;
            this.listBoxVuelos.Location = new System.Drawing.Point(553, 130);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(223, 284);
            this.listBoxVuelos.TabIndex = 11;
            this.listBoxVuelos.SelectedIndexChanged += new System.EventHandler(this.listBoxVuelos_SelectedIndexChanged);
            // 
            // bttForm2
            // 
            this.bttForm2.BackColor = System.Drawing.Color.LightBlue;
            this.bttForm2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttForm2.Location = new System.Drawing.Point(389, 363);
            this.bttForm2.Name = "bttForm2";
            this.bttForm2.Size = new System.Drawing.Size(140, 59);
            this.bttForm2.TabIndex = 12;
            this.bttForm2.Text = "Ir a reservar un vuelo";
            this.bttForm2.UseVisualStyleBackColor = false;
            this.bttForm2.Click += new System.EventHandler(this.bttForm2_Click);
            // 
            // lblTituloBienvenida
            // 
            this.lblTituloBienvenida.AutoSize = true;
            this.lblTituloBienvenida.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBienvenida.Location = new System.Drawing.Point(322, 26);
            this.lblTituloBienvenida.Name = "lblTituloBienvenida";
            this.lblTituloBienvenida.Size = new System.Drawing.Size(165, 32);
            this.lblTituloBienvenida.TabIndex = 13;
            this.lblTituloBienvenida.Text = "CC Airways";
            this.lblTituloBienvenida.Click += new System.EventHandler(this.lblTituloBienvenida_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(298, 75);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(206, 22);
            this.lblAgregar.TabIndex = 14;
            this.lblAgregar.Text = "Agregar Nuevo Vuelo";
            this.lblAgregar.Click += new System.EventHandler(this.lblAgregar_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaSalida.Location = new System.Drawing.Point(208, 278);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(321, 27);
            this.dtpFechaSalida.TabIndex = 15;
            this.dtpFechaSalida.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReservaVuelos.Properties.Resources.avion_logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.lblTituloBienvenida);
            this.Controls.Add(this.bttForm2);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.txtNumDis);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFechaVuelo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblCodigoVuelo);
            this.Name = "FormVuelos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoVuelo;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblFechaVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtNumDis;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.Button bttForm2;
        private System.Windows.Forms.Label lblTituloBienvenida;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

