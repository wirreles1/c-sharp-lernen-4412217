int myVariable = 11;
int mySecondVariable = 15;

if (myVariable > 5 && myVariable < 15)
{
  bool meineAussage = true;
  Console.WriteLine(meineAussage);
}
else
{
  bool meineAussage = false;
  Console.WriteLine(meineAussage);
}

if (myVariable > 16 || myVariable < 8)
{
  bool meineAussage = true;
  Console.WriteLine(meineAussage);
}
else
{
  bool meineAussage = false;
  Console.WriteLine(meineAussage);
}

if (!(myVariable > 10))
{
  bool meineAussage = true;
  Console.WriteLine(meineAussage);
}
else
{
  bool meineAussage = false;
  Console.WriteLine(meineAussage);
}