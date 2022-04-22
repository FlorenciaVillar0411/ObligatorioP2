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

        //Validaciones en IValidacion

        // - nombre y apellido
        // - email
        // - password
    }
}
