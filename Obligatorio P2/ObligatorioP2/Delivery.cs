using System;
namespace ObligatorioP2
{
    public class Delivery : Servicio
    {
        public string Dirección { get; set; }

        public Repartidor Repartidor { get; set; }

        public double DistanciaKM { get; set; }


        public Delivery()
        {
        }

        public Delivery(Cliente cliente, DateTime fecha, string dirección, Repartidor repartidor, int distanciaKM)
        {
            Id = UltimoId;
            UltimoId++;
            Cliente = cliente;
            Fecha = fecha;
            Dirección = dirección;
            Repartidor = repartidor;
            DistanciaKM = distanciaKM;
        }

        public override double CalcularPrecio()
        {
            double sumaMontos = base.CalcularPrecio();

            double costoEnvio;

            if (DistanciaKM < 2)
            {
                costoEnvio = 50;
            }
            else
            {
                double distancia = Math.Round(DistanciaKM);

                double costoExtraDistancia = distancia * 10 - 10;

                costoEnvio = costoExtraDistancia;
            }

            if(sumaMontos > 100)
            {
                costoEnvio = 100;
            }

            return sumaMontos + costoEnvio;
        }

        public override string ToString()
        {
            return $"Servicio para: {Cliente.Nombre}, en la fecha: {Fecha}.";
        }
    }
}
