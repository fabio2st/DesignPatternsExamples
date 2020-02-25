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
        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
            Console.WriteLine("Se registro observador: " + observer);
       }
        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
            Console.WriteLine("Se removio observador: " + observer);
        }
        public void NotifyObservers()
        {
            foreach (Observer item in observers)
            {
                item.Update(clientesEnEspera.Count, atendedores);
            }
        }
        public void AddCliente(Cliente cliente)
        {
            Console.WriteLine("Ingresa cliente: " + cliente);
            clientesEnEspera.Enqueue(cliente);
            NotifyObservers();
        }
        internal void LlamarCliente(Atendedor atendedor)
        {
            if (clientesEnEspera.Count > 0)
            {
                Console.WriteLine(atendedor + " llama un cliente");
                // Si el atendedor esta en la lista primero se lo elimina para evitar redundancia
                if (atendedores.Contains(atendedor))
                    atendedores.Remove(atendedor);
                atendedor.Cliente = clientesEnEspera.Dequeue();
                // ultimo atendedor al tope de la lista
                atendedores.AddFirst(atendedor);
                NotifyObservers();
            }
        }
    }
}