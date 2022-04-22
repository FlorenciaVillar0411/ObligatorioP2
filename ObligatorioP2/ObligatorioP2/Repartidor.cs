using System;
namespace ObligatorioP2
{
    public class Repartidor : Persona
    {

        public Vehiculos Vehiculo { get; set; }


        public enum Vehiculos
        {
            Moto,
            Bicicleta,
            APie,
        }

        public Repartidor()
        {
        }

        public Repartidor(string nombre, string apellido, Vehiculos vehiculo)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Vehiculo = vehiculo;
        }
    }
}
