using AgenciaDeViaje.classes;
namespace AgenciaDeViaje {
    class Program
    {
        static void Main()
        {
            List<Reserva> reservas = new List<Reserva>
            {
                new Reserva(new Paquete("LasToninas", 123),12),
                new Reserva(new Paquete("Rio de janeiro", 20),3)
            };
            Cliente Juan = new Cliente("Juan", reservas);
        }
    }
}