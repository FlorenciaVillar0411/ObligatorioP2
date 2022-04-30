using System;
using System.Collections.Generic;


namespace ObligatorioP2
{
    public class System
    {



        private List<Plato> platos = new List<Plato>();
        private List<Persona> personas = new List<Persona>();
        private List<Servicio> servicios = new List<Servicio>();

        public System()
        {
            PreCarga();
        }




        public List<Cliente> GetClientesOrdenados()
        {

            List<Cliente> clientesOrdenados = new List<Cliente>();

            foreach (Persona p in personas)
            {
                if (p is Cliente)
                {
                    Cliente aux = p as Cliente;
                    clientesOrdenados.Add(aux);
                }
            }
            clientesOrdenados.Sort();

            return clientesOrdenados;
        }

        public List<Mozo> GetMozos()
        {

            List<Mozo> ret = new List<Mozo>();
            foreach (Persona p in personas)
            {
                if (p is Mozo)
                {
                    Mozo aux = p as Mozo;
                    ret.Add(aux);
                }
            }
            
            return ret;
        }

        public List<Repartidor> GetRepartidores()
        {

            List<Repartidor> ret = new List<Repartidor>();
            foreach (Persona p in personas)
            {
                if (p is Repartidor)
                {
                    Repartidor aux = p as Repartidor;
                    ret.Add(aux);
                }
            }

            return ret;
        }


        public List<Plato> GetPlatos()
        {
            
            return platos;
        }

        //PONER EN UML
        public List<Delivery> GetDeliveries()
        {
            List<Delivery> ret = new List<Delivery>();
            foreach (Servicio s in servicios)
            {
                if (s is Delivery)
                {
                    Delivery aux = s as Delivery;
                    ret.Add(aux);
                }
            }
            
            return ret;
        }

        public Repartidor GetRepartidorPorId(int num)
        {
            Repartidor ret = null;
            List<Repartidor> repartidores = GetRepartidores();

            foreach (Repartidor r in repartidores)
            {
                if(r.Id.Equals(num))
                {
                    ret = r;
                }
            }

            return ret;
        }


        public List<Delivery> GetServiciosPorRepartidorEntreFechas(Repartidor repartidor, DateTime fecha1, DateTime fecha2)
        {
            List<Delivery> ret = new List<Delivery>();

            List<Delivery> deliverys = GetDeliveries();
            foreach (Delivery d in deliverys)
            {
                if (repartidor == d.Repartidor)
                {
                    if (d.Fecha >= fecha1 && d.Fecha <= fecha2)
                    {
                        ret.Add(d);
                    }
                }
            }

            return ret;
        }



        public bool ModificarPrecioMinimoPlato(double precioNuevo)
        {
            if (precioNuevo != Plato.PrecioMinimo && precioNuevo>=0)
            {
            Plato.PrecioMinimo = precioNuevo;
            return true;

            }
            return false;
        }

        //public Mozo AltaMozo(string nombre, string apellido, int numeroFuncionario)
        //{
        //    Mozo m = new Mozo(nombre,apellido,numeroFuncionario);
        //    Mozo nuevo = null;
        //    if (m.EsValido() && NumeroFuncionarioEsValido(numeroFuncionario))
        //    //Porque no capta funcion de IValidacion??
        //    {
        //        nuevo = new Mozo(nombre, apellido, numeroFuncionario);
        //        personas.Add(nuevo);

        //    }
        //    return nuevo;

        //}
        public Mozo AltaMozo(Mozo m)
        {
            Mozo nuevo = null;
            if (m.EsValido() && !NumeroFuncionarioExiste(m.NumeroFuncionario))
            {
                nuevo = m;
                personas.Add(nuevo);

            }
            return nuevo;

        }
        public Repartidor AltaRepartidor(Repartidor r)
        {
            Repartidor nuevo = null;
            if (r.EsValido())
            {
                nuevo = r;
                personas.Add(nuevo);

            }
            return nuevo;

        }
        public Plato AltaPlato(Plato p)
        {
            if (p.EsValido())
            {
                platos.Add(p);
                return p;
            }
            return null;
        }

        public Cliente AltaCliente(Cliente c)
        {
            if (c.EsValido())
            {
                personas.Add(c);
                return c;
            }
            return null;
        }


        public bool NumeroFuncionarioExiste(int numero)   //ESTÁ BIEN ESTO?
        {
            bool numExiste = false;
            foreach (Persona m in personas)
            {
                if (m is Mozo)
                {
                    Mozo aux = m as Mozo;

                    if (aux.NumeroFuncionario == numero)
                    {
                        numExiste = true;
                    }

                }
            }

            return numExiste;
        }

