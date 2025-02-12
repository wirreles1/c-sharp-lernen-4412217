int myfirstVariable = 10;
int mysecondVariable = 2;
int mythirdVariable = 1;
int myfourthVariable = 2;

while (myfirstVariable > mysecondVariable)
{
  myfirstVariable += mythirdVariable; mysecondVariable += myfourthVariable;
}

myfirstVariable += mythirdVariable; mysecondVariable += myfourthVariable;

Console.WriteLine(mysecondVariable + " ist größer als " + myfirstVariable);