﻿using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] arg)
        {
            var hello = new SayHello();
            hello.Say();

            Bravo();
        }

        private static void Bravo()
        {
            Console.WriteLine();
            Console.WriteLine("Brawo! Pierwsze zadanie zrobione :)");
            Console.WriteLine("Naciśnij jakikolwiek klawisz aby zakończyć...");
            Console.ReadKey();
        }
    }

    public class SayHello
    {
      

        public void Say()
        {
            Console.WriteLine("Hello world");
        }
    }
}