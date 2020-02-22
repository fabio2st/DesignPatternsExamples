using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverC
{
    class Cliente
    {
        string nombre;
        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
            {
            return nombre;
        }
    }
}