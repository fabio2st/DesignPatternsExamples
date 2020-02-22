using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    interface Observer
    {
        void Update(int TotalClientesEnEspera, LinkedList<Atendedor> atendedores);
    }
}
