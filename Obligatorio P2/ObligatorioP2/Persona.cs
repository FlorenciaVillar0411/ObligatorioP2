using System;
using System.Diagnostics.CodeAnalysis;

namespace ObligatorioP2
{
    public abstract class Persona : IValidacion, IComparable<Persona> 
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

        public int CompareTo([AllowNull] Persona other)
        {
            if(Apellido.CompareTo(other.Apellido) > 0)
            {
                return 1;
            }
            else if(Apellido.CompareTo(other.Apellido) < 0)
            {
                return -1;
            }
            else
            {
                if(Nombre.CompareTo(other.Nombre) > 0)
                {
                    return 1;
                }
                else if(Nombre.CompareTo(other.Nombre) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public abstract bool EsValido();
        
        
    }
}
