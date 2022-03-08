// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace Experiment
{ 
  public class Animal
  {
    // constructor
    public Animal()
    { }

    public Animal(int age)
    {
      this.age = age;
    }

    // property
    public string Name { get;set; }
    
    // field
    private int age;

    // method
    public string Moves()
    {
      return $"{Name} is moving"; 
    }

    static void Main()
    {
      // 1
      Animal a1 = new Animal();

      // 2
      Animal a2 = new Animal(10);
    }
  }
}