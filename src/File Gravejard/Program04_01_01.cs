int maxSum = 52;
bool positiv = true;

if (maxSum <= 0)
{
  Console.WriteLine("Nur positive Zahlen");
  positiv = false;
}
else
{
  positiv = true;
}

int sum = 0;
int i = 1;

while (sum + i < maxSum)
{
  sum = sum + i;
  i = i + 1;
}

if (positiv == true)
{
  Console.WriteLine("Die Summe beträgt " + sum + " bei Zahl " + i);
}