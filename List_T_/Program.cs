using System;
using System.Collections.Generic;
using Separator;
namespace List_T_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Add(6);
            numbers.AddRange(new int[] { 7, 8, 9 });
            numbers.Insert(0, 666);
            numbers.RemoveAt(1);
            foreach(int x in numbers)
            {
                Console.WriteLine(x);
            }
            separateEvent.Display();
        }
    }
}
