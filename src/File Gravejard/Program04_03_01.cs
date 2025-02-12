double number1 = 10; // Geben Sie die erste Zahl an
double number2 = 100; // Geben Sie die zweite Zahl an
string operator1 = "add"; // Geben Sie die auszuführende Operation an: "add", "sub", "mul" oder "div"
// Bei Subtraktion und Division wird automatisch immer der größere Wert an erster Stelle geschrieben

switch (operator1)
{
  case "add":
    double add(double summand1, double summand2)
    {
      return summand1 + summand2;
    }

    double Summe = add(number1, number2);
    Console.WriteLine(number1 + " + " + number2 + " = " + Summe);
    break;
  case "sub":
    if (number1 > number2)
    {
      double sub(double Minuend, double Subtrahend)
      {
        return Minuend - Subtrahend;
      }
      double differenz = sub(number1, number2);
      Console.WriteLine(number1 + " - " + number2 + " = " + differenz);
    }
    else if (number1 < number2)
    {
      double sub(double Subtrahend, double Minuend)
      {
        return Minuend - Subtrahend;
      }
      double differenz = sub(number1, number2);
      Console.WriteLine(number2 + " - " + number1 + " = " + differenz);
    }
    break;
  case "mul":
    double multiply(double faktor1, double faktor2)
    {
      return faktor1 * faktor2;
    }

    double produkt = multiply(number1, number2);
    Console.WriteLine(number1 + " x " + number2 + " = " + produkt);
    break;
  case "div":
    if (number1 == 0 || number2 == 0)
    {
      Console.WriteLine("ERROR: Wert darf nicht 0 betragen");
    }
    else
    {
      if (number1 > number2)
      {
        double divide(double Minuend, double Subtrahend)
        {
          return Minuend / Subtrahend;
        }
        double quotient = divide(number1, number2);
        Console.WriteLine(number1 + " / " + number2 + " = " + quotient);
      }
      else if (number1 < number2)
      {
        double divide(double Subtrahend, double Minuend)
        {
          return Minuend / Subtrahend;
        }
        double quotient = divide(number1, number2);
        Console.WriteLine(number2 + " / " + number1 + " = " + quotient);
      }
    }
    break;
}