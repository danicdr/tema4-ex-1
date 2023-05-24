using System;

namespace test_infinit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea: ");
            int n = int.Parse(Console.ReadLine());

            int[] vect = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti elementul {i}: ");
                vect[i] = int.Parse(Console.ReadLine());
            }


            BubbleSort(vect);

            Console.WriteLine("Vectorul sortat in ordine descrescatoare:");
            PrintArray(vect);
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {

                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}


//Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul

