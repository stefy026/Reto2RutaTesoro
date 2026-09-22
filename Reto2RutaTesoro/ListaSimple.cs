using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Reto2RutaTesoro
{
    public class ListaSimple
    {
        private Nodo? inicio;

        public int Cantidad { get; private set; }

        public void Insertar(int id, string nombre, string pista, int peligro)
        {
            if (Buscar(id) != null)
            {
                throw new InvalidOperationException(
                    $"Ya existe una ubicación con ID {id}.");
            }

            Nodo nuevo = new Nodo(id, nombre, pista, peligro);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo actual = inicio;

                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevo;
            }

            Cantidad++;
        }

        public Nodo? Buscar(int id)
        {
            Nodo? actual = inicio;

            while (actual != null)
            {
                if (actual.Id == id)
                {
                    return actual;
                }

                actual = actual.Siguiente;
            }

            return null;
        }

        public bool Modificar(
            int id,
            string nombre,
            string pista,
            int peligro)
        {
            Nodo? nodo = Buscar(id);

            if (nodo == null)
            {
                return false;
            }

            nodo.Nombre = nombre;
            nodo.Pista = pista;
            nodo.Peligro = peligro;

            return true;
        }

        public bool Eliminar(int id)
        {
            if (inicio == null)
            {
                return false;
            }

            if (inicio.Id == id)
            {
                inicio = inicio.Siguiente;
                Cantidad--;
                return true;
            }

            Nodo anterior = inicio;
            Nodo? actual = inicio.Siguiente;

            while (actual != null)
            {
                if (actual.Id == id)
                {
                    anterior.Siguiente = actual.Siguiente;
                    Cantidad--;
                    return true;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            return false;
        }

        public Nodo? ObtenerInicio()
        {
            return inicio;
        }

        public void Limpiar()
        {
            inicio = null;
            Cantidad = 0;
        }
    }
}