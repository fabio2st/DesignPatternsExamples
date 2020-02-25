using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    class Visor : Observer
    {
        Turnero turnero;
        string nombre;

        public Visor(string nombre, Turnero turnero)
        {
            this.nombre = nombre;
            turnero.RegisterObserver(this);
            this.turnero = turnero;
        }
        public void Update(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            ActualizarPantalla(TotalClientesEnEspera, atendedores);
        }
        private void ActualizarPantalla(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            Console.WriteLine(nombre + " dice");
            foreach (Atendedor item in atendedores)
            {
                Console.WriteLine(item + "  " + item.Cliente);
            };
            Console.WriteLine("Total clientes en espera: " + TotalClientesEnEspera);
        }
        public override string ToString()
        {
            return nombre;
        }
        ~Visor()
        {
            turnero.RemoveObserver(this);
        }
    }
}