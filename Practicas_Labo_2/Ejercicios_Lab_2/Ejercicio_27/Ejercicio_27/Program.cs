using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_27
{
    class Program
    {
        private static int OrdenarDescendente(double n1, double n2)
        {
            return -n1.CompareTo(n2);
        }

        static void Main(string[] args)
        {
            //Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos)
            //distintos de cero de forma aleatoria utilizando la clase Random.
            //a.Mostrar el vector tal como fue ingresado
            //b.Luego mostrar los positivos ordenados en forma decreciente.
            //c.Por último, mostrar los negativos ordenados en forma creciente.

            //Random rnd = new Random();

            //List<double> numAleatorio = new List<double>();

            //for (int i = 0; i < 20; i++)
            //{
            //    numAleatorio.Add(rnd.Next(-100, 100));
            //}

            //foreach (double item in numAleatorio)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n***************************************************");

            //Console.ReadKey();

            //numAleatorio.Sort();

            //foreach (double item in numAleatorio)
            //{
            //    if (item > 0)
            //    {
            //        Console.WriteLine(item); 
            //    }
            //}
            //Console.WriteLine("\n***************************************************");

            //Console.ReadKey();

            //numAleatorio.Sort(OrdenarDescendente);

            //foreach (double item in numAleatorio)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n***************************************************");

            //Console.ReadKey();
            //foreach (double item in numAleatorio)
            //{
            //    if (item < 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.WriteLine("\n***************************************************");

            //Console.ReadKey();

            // Cola
            //Console.WriteLine("COLA");
            //Queue<double> clientesCola = new Queue<double>();

            //List<double> listaAuxiliar = new List<double>();

            //clientesCola.Enqueue(new Cliente("Jorge"));
            //clientesCola.Enqueue(new Cliente("Alberto"));
            //clientesCola.Enqueue(new Cliente("Luis"));
            //clientesCola.Enqueue(new Cliente("María"));

            //Random rnd = new Random();
            //Random r = new Random();
            //double aux;

            //for (int i = 0; i < 20; i++)
            //{
            //    aux = rnd.Next(-100, 100);
            //    clientesCola.Enqueue(aux);
            //    listaAuxiliar.Add(aux);
            //    Console.WriteLine(listaAuxiliar[i]);
            //}
            //Console.WriteLine("\n****************************************");


            //while (clientesCola.Count > 0)
            //{
            //    Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Dequeue(), clientesCola.Count);
            //    // Demoro la iteración entre 1 y 3 segundos
            //    System.Threading.Thread.Sleep(r.Next(300, 600));
            //}


            //Console.WriteLine("***************************************");

            //clientesCola = new Queue<double>();
            //listaAuxiliar.Sort();

            //foreach (double item in listaAuxiliar)
            //{
            //    if (item > 0)
            //    {
            //        clientesCola.Enqueue(item); 
            //    }
            //}

            //while (clientesCola.Count > 0)
            //{
            //    Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Dequeue(), clientesCola.Count);
            //    // Demoro la iteración entre 1 y 3 segundos
            //    System.Threading.Thread.Sleep(r.Next(300, 600));
            //}

            //Console.WriteLine("***************************************");


            //clientesCola = new Queue<double>();
            //listaAuxiliar.Sort(OrdenarDescendente);

            //foreach (double item in listaAuxiliar)
            //{
            //    clientesCola.Enqueue(item);
            //}

            //while (clientesCola.Count > 0)
            //{
            //    Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Dequeue(), clientesCola.Count);
            //    // Demoro la iteración entre 1 y 3 segundos
            //    System.Threading.Thread.Sleep(r.Next(300, 600));
            //}

            //Console.WriteLine("***************************************");

            //clientesCola = new Queue<double>();

            //foreach (double item in listaAuxiliar)
            //{
            //    if (item < 0)
            //    {
            //        clientesCola.Enqueue(item);
            //    }
            //}

            //while (clientesCola.Count > 0)
            //{
            //    Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Dequeue(), clientesCola.Count);
            //    // Demoro la iteración entre 1 y 3 segundos
            //    System.Threading.Thread.Sleep(r.Next(300, 600));
            //}

            //Console.WriteLine("***************************************");
            //Console.WriteLine("***************************************");

            //Console.ReadKey();

            Console.WriteLine("PILA");
            //Queue<double> clientesCola = new Queue<double>();
            Stack<double> clientesCola = new Stack<double>();
            List<double> listaAuxiliar = new List<double>();

            Random rnd = new Random();
            Random r = new Random();
            double aux;

            for (int i = 0; i < 20; i++)
            {
                aux = rnd.Next(-100, 100);
                clientesCola.Push(aux);
                listaAuxiliar.Add(aux);
                Console.WriteLine(listaAuxiliar[i]);
            }
            Console.WriteLine("\n****************************************");


            while (clientesCola.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Pop(), clientesCola.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(300, 600));
            }


            Console.WriteLine("***************************************");

            clientesCola = new Stack<double>();
            listaAuxiliar.Sort();

            foreach (double item in listaAuxiliar)
            {
                if (item > 0)
                {
                    clientesCola.Push(item);
                }
            }

            while (clientesCola.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Pop(), clientesCola.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(300, 600));
            }

            Console.WriteLine("***************************************");


            clientesCola = new Stack<double>();
            listaAuxiliar.Sort(OrdenarDescendente);

            foreach (double item in listaAuxiliar)
            {
                clientesCola.Push(item);
            }

            while (clientesCola.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Pop(), clientesCola.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(300, 600));
            }

            Console.WriteLine("***************************************");

            clientesCola = new Stack<double>();

            foreach (double item in listaAuxiliar)
            {
                if (item < 0)
                {
                    clientesCola.Push(item);
                }
            }

            while (clientesCola.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Pop(), clientesCola.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(300, 600));
            }

            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");

            Console.ReadKey();


        }
    }
}