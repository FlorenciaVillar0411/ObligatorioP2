using System;
namespace ObligatorioP2
{
    public class Mozo : Persona
    {
       

        public int NumeroFuncionario { get; set; }


        public Mozo()
        {
        }

        public Mozo(string nombre, string apellido, int numeroFuncionario)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            NumeroFuncionario = numeroFuncionario;
        }

        //IValidacion de numero
    }
}
