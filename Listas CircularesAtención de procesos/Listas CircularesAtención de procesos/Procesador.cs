using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_CircularesAtención_de_procesos
{
    class Procesador
    {
        Proceso primero, ultimo, temp;


        public Procesador()
        {
            primero = null;
            ultimo = null;
        }

        public void enqueue(Proceso nuevoP) //Meter proceso
        {
            if (primero == null)
            {
                primero = nuevoP;
                ultimo = nuevoP;
                primero.siguiente = nuevoP;
                primero.anterior = nuevoP;
            }
            else
            {
                ultimo.siguiente = nuevoP;
                nuevoP.anterior = ultimo;
                nuevoP.siguiente = primero;
                primero = nuevoP;
                primero.anterior = ultimo;
            }
        }

        public Proceso dequeue() //sacar proceso
        {
            if (primero == null)
            {
                return null;
            }
            else if (primero.siguiente == primero)
            {
                temp = primero;
                primero = ultimo = null;
                return temp;
            }             
   
                temp = primero;
                primero = primero.siguiente;
                primero.anterior = ultimo;
                ultimo.siguiente = primero;

            
            return temp;
        }

        public void Avanzar()
        {
            if (primero != null)
                primero = primero.siguiente;
        }

        public Proceso peek() //Ver proceso actual
        {
            return primero;
        }

        public string procesosoPendientes()
        {
            int procPendientes = 0;
            int sumaCiclosPendientes = 0;
            temp = primero;

            if(primero!=null)
            do
            {
                sumaCiclosPendientes += temp.ciclos;
                procPendientes++;
                temp = temp.siguiente;
            } while (temp != ultimo);
            string pendientes = "Procesos pendientes: " + procPendientes.ToString() + Environment.NewLine +
                "Suma de los ciclos pendientes: " + sumaCiclosPendientes.ToString();
            return pendientes;
        }

    }
}

