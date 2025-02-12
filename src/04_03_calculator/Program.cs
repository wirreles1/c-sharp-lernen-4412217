//input:

double number1 = 0;
double number2 = 0;
string operator1 = "Hallo";
Console.WriteLine("Bitte geben Sie die erste Zahl ein");
number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Bitte geben Sie den Operator ein");
operator1 = Convert.ToString(Console.ReadLine() ?? string.Empty);
Console.WriteLine("Bitte geben Sie die zweite Zahl ein");
number2 = Convert.ToDouble(Console.ReadLine());
double result = 0;
bool isValid = true;

//Calculation:

switch (operator1)
{
  case "+":
    result = add(number1, number2);
    break;
  case "-":
    result = sub(number1, number2);
    break;
  case "*":
    result = multiply(number1, number2);
    break;
  case "/":
    if (number1 == 0 || number2 == 0)
    {
      Console.WriteLine("ERROR: Wert darf nicht 0 betragen");
      isValid = false;
    }
    else
    {
      result = divide(number1, number2);
    }
    break;
  default:
    Console.WriteLine("Ungültiger Operator");
    isValid = false;
    break;
}

//Output:

if (isValid)
{
  Console.WriteLine("Das Ergebnis lautet:");
  Console.WriteLine($"{number1} {operator1} {number2} = {result}");
}

//Methods:

static double add(double summand1, double summand2)
{
  return summand1 + summand2;
}

static double sub(double number1, double number2)
{
  return number1 > number2 ? number1 - number2 :
  number2 - number1;
}

static double multiply(double number1, double number2)
{
  double produkt = 0;
  bool isNegative = (number1 < 0 && number2 > 0) || (number1 > 0 && number2 < 0);
  if (number2 < 0)
  {
    number2 = -number2;
  }

  if (number1 < 0)
  {
    number1 = -number2;
  }

  for (double index = 0; index < number2; index++)
  {
    produkt = produkt + number1;
  }

  if (isNegative)
  {
    return -produkt;
  }
  return produkt;
}

static double divide(double number1, double number2)
{
  return number1 > number2 ? number1 / number2 :
  number2 / number1;
}