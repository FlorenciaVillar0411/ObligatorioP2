using System;
namespace ObligatorioP2
{
    public class Local : Servicio
    {

        public int NumeroMesa { get; set; }

        public Mozo Mozo { get; set; }

        public int CantidadComensales { get; set; }

        public static double PrecioCubierto { get; set; }

        public Local()
        {
        }

        public Local(Cliente cliente, DateTime fecha, int numeroMesa, Mozo mozo, int cantidadComensales)
        {
            Id = UltimoId;
            UltimoId++;
            Cliente = cliente;
            Fecha = fecha;
            NumeroMesa = numeroMesa;
            Mozo = mozo;
            CantidadComensales = cantidadComensales;
        }

        public override double CalcularPrecio()
        {
            double sumaMontos = base.CalcularPrecio();

            double propina = sumaMontos * 0.1;

            sumaMontos += propina + PrecioCubierto * CantidadComensales;

            return sumaMontos;
        }
    }
}
