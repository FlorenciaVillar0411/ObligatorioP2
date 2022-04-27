using System;
using System.Collections.Generic;

namespace ObligatorioP2
{
    public class System
    {
        
            public class Sistema
        {
            private List<Plato> platos = new List<Plato>();
            private List<Persona> personas = new List<Persona>();
            private List<Servicio> servicios = new List<Servicio>();

            public Sistema()
            {
                PreCarga();
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
                if (m.EsValido() && NumeroFuncionarioEsValido(m.NumeroFuncionario))
                //Porque no capta funcion de IValidacion??
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
                //Porque no capta funcion de IValidacion??
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


            public bool NumeroFuncionarioEsValido(int numero)   //ESTÁ BIEN ESTO?
            {
                bool esValido = true;
                foreach (Mozo m in personas)
                {
                    if (m.NumeroFuncionario == numero)
                    {
                        esValido = false;
                    }

                }
                return esValido;
            }



            //PRECARGA

            private void PreCarga()
            {
                Cliente c1 = new Cliente("Juan", "Gonzalez", "juan19@gmail.com", "Juan3456");
                Cliente c2 = new Cliente("Romina", "Lopez", "romina19@gmail.com", "Romina3456");
                Cliente c3 = new Cliente("Claudia", "Pereira", "claudia19@gmail.com", "Claudia3456");
                Cliente c4 = new Cliente("Facundo", "Moreira", "facundo19@gmail.com", "Facundo3456");
                Cliente c5 = new Cliente("Florencia", "Martinez", "florencia19@gmail.com", "Florencia3456");

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
                Repartidor r2 = new Repartidor("Gonzalo", "Ramirez", Repartidor.Vehiculos.Bicicleta);
                Repartidor r3 = new Repartidor("Maria", "Gutierrez", Repartidor.Vehiculos.Moto);
                Repartidor r4 = new Repartidor("Rossana", "Villar", Repartidor.Vehiculos.Moto);
                Repartidor r5 = new Repartidor("Ana", "Cubero", Repartidor.Vehiculos.APie);

                Delivery d1 = new Delivery(c1, new DateTime(2022-1-15), "Ramirez 123", r1, 12);
                servicios.Add(d1);
                Delivery d2 = new Delivery(c2, new DateTime(2022-4-14), "Bolivar 456", r2, 5);
                servicios.Add(d2);
                Delivery d3 = new Delivery(c3, new DateTime(2022-3-20), "Bolivia 789", r3, 9);
                servicios.Add(d3);
                Delivery d4 = new Delivery(c4, new DateTime(2022-12-30), "Nin y Silva 123", r4, 22);
                servicios.Add(d4);
                Delivery d5 = new Delivery(c5, new DateTime(2022-9-2), "Rivera 426", r5, 11);
                servicios.Add(d5);


                Local l1 = new Local(c1, new DateTime(2022 - 01 - 01), 1, m4, 7);
                servicios.Add(l1);
                Local l2 = new Local(c3, new DateTime(2022 - 02 - 08), 3, m5, 2);
                servicios.Add(l2);
                Local l3 = new Local(c2, new DateTime(2021 - 01 - 07), 4, m1, 1);
                servicios.Add(l3);
                Local l4 = new Local(c5, new DateTime(2021 - 05 - 25), 2, m3, 5);
                servicios.Add(l4);
                Local l5 = new Local(c5, new DateTime(2022 - 03 - 26), 4, m2, 4);
                servicios.Add(l5);
            }
        }
    }
}
 