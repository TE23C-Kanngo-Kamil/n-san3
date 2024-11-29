using System;

class Program
{
    static void Main(string[] args)
    {
        Hello32();
    }

    static void Hello32()
    {
        int count = 0;
        while (count < 32)
        {
            Console.WriteLine("Hello, World");
            count++;
        }
    }
}