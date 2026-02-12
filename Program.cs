using Mehmedimamalukkur;
using System;

namespace Mehmedimamalukkur
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Person person = new Person();
            person.Name = "Шивачко Шивачеш";
            person.Age = 15;
            person.IntroduceYourself();
        }
    }
}
