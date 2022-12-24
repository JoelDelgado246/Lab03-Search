using System.Diagnostics;
namespace Lab03_Search;
class BusquedaFinal
{
    static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int[] arreglo = new int[100];
        int busquedasExitosas = 0, busquedasFallidas = 0;

        for (int i = 0; i < 100; i++)
        {
            arreglo[i] = aleatorio.Next(0, 200) + 1;
        }

        imprimirArreglo(arreglo);

        for (int i = 0; i < 50; i++)
        {
            int n = aleatorio.Next(0, 200) + 1;
            Console.WriteLine("Arreglo a buscar: " + n);
            int posicionEncontrada = BusquedaLinealID(arreglo, n);
            Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
            if (posicionEncontrada != -1) busquedasExitosas++; else busquedasFallidas++;
        }

        Console.WriteLine($"El número de búsquedas exitosas es de: {busquedasExitosas} y el de búsquedas fallidas es {busquedasFallidas}");
        Console.WriteLine($"El porcentaje de exito de búsquedas fue de {(100*busquedasExitosas)/50}% y el porcentaje de fallo fue de {(100*busquedasFallidas)/50}%");

        Console.WriteLine($"El arreglo ordenado es el siguiente: ");
        Array.Sort(arreglo);
        imprimirArreglo(arreglo);
    }


    private static void imprimirArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write($"A[{i}] = {arreglo[i]}, ");
        }
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