            private void PreCarga()
            {
                Cliente c1 = new Cliente("Juan", "Gonzalez", "juan19@gmail.com", "Juan3456");
                AltaCliente(c1);

                Cliente c2 = new Cliente("Romina", "Lopez", "romina19@gmail.com", "Romina3456");
                AltaCliente(c2);

                Cliente c3 = new Cliente("Claudia", "Pereira", "claudia19@gmail.com", "Claudia3456");
                AltaCliente(c3);

                Cliente c4 = new Cliente("Facundo", "Moreira", "facundo19@gmail.com", "Facundo3456");
                AltaCliente(c4);

                Cliente c5 = new Cliente("Florencia", "Martinez", "florencia19@gmail.com", "Florencia3456");
                AltaCliente(c5);


                Mozo m1 = new Mozo("Pedro", "Fagundez", 1);
                AltaMozo(m1);
                Mozo m2 = new Mozo("Leandro", "Sanchez", 2);
                AltaMozo(m2);
                Mozo m3 = new Mozo("Lorena", "Varela", 3);
                AltaMozo(m3);
                Mozo m4 = new Mozo("Paola", "Pacheco", 4);
                AltaMozo(m4);
                Mozo m5 = new Mozo("Santiago", "Benitez", 5);
                AltaMozo(m5);

                Repartidor r1 = new Repartidor("Javier", "Perez", Repartidor.Vehiculos.APie);
                AltaRepartidor(r1);
                Repartidor r2 = new Repartidor("Gonzalo", "Ramirez", Repartidor.Vehiculos.Bicicleta);
                AltaRepartidor(r2);

                Repartidor r3 = new Repartidor("Maria", "Gutierrez", Repartidor.Vehiculos.Moto);
                AltaRepartidor(r3);

                Repartidor r4 = new Repartidor("Rossana", "Villar", Repartidor.Vehiculos.Moto);
                AltaRepartidor(r4);

                Repartidor r5 = new Repartidor("Ana", "Cubero", Repartidor.Vehiculos.APie);
                AltaRepartidor(r5);


                Delivery d1 = new Delivery(c1, DateTime.Parse("2022-03-03"), "Ramirez 123", r1, 12);
                servicios.Add(d1);
                Delivery d2 = new Delivery(c2, DateTime.Parse("2021-03-03"), "Bolivar 456", r2, 5);
                servicios.Add(d2);
                Delivery d3 = new Delivery(c3, DateTime.Parse("2021-04-03"), "Bolivia 789", r3, 9);
                servicios.Add(d3);
                Delivery d4 = new Delivery(c4, DateTime.Parse("2021-09-23"), "Nin y Silva 123", r4, 22);
                servicios.Add(d4);
                Delivery d5 = new Delivery(c5, DateTime.Parse("2022-01-30"), "Rivera 426", r5, 11);
                servicios.Add(d5);


                Local l1 = new Local(c1, DateTime.Parse("2021-03-03"), 1, m4, 7);
                servicios.Add(l1);
                Local l2 = new Local(c3, DateTime.Parse("2022-07-15"), 3, m5, 2);
                servicios.Add(l2);
                Local l3 = new Local(c2, DateTime.Parse("2020-10-19"), 4, m1, 1);
                servicios.Add(l3);
                Local l4 = new Local(c5, DateTime.Parse("2021-12-01"), 2, m3, 5);
                servicios.Add(l4);
                Local l5 = new Local(c5, DateTime.Parse("2021-08-23"), 4, m2, 4);
                servicios.Add(l5);


                Plato p1 = new Plato("Milanesa", 345);
                AltaPlato(p1);

                Plato p2 = new Plato("Pollo", 405);
                AltaPlato(p2);

                Plato p3 = new Plato("Ensalada", 250);
                AltaPlato(p3);

                Plato p4 = new Plato("Hamburguesa al plato", 180);
                AltaPlato(p4);

                Plato p5 = new Plato("Nuggets", 250);
                AltaPlato(p5);

                Plato p6 = new Plato("Guiso", 450);
                AltaPlato(p6);

                Plato p7 = new Plato("Nioqui", 370);
                AltaPlato(p7);

                Plato p8 = new Plato("Pascualina", 180);
                AltaPlato(p8);

                Plato p9 = new Plato("Canelones de carne", 270);
                AltaPlato(p9);

                Plato p10 = new Plato("Lasagna", 410);
                AltaPlato(p10);
            }
        }
    }

 