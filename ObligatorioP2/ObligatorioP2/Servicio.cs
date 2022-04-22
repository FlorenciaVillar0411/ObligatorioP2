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
                sumaMontos += pc.Plato.Precio * pc.Cantidad);
            }
            return sumaMontos;
        }

        //public double CalcularCostoFinal()
        //{
        //    // 1 - Sumar tods los costos de los juegos, teniendo en cuenta las cantidades.
        //    // 2 - Aplico el descuento correspondiente al Cliente
        //    // 3 - Aplicamos el descuento correspondiente al cupon del dia.

        //    double sumaMontos = 0;

        //    foreach (JuegoCantidad jc in carrito)
        //    {
        //        sumaMontos = sumaMontos + jc.Juego.PrecioLista * jc.Cantidad);

        //    }
        //    sumaMontos = sumaMontos * Cliente.CalcularDescuento();
        //    sumaMontos = sumaMontos * Cupon;
        //    return sumaMontos;
        //}

    }
}
