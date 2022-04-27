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

        public override bool EsValido()
        {
            bool esValido = false;

            if (Nombre != "" && Apellido != "")
            {
                esValido = true;

                for (int i = 0; i < Nombre.Length; i++)
                {
                    char caracter = Nombre[i];
                    if (Char.IsNumber(caracter))
                    {
                        esValido = false;
                    }
                }

                for (int i = 0; i < Apellido.Length; i++)
                {
                    char caracter2 = Apellido[i];
                    if (Char.IsNumber(caracter2))
                    {
                        esValido = false;
                    }
                }


            }
            return esValido;
        }
    }
}
