using System;
namespace ObligatorioP2
{
    public class Cliente : Persona
    {

        public string Email { get; set; }

        public string Password { get; set; }


        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, string email, string password)
        {
            Id = UltimoId;
            UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
        }

        public override bool EsValido()
        {
            bool esValido = false;
            bool esValidoCliente = false;
            bool hayArroba = false;
            bool hayNum = false;
            bool hayMayus = false;
            bool hayMinus = false;

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
    
            for (int i = 1; i < Email.Length - 1; i++)
            {
                char caracter = Email[i];
                if (caracter.Equals("@"))
                {
                    hayArroba = true;
                }
            }
            if (Password.Length >= 6)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    char caracter = Password[i];
                    if (Char.IsNumber(caracter))
                    {
                        hayNum = true;
                    }
                    if (Char.ToUpper(caracter) == caracter)
                    {
                        hayMayus = true;
                    }
                    if (Char.ToLower(caracter) == caracter)
                    {
                        hayMinus = true;
                    }

                }

            }

            if (hayArroba && hayNum && hayMinus && hayMayus && esValido)
            {
                esValidoCliente = true;
            }

            return esValidoCliente;
        }


    }
}

        //Validaciones en IValidacion

        // - nombre y apellido
        // - email
        // - password
    }
}
