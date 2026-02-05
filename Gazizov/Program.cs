using System;

namespace Gazizov
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate primer = new Calculate();
            primer.Read();
            primer.Display();
            primer.function();
        }
    }
}
