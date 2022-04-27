using System;
namespace ObligatorioP2
{
    public class PlatoCantidad
    {
        public Plato Plato { get; set; }

        public int Cantidad { get; set; }



        public PlatoCantidad()
        {
        }

        public PlatoCantidad(Plato plato, int cantidad)
        {

            Plato = plato;
            Cantidad = cantidad;
        }
    }
}
