using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViaje.classes
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public List<Reserva> Reservas { get; set; }

        public Cliente(string nombre, List<Reserva> reservas) {
            Nombre = nombre;
            Reservas = reservas;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Cliente: {Nombre}");
            foreach (var reserva in Reservas)
            {
                Console.WriteLine($"Paquete Reservado: {reserva.Paquete.Destino}");
            }
        }
    }
}
