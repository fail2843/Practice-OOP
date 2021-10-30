using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class MathProgram
    {
        private string _input;
        private int _number;
        private int _factorial;
        private int _sum;
        private int _maxEven;
        public void Begin()
        {
            Console.WriteLine(" Здравствуйте, вас приветствует математическая программа!\n" +
                              " -> Для старта нажмите 'b'\n" +
                              " -> Для выхода из программы нажмите любую клавишу");
            _input = Console.ReadLine();
            switch (_input)
            {           
                case "b":
                    Console.Clear();
                    do
                    {
                        Console.Write(" Введите число: ");
                        _input = Console.ReadLine();
                    }
                    while (!Int32.TryParse(_input, out _number));
                    GetProgramResult();
                    ShowAnswer();
                    return;
                default:
                    Console.WriteLine(" Завершение программы!");
                    Console.ReadKey();
                    return;
            }
        }
        private void GetProgramResult()
        {
            _sum = 0;
            _factorial = 1;

            for(int i = 1; i <= _number; i++)
            {
                _sum += i;
                _factorial *= i;
            }
            if (_number % 2 == 0) _maxEven = _number;
            else _maxEven = _number - 1;
        }
        private void ShowAnswer()
        {
            Console.WriteLine($" Факториал равен {_factorial}\n" +
                              $" Сумма чисел от 1 до введенного равна {_sum}\n" +
                              $" Максимальное четное число меньше введенного равно {_maxEven}");
            Console.ReadKey();
        }
    }
}