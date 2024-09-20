using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViaje.classes
{
    internal class Reserva
    {
        public Paquete Paquete { get; set; }
        public int CantidadPersonas { get; set; }
        public Reserva(Paquete paquete, int cantidadPersonas)
        {
            Paquete = paquete;
            CantidadPersonas = cantidadPersonas;
        }
        public decimal CalcularTotal()
        {
            return Paquete.Precio * CantidadPersonas;
        }
        public void ValidarCupos()
        {
            if (CantidadPersonas > 3)
            {
                Console.WriteLine("Cupos no disponibles");
            }
        }
    }
}
