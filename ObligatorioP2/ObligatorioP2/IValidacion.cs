using System;
namespace ObligatorioP2
{
    interface IValidacion
    {
        public bool NombreYApellidoSonValidos(string nombre, string apellido)
        {
            bool esValido = false;

            if(nombre != "" && apellido != "")
            {
                esValido = true;

                for (int i = 0; i < nombre.Length; i++)
                {
                    char caracter = nombre[i];
                    if (Char.IsNumber(caracter))
                    {
                        esValido = false;
                    }
                }

                for (int i = 0; i < apellido.Length; i++)
                {
                    char caracter2 = apellido[i];
                    if (Char.IsNumber(caracter2))
                    {
                        esValido = false;
                    }
                }


            }


            return esValido;
        }

        public bool EmailYPasswordSonValidos(string email, string password)
        {
            bool esValido = false;
            bool hayArroba = false;


            for (int i = 1; i < email.Length -1; i++)
            {
                char caracter = email[i];
                if (caracter.Equals("@"))
                {
                    hayArroba = true;
                }
            }
            if (password.Length >= 6)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    char caracter = password[i];
                    if (caracter.Equals("@"))
                    {
                        hayArroba = true;
                    }
                }



            }




            if (hayArroba)
            {
                esValido = true;
            }

            return esValido;
        }


    }
}
