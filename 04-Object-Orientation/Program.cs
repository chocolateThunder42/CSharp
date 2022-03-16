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
 *     and derived classes can override them. They provide 
 *     their own definition and implementation.
 *     
 * The difference between Virtual methods and Abstract methods
 * is that:
 * 
 * Virtual methods have an implementation and provide the derived 
 * classes with the option of overriding it. While abstract methods 
 * do not provide an implementation and force the derived classes to 
 * override the method.
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
    private const int _age = 5;

    public abstract string MakesSound();

    public string Move(int distance)
    {
      return $"{Name} moved {distance} meters";
    }

    public virtual int GetAge()
    {
      return (_age); 
    }
  }

  public class Dog : Animal
  {
    public bool HasTail { get; set; }

    public override string MakesSound() => "Bark bark";

    public override int GetAge()
    {
      // We are accessing the Animal GetAge method
      // by using the keyword base and then overriding
      // what the method returns.

      return (base.GetAge() * 7);    
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

  /* *************************
   * 
   * Interfaces
   * 
   * An interface contains definitions for a group 
   * of related functionalities that a class or a 
   * struct can implement. It has the following properties:
   * 
   * + Any class/struct that implements the 
   *   interface must implement all its members.
   *   
   * + An interface can't be instantiated directly.
   *   Its members are implemented by any class 
   *   that implements the interface.
   *   
   * + They can contain events, indexers, methods, and 
   *   properties.
   *   
   * + They contain no implementation of methods.
   * 
   * + A class or struct can implement multiple interfaces.
   *   Along with inheriting a base class.
   *   
   * + There are two main differences between an interface 
   *   and an abstract class:
   *   
   *   i)  An interface can not contain method 
   *       implementations, an abstract class can.
   *       
   *   ii) A class can implement multiple interfaces, 
   *       but it can only inherit from one class
   * 
   * *************************/

   public interface IAnimal
   {
     string MakesSound();
     string Move();
     int GetAge(); 
   }

   public class CoolAnimal : IAnimal
   {
     public string MakesSound() => "I'm an oger";

     public string Move() => "You're moving";

     public int GetAge() => 300;
   }

  class Program
  {
    static void Main(string[] args)
    {
      Dog myDog = new Dog();
      Bullterrier myOtherDog = new Bullterrier();
      CoolAnimal coolAnimal = new CoolAnimal();

      myDog.Name = "Max";
      myOtherDog.Name = "Hellhound";
      myOtherDog.Colour = "red";
      
      Console.WriteLine("Over here...");
      Console.WriteLine(myDog.Move(9));
      Console.WriteLine(myOtherDog.Move(14));

      Console.WriteLine(coolAnimal.MakesSound());
      Console.WriteLine(coolAnimal.Move());

      Console.WriteLine("\nPress any key to exit.");
      Console.ReadKey();
    }
  }
}