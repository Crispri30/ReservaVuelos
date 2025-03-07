using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ReservaVuelos
{
    public class Vuelos
    {

        public int codigo { get; set;}
        public string origen { get; set;}
        public string destino { get; set;}
        public DateTime fecha_salida { get; set;}
        public int cant_disponible { get; set;}

        public Vuelos(int codigo, string origen, string destino, DateTime fecha_salida, int cant_disponible)
        {
            this.codigo = codigo;
            this.origen = origen;
            this.destino = destino;
            this.fecha_salida = fecha_salida;
            this.cant_disponible =  cant_disponible;
        }
        public override string ToString()
        {
            return $"{codigo} - {origen} - {destino} - {fecha_salida} - {cant_disponible}";
        }

        public bool ReservarAsientos(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad de asientos a reservar debe ser mayor a 0.");
            }

            if (cantidad > cant_disponible)
            {
                throw new InvalidOperationException("No hay suficientes asientos disponibles.");
            }

            cant_disponible -= cantidad;
            MessageBox.Show("Reserva exitosa.");
            return true; // Reserva exitosa
        }
    }
}
