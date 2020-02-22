using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    class Visor : Observer
    {
        Turnero turnero;

        public Visor(Turnero turnero)
        {
            this.turnero = turnero;
            turnero.RegisterObserver(this);
        }
        public void Update(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            ActualizarVisor(TotalClientesEnEspera, atendedores);
        }
        private static void ActualizarVisor(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            Console.WriteLine("Lista de atendidos");
            foreach (Atendedor item in atendedores)
            {
                Console.WriteLine(item + "  " + item.Cliente);
            };
            Console.WriteLine("Total clientes en espera: " + TotalClientesEnEspera);
        }
    }
}