int myVariable = 13;
int mySecondVariable = 15;

if (myVariable > mySecondVariable)
{
  Console.WriteLine("Die WahrHeit");
}
else if (mySecondVariable == 14)
{
  Console.WriteLine("Dies ist die wahre Wahrheit");
}
else if (myVariable == mySecondVariable)
{
  Console.WriteLine("Dies ist eine andere Variante der WahrHeit");
}
else
{
  Console.WriteLine("Dies ist nicht die WahrHeit");
}