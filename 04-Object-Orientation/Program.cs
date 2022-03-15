// See https://aka.ms/new-console-template for more information

/* *****************
 * 
 * Encapsulation
 * 
 * According to the principle of encapsulation, 
 * a class or struct can specify how accessible 
 * each of its members is to code outside of the 
 * class/struct.
 * 
 * By either using the members of the class/struct, 
 * or access modifiers. (eg public, private, protected..)
 * 
 * Inheritance
 * 
 * Inheritance enables you to create new classes 
 * that reuse, extend, and modify the behavior 
 * that is defined in other classes.
 * 
 * The class whose members are inherited is called 
 * the base class, and the class that inherits 
 * those members is called the derived class.
 * 
 * Polymorphism
 * 
 * A Greek word that means "many-shaped" and it has two 
 * distinct aspects:
 * 
 * i)  At run time, objects of a derived class may 
 *     be treated as objects of a base class in places 
 *     such as method parameters and collections or arrays.
 *
 * ii) Base classes may define and implement virtual methods, 
 *     and derived classes can override them.
 * 
 * *****************/

namespace Experiment
{
  /* *************************
   * 
   * Abstract classes
   * 
   * The abstract keyword enables you to create 
   * classes and class members that are 
   * incomplete and must be implemented in a derived class.
   * 
   * An abstract class cannot be instantiated.
   * The purpose of an abstract class is to provide a
   * common definition of a base class that multiple
   * derived classes can share.
   * 
   * ************************/

  public abstract class Animal
  {
    public string? Name { get; set; }

    public abstract string MakesSound();

    public string Move(int distance)
    {
      return $"{Name} moved {distance} meters";
    }
  }

  public class Dog : Animal
  {
    public bool HasTail { get; set; }

    public override string MakesSound()
    {
        return "Bark bark";
    }
  }

  /* *************************
   * 
   * Sealed classes
   * 
   * The sealed keyword enables you to prevent the inheritance 
   * of a class or certain class members.
   * 
   * We could create another class like this.
   * This class has all of the properties and methods of Animal & Dog
   * 
   * We cannot inherit from the Bullterrier.
   * 
   * *************************/

  public sealed class Bullterrier : Dog
  {
    public string? Colour { get; set; }  
  }

  class Program
  {
    static void Main(string[] args)
    {
      Dog myDog = new Dog();
      Bullterrier myOtherDog = new Bullterrier();

      myDog.Name = "Max"
      myOtherDog.Name = "Hellhound";
      myOtherDog.Colour = "red";
      
      Console.log("Over here...");
      Console.WriteLine(myDog.Move(9));
      Console.WriteLine(myOtherDog.Move(14));

      Console.WriteLine("\nPress any key to exit.");
      Console.ReadKey();
    }
  }
}