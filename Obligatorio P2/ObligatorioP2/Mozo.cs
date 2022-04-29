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

        public override string ToString()
        {

            return $"{Apellido},{Nombre}.           ";

        }
    }
}
