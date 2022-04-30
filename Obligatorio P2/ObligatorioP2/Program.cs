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

                        case 4:
                            double precioMinimoActual = Plato.PrecioMinimo;
                            Console.WriteLine($"El precio mínimo actual es: {precioMinimoActual}");

                            Console.WriteLine("Ingrese nuevo precio mínimo del plato");
                            double precioNuevo = Double.Parse(Console.ReadLine());
                            bool precioCambiado = s.ModificarPrecioMinimoPlato(precioNuevo);


                        if (precioCambiado) 
                        {
                            Console.WriteLine($"El nuevo precio mínimo es : {precioNuevo}");

                        }
                        else
                        {
                            Console.WriteLine("No se cambia el precio");
                        }
                        Console.ReadKey();


                        break;

                    case 5:

                        Console.WriteLine("Ingrese el nombre del Mozo");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese el apellido del Mozo");
                        string apellido = Console.ReadLine();

                        Console.WriteLine("Ingrese número de funcionario");
                        int nroFuncionario = Int32.Parse(Console.ReadLine());

                        Mozo m = new Mozo(nombre, apellido, nroFuncionario);

                        if (s.AltaMozo(m) != null)
                        {
                            Console.WriteLine($"El nuevo mozo es: {m}");

                        }
                        else
                        {
                            Console.WriteLine("El mozo no se puede registrar - verifique que los campos se hayan completado o cambie el número de funcionario");
                        }
                        Console.ReadKey();


                        break;


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
            Console.WriteLine("4 - Cambiar precio mínimo del plato");
            Console.WriteLine("5 - Dar de alta un mozo");

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