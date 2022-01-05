using System;

namespace DesignPattern
{
    public static class FunctionExtension
    {
        public static void PrintToConsole(this object obj)
        {
            Console.WriteLine($"{obj}");
        }
    }
}