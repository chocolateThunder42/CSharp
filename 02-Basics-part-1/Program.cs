// See https://aka.ms/new-console-template for more information

namespace SayHello
{
  class Basics
 {
    public static void SayHello(string name)
    { 
      Console.WriteLine($"Hello {name}");
    }

    public static void SayHelloAgain(string name) => Console.WriteLine($"Hello again, {name}");

    static void Main()
    { 
      string someVar = "Charles.";
      
      SayHello(someVar);

      SayHelloAgain(someVar);

      System.Console.WriteLine("\nPress any key to exit.");
      System.Console.ReadKey();
    }
  }
}