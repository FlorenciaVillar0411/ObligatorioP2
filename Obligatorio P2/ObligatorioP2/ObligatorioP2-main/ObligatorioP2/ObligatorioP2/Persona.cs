using System;
namespace ObligatorioP2
{
    public class Persona
    {
        public int Id { get; set; }

        public static int UltimoId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }


        public Persona()
        {
        }

        public Persona(string nombre, string apellido)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
