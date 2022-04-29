using System;
using System.Collections.Generic;



namespace ObligatorioP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Una receta: 
            System s = new System();

            int op = -1;
            while (op != 0)
            {
                MostrarMenu();
                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Listar platos");

                        List<Plato> listaPlatos = s.GetPlatos();

                        if (listaPlatos.Count > 0)
                        {

                            foreach (Plato p in listaPlatos)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay registros");
                        }


                       
                        Console.ReadKey();
                        break;

                    case 2:

                        List<Cliente> ListaOrdenada = s.GetClientesOrdenados();

                        if (ListaOrdenada.Count > 0)
                        {

                            foreach (Cliente c in ListaOrdenada)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay registros");
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Ingrese ID del Repartidor");
                        int num = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese fecha 1(AAAA-MM-DD)");
                        DateTime fecha1 = DateTime.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese fecha 2(AAAA-MM-DD)");
                        DateTime fecha2 = DateTime.Parse(Console.ReadLine());



                        List<Delivery> listaDeliverys = s.GetServiciosPorRepartidorEntreFechas(s.GetRepartidorPorId(num), fecha1, fecha2);

                        if (listaDeliverys.Count > 0)
                        {

                            foreach (Delivery d in listaDeliverys)
                            {
                                Console.WriteLine(d.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay registros");
                        }
                        Console.ReadKey();


                        break;

                        //case 4:
                        //    Console.WriteLine("Ingrese un monto");
                        //    double monto1 = Double.Parse(Console.ReadLine());

                        //    Console.WriteLine("Fecha de inicio");
                        //    DateTime f1 = DateTime.Parse(Console.ReadLine());

                        //    Console.WriteLine("Fecha de fin");
                        //    DateTime f2 = DateTime.Parse(Console.ReadLine());

                        //    List<Venta> ListaFiltrada2 = s.GetVentasSuperenEntreFechas(monto1, f1, f2);

                        //    if (ListaFiltrada2.Count > 0)
                        //    {

                        //        foreach (Venta v in ListaFiltrada2)
                        //        {
                        //            Console.WriteLine(v);
                        //        }
                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("No hay registros");
                        //    }

                        //    break;

                        //case 5:

                        //    foreach (Cliente c in s.GetClientes())
                        //    {
                        //        Console.WriteLine(c);
                        //    }
                        //    Console.ReadKey();
                        //    break;

                        //case 6:

                        //    Console.WriteLine("Ingrese el nombre del juego");
                        //    string nombreJuego = Console.ReadLine();

                        //    List<Cliente> ClientesCompraron = s.GetClientesHayanComprado(nombreJuego);

                        //    if (ClientesCompraron.Count > 0)
                        //    {
                        //        foreach (Cliente c in ClientesCompraron)
                        //        {
                        //            Console.WriteLine(c);
                        //        }

                        //    }
                        //    else
                        //    {
                        //        Console.WriteLine("No hay registros");
                        //    }
                        //    Console.ReadKey();
                        //    break;



                }


            }

        }
        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("### SISTEMA RESTAURANTE ###");
            Console.WriteLine("1 - Listar Platos");
            Console.WriteLine("2 - Listar Clientes Ordenados por apellido/nombre");
            Console.WriteLine("3 - Listar servicios dado un repartidor y un rango de fechas");
            Console.WriteLine("4 - Juegos que superen un monto dado entre fechas");
            Console.WriteLine("5 - Listar clientes");
            Console.WriteLine("6 - Listar clientes que al menos hayan comprado un juego dado");

        }

    }
}

            //    List<Cliente> ListaOrdenada = s.GetClientesOrdenados();

            //if (ListaOrdenada.Count > 0)
            //{

            //    foreach (Cliente c in ListaOrdenada)
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No hay registros");
            //}