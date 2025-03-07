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
    public partial class FormReservas : Form
    {
        //Lista de vuelos recibido del forms de vuelos
        public List<Vuelos> lista_vuelos;
        public FormReservas(List<Vuelos> vuelos) //recibe como parametro una lista de vuelos
        {
            InitializeComponent();
           lista_vuelos = vuelos; //generamos constructor vuelos y guardamos la lista que viene de formVuelos como variable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigoReserva.Text);
                int cant_Reserva = int.Parse(txtCantReserva.Text);


                //Validacion de que el vuelo exista
                Vuelos vuelo = lista_vuelos.FirstOrDefault(v => v.codigo == codigo);

                if (vuelo == null)
                {
                    throw new Exception("No se encontro el vuelo");
                }

                //Llamado a metodo de reservar asientos
                vuelo.ReservarAsientos(cant_Reserva);

                listBoxReserva.Items.Add(vuelo);

                txtCodigoReserva.Clear();
                txtCantReserva.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
