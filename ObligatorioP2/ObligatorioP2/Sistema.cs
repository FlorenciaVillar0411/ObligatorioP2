using System;
using System.Collections.Generic;

namespace ObligatorioP2
{
    public class Sistema
    {
        private List<Plato> platos = new List<Plato>();
        private List<Persona> personas = new List<Persona>();
        private List<Servicio> servicios = new List<Servicio>();

        public Sistema()
        {
        }


        public List<Persona> GetClientesOrdenados()
        {
            return personas;
            //Hay que devolver solo los clientes
        }

        public List<Plato> GetPlatos()
        {
            return platos;
        }

        public List<Servicio> GetServiciosPorRepartidorEntreFechas(Repartidor repartidor, DateTime fecha1, DateTime fecha2)
        {
            return servicios;
        }

        public bool ModificarPrecioMinimoPlato(double precioNuevo)
        {
            Plato.PrecioMinimo = precioNuevo;
            return true;

        }

        public Mozo AltaMozo(string nombre, string apellido, int numeroFuncionario)
        {
            Mozo nuevo = null;
            if (nombre != "" && apellido != "") //Con interfaZ!! CAMBIAR
            {
                nuevo = new Mozo( nombre, apellido, numeroFuncionario);

            }
            return nuevo;

        }

        //PRECARGA
    }
}
