using System;
using System.Collections.Generic;
using System.Text;
namespace ObserverC
{
    class Turnero : Subject
    {
        List<Observer> observers;
        Queue<Cliente> clientesEnEspera;
        LinkedList<Atendedor> atendedores;
        public Turnero()
        {
            observers = new List<Observer>();
            clientesEnEspera = new Queue<Cliente>();
            atendedores = new LinkedList<Atendedor>();
        }
        public void NotifyObservers()
        {
            foreach (Observer item in observers)
            {
                item.Update(clientesEnEspera.Count, atendedores);
            }
        }

        internal void LlamarCliente(Atendedor atendedor)
        {
            if (clientesEnEspera.Count > 0)
            {
                Console.WriteLine(atendedor + " llama un cliente");
                if (atendedores.Contains(atendedor))
                    atendedores.Remove(atendedor);
                atendedor.Cliente = clientesEnEspera.Dequeue();
                atendedores.AddFirst(atendedor);
                NotifyObservers();
            }
        }
        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void AddCliente(Cliente cliente)
        {
            Console.WriteLine("Ingresa cliente: " + cliente);
            clientesEnEspera.Enqueue(cliente);
            NotifyObservers();
        }
    }
}