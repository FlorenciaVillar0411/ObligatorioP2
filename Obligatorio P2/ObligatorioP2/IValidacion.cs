using System;
namespace ObligatorioP2
{
    interface IValidacion
    {
        public bool EsValido();



        //
        //    bool esValido = false;

        //    if(nombre != "" && apellido != "")
        //    {
        //        esValido = true;

        //        for (int i = 0; i < nombre.Length; i++)
        //        {
        //            char caracter = nombre[i];
        //            if (Char.IsNumber(caracter))
        //            {
        //                esValido = false;
        //            }
        //        }

        //        for (int i = 0; i < apellido.Length; i++)
        //        {
        //            char caracter2 = apellido[i];
        //            if (Char.IsNumber(caracter2))
        //            {
        //                esValido = false;
        //            }
        //        }


        //    }


        //    return esValido;
        //}

        //public bool emailypasswordsonvalidos(string email, string password)
        //{
        //    bool esvalido = false;
        //    bool hayarroba = false;


        //    for (int i = 1; i < email.length - 1; i++)
        //    {
        //        char caracter = email[i];
        //        if (caracter.equals("@"))
        //        {
        //            hayarroba = true;
        //        }
        //    }
        //    if (password.length >= 6)
        //    {
        //        for (int i = 0; i < password.length; i++)
        //        {
        //            char caracter = password[i];
        //            if (caracter.equals("@"))
        //            {
        //                hayarroba = true;
        //            }
        //        }



        //    }

        //    if (hayarroba)
        //    {
        //        esvalido = true;
        //    }

        //    return esvalido;
        //}


    }
}
