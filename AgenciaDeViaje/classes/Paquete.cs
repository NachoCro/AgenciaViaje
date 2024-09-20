using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViaje.classes
{
    internal class Paquete
    {
        public string Destino { get; set; }
        public decimal Precio { get; set; }
        public Paquete(string destino, decimal precio)
        {
            Destino = destino;
            Precio = precio;
        }
        public void MostrarPaqueta()
        {
            Console.WriteLine($"Destino: {Destino}\nPrecio: {Precio}");
        }
    }
}
