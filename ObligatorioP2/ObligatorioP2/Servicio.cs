using System;
using System.Collections.Generic;

namespace ObligatorioP2
{
    public class Servicio
    {
        public int Id { get; set; }

        public static int UltimoId { get; set; }

        public Cliente Cliente { get; set; }

        private List<PlatoCantidad> platos = new List<PlatoCantidad>();

        public DateTime Fecha { get; set; }



        public Servicio()
        {
        }

        public Servicio(Cliente cliente, DateTime fecha)
        {
            Id = UltimoId;
            UltimoId++;
            Cliente = cliente;
            Fecha = fecha;
        }


        public virtual double CalcularPrecio()
        {
            double sumaMontos = 0;

            foreach (PlatoCantidad pc in platos)
            {
                sumaMontos += pc.Plato.Precio * pc.Cantidad;
            }
            return sumaMontos;
        }

        

    }
}
