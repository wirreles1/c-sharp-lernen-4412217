using System;
namespace DiceGuesser 
{
  public class Program 
  { 
    static void Main(string[] args) 
    { 
      while (true) 
      { 
      	Console.Write("Bitte gib eine Zahl ein: "); 
        try 
        { 
          int number = Convert.ToInt32(Console.ReadLine()); 
          Console.WriteLine($"Du hast {number} eingegeben."); 
          break; 
        }
        catch (FormatException)
        { 
          Console.WriteLine("Der eingegebene Wert war keine Zahl."); 
        } 
      } 
    } 
  } 
}