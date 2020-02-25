using System;

namespace ObserverC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Turnero!");
            Turnero turnero = new Turnero();
            Visor visor1 = new Visor("Pantalla Principal",turnero: turnero);
            Visor visor2 = new Visor("Pantalla secundaria", turnero: turnero);
            Atendedor atendedor1 = new Atendedor("Box 1", turnero);
            Atendedor atendedor2 = new Atendedor("Box 2", turnero);
            turnero.AddCliente(new Cliente("Pepe"));
            turnero.AddCliente(new Cliente("Pepa"));
            turnero.AddCliente(new Cliente("Juan"));
            atendedor1.LlamarCliente();
            atendedor2.LlamarCliente();
            atendedor1.LlamarCliente();
            turnero.AddCliente(new Cliente("Juana"));
            atendedor2.LlamarCliente();
            atendedor1.LlamarCliente();
        }
    }
}