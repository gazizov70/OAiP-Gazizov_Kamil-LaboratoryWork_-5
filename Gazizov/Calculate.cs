using System;
using System.Collections.Generic;
using System.Text;

namespace Gazizov
{
    class Calculate
    {
        float first;
        float second;

        public void Read()
        {
            Console.Write("Введите число A: ");
            string first_str = Console.ReadLine();
            first = float.Parse(first_str);
            Console.Write("Введите число B: ");
            string second_str = Console.ReadLine();
            second = float.Parse(second_str);
        }
        
        public void Display()
        {
            Console.WriteLine($"Число A: {first}");
            Console.WriteLine($"Число B: {second}");
        }

        public void function()
        {
            Console.Write("Введите число x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Значение выражения: ");
            Console.WriteLine( x * first + second );
        }
    }
}
