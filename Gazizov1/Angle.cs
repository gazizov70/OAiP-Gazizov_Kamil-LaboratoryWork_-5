using System;
using System.Collections.Generic;
using System.Text;

namespace Gazizov1
{
    class Angle
    {
        int degrees;
        int minutes;

        public void Read()
        {
            Console.Write("Введите градусы: ");
            degrees = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты: ");
            minutes = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Число A: { degrees }");
            Console.WriteLine($"Число B: { minutes }");
        }

        public void ConvertToRadians()
        {
            double PI = 3.14;
            double totalDegrees = degrees + minutes / 60;
            double answer = totalDegrees * PI / 180;
            Console.WriteLine($"Углы в радианах: { answer }");
  
        }

        public void ConvertTo360()
        {
            int totalMinutes = degrees * 60 + minutes;
            degrees = totalMinutes / 60;
            minutes = totalMinutes % 60;

            degrees %= 360;
            if (degrees < 0)
            {
                degrees += 360;
            }

            if (minutes < 0)
            {
                minutes += 60;
                degrees = (degrees - 1 + 360) % 360;
            }
            Console.Write("Углы в диапазоне 0-360: ");
            Console.WriteLine((float)(degrees + minutes / 60));
        }

        public void IncreaseAngle()
        {
            Console.Write("Введите градусы для увеличения: ");
            int addDegrees = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты для увеличения: ");
            int addMinutes = int.Parse(Console.ReadLine());

            degrees += addDegrees;
            minutes += addMinutes;
            Console.WriteLine($"Новый угол после увеличения: {degrees}°{minutes}'");
        }

        public void DecreaseAngle()
        {
            Console.Write("Введите градусы для уменьшения: ");
            int subDegrees = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты для уменьшения: ");
            int subMinutes = int.Parse(Console.ReadLine());

            degrees -= subDegrees;
            minutes -= subMinutes;
            Console.WriteLine($"Новый угол после уменьшения: {degrees}°{minutes}'");
        }

        public void GetSin()
        {
            double totalDegrees = degrees + minutes / 60.0;
            double radians = totalDegrees * Math.PI / 180;
            double sinValue = Math.Sin(radians);
            Console.WriteLine($"Синус угла: {sinValue:F4}");
        }

        public void GetCos()
        {
            double totalDegrees = degrees + minutes / 60.0;
            double radians = totalDegrees * Math.PI / 180;
            double cosValue = Math.Cos(radians);
            Console.WriteLine($"Косинус угла: {cosValue:F4}");
        }
    }
}
