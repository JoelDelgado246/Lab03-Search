using System.Diagnostics;

namespace Lab03_Search;
class BusquedaLineal
{
    static void MainL(string[] args)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Console.WriteLine("Algoritmo de búsqueda lineal: ");
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24,
        62, 52, 84, 69, 100, 854, 74, 3};
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i}] = {A[i]}, ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Hora de inicio del programa {0}", DateTime.Now.ToString("hh:mm:fff"));
        Console.WriteLine("Ingrese el valor a buscar");
        int dato = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Arreglo a buscar: " + dato);
        int posicionEncontrada = BusquedaLinealID(A, dato); // 65 es el elemento a buscar
        Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
        stopWatch.Stop();
        Console.WriteLine($"Elapsed time: {stopWatch.ElapsedMilliseconds} ms");
        Console.WriteLine("Hora de Finalización del programa {0}", DateTime.Now.ToString("hh:mm:fff"));
    }

    static int BusquedaLinealID(int[] A, int clave)
    {
        int i;
        for (i = 0; i < A.Length; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
