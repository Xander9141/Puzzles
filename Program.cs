using System;
using System.Linq;

namespace FuncionesMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matriz = RandomArray();

            // Imprimir la matriz generada
            Console.WriteLine("Matriz generada:");
            foreach (int num in matriz)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Encontrar el valor mínimo y máximo
            int min = matriz.Min();
            int max = matriz.Max();
            Console.WriteLine($"Valor mínimo: {min}");
            Console.WriteLine($"Valor máximo: {max}");

            // Calcular la suma de los valores en la matriz
            int suma = matriz.Sum();
            Console.WriteLine($"La suma de todos los valores es: {suma}");

            // Lanzamiento de moneda
            string resultado = TossCoin();
            Console.WriteLine($"Resultado del lanzamiento de moneda: {resultado}");

            // Opcional: Lanzar múltiples monedas y mostrar la relación de caras/totales
            int numLanzamientos = 10; // Número de lanzamientos
            double relacionCaras = TossMultipleCoins(numLanzamientos);
            Console.WriteLine($"Relación caras/totales: {relacionCaras:P}");

            // Nombres
            var listaNombres = Nombres();
            Console.WriteLine("Lista de nombres con más de 5 caracteres:");
            foreach (var nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }
        }

        static int[] RandomArray()
        {
            int[] matriz = new int[10];
            Random rand = new Random();

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = rand.Next(5, 26);
            }

            return matriz;
        }

        static string TossCoin()
        {
            Console.WriteLine("¡Tirando una moneda!");
            Random rand = new Random();
            return (rand.Next(0, 2) == 0) ? "Cara" : "Cruz";
        }

        static double TossMultipleCoins(int num)
        {
            Random rand = new Random();
            int caras = 0;

            for (int i = 0; i < num; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    caras++;
                }
            }

            return (double)caras / num;
        }

        static List<string> Nombres()
        {
            List<string> nombres = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
            return nombres.Where(nombre => nombre.Length > 5).ToList();
        }
    }
}
