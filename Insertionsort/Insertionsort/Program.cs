using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertionsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[8] { 4, 3, 2, 10, 12, 1, 5, 6};
            //val es el la variable auxiliar para que puedas ir pasando el valor a donde le corresponde
            //flag es una variable auxiliar para evitar desbordamientos
            int ciclo1, ciclo2, val, flag; 
            //MUestra el arreglo inicial
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (ciclo1 = 0; ciclo1 < array.Length; ciclo1++)
            {
                Console.Write(array[ciclo1] + " ");
            }

            //INSERTION SORT
            for (ciclo1 = 1; ciclo1 < array.Length; ciclo1++)
            {
                val = array[ciclo1];
                flag = 0;
                for (ciclo2 = ciclo1 - 1; ciclo2 >= 0 && flag != 1;)
                {
                    if (val < array[ciclo2])
                    {
                        //si el valor actual es menor al de la pos anterior 
                        //se le da la posicion anterior
                        array[ciclo2 + 1] = array[ciclo2];
                        ciclo2--;
                        array[ciclo2 + 1] = val;
                    }
                    else flag = 1;
                }
            }

            //Funcion de Imprimir resultados
            Console.Write("\nSorted Array is: ");
            for (ciclo1 = 0; ciclo1 < array.Length; ciclo1++)
            {
                Console.Write(array[ciclo1] + " ");
            }
            Console.ReadKey();
        }
    
    }
}
