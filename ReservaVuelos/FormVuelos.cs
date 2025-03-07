using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaVuelos
{
    public partial class FormVuelos : Form
    {
        public List<Vuelos> lista_vuelos = new List<Vuelos>();
        public FormVuelos()
        {
            InitializeComponent();
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text.Trim());
                string origen = txtOrigen.Text.Trim();
                string destino = txtDestino.Text.Trim();
                DateTime fecha_salida = DateTime.Parse(txtFecha.Text);
                int cant_disponible = int.Parse(txtNumDis.Text.Trim());

                //Creacion nuevo vuelo de clase Vuelos

                Vuelos new_vuelo = new Vuelos(codigo, origen, destino, fecha_salida, cant_disponible);

                //Añadir vuelo en la lista

                lista_vuelos.Add(new_vuelo);

                listBox.Items.Add(new_vuelo);

                txtCodigo.Clear();
                txtOrigen.Clear();
                txtDestino.Clear();
                txtFecha.Clear();
                txtNumDis.Clear();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttForm2_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas(lista_vuelos);
            formReservas.Show();
        }
    }
}
