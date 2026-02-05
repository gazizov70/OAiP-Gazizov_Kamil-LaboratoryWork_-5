using System;

namespace Gazizov1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle test = new Angle();
            test.Read();
            test.ConvertTo360();
            test.ConvertToRadians();
        }
    }
}
