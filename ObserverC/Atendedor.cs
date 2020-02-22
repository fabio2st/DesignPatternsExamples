using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    class Atendedor : Observer
    {
        string nombre;
        Turnero turnero;
        int totalClientes;
        public Atendedor(string Nombre,Turnero turnero)
        {
            this.nombre = Nombre;
            this.turnero = turnero;
            turnero.RegisterObserver(this);
        }
      internal Cliente Cliente { get; set; }
        public void LlamarCliente()
        {
            if (totalClientes > 0)
                turnero.LlamarCliente(this);
        }
        public void Update(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores)
        {
            totalClientes = TotalClientesEnEspera;
        }
        public override string ToString()
        {
            return nombre;
        }

    }
}