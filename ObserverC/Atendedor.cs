using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    class Atendedor : Observer
    {
        string nombre;
        Turnero turnero;
        int totalClientesEnEspera;
        public Atendedor(string Nombre,Turnero turnero)
        {
            this.nombre = Nombre;
            turnero.RegisterObserver(this);
            this.turnero = turnero;
        }
        internal Cliente Cliente { get; set; }
        public void LlamarCliente()
        {
            if (totalClientesEnEspera > 0)
                turnero.LlamarCliente(this);
        }
        public void Update(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            totalClientesEnEspera = TotalClientesEnEspera;
            ActualizarPantalla();
        }
        private void ActualizarPantalla()
        {
            Console.WriteLine(this + " dice: hay {0} clientes en espera", totalClientesEnEspera);
        }
        public override string ToString()
        {
            return nombre;
        }
        ~Atendedor()
        {
            turnero.RemoveObserver(this);
        }
    }
}