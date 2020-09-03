using System;

namespace Hello
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      string name;

      Console.WriteLine("Skriv in ditt namn:");

      // Läser in namnet från användaren
      name = Console.ReadLine();

      Console.WriteLine("Hej " + name + "!");

      Console.ReadLine();

    }
  }
}
