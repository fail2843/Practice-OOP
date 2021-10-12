using System;
namespace Lesson_7
{
    //Реализовать метод расширения для поиска количества символов в строке.
    internal sealed class Task1
    {
        private string _input;
        internal void GetSolution()
        {
            Console.WriteLine(" Введите строку");
            _input = Console.ReadLine();
            Console.WriteLine(" Длина строки: " + _input.StringLength());
        }
    }
}