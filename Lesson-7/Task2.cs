using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    //Дана коллекция List<T>. Требуется подсчитать, сколько раз каждый элемент встречается в данной коллекции
    internal sealed class Task2
    {
        private List<int> ListOfNumbers = new List<int> { 1, 3, 5, 3, 1, 5, 2, 7, 9, 10, 12, 4, 5, 1, 4, 7, 8, 3, 2, 1, 6, 5 };
        internal void GetSolution()
        {
            Console.WriteLine(" Дан список целых чисел: ");
            ShowMyList();
            Console.WriteLine();
            for (int i = 0; i < ListOfNumbers.Count; i++)
                Console.WriteLine($"Элемент:{ListOfNumbers[i]} встретился {ListOfNumbers.SampleCount(ListOfNumbers[i])} раз(а)");
           
        }
        private void ShowMyList()
        {
            foreach (int i in ListOfNumbers)
                Console.Write(i + " ");
        }
    }
}
