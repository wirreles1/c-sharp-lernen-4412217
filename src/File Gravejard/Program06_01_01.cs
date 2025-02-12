using System.Diagnostics;
// Tests Output:
Console.WriteLine("Checking System...");
bool testResult = RunTests();
bool test1working = true;
bool test2working = true;
bool test3working = true;
bool test4working = true;
bool test5working = true;
bool test6working = true;
if (testResult)
{
  Console.WriteLine($"Systemtest completed (No Errors found)");
}
else
{
  Console.WriteLine($"ERROR: Please check the current build for errors.");
  Console.WriteLine($"TEST1 working: {test1working}");
  Console.WriteLine($"TEST2 working: {test2working}");
  Console.WriteLine($"TEST3 working: {test3working}");
  Console.WriteLine($"TEST4 working: {test4working}");
  Console.WriteLine($"TEST5 working: {test5working}");
  Console.WriteLine($"TEST6 working: {test6working}");
}


// Input:

string numbers = "1,2,3,4,5";
Console.WriteLine("Dieses Programm kann Zahlen der Reihenfolge nach sortieren");
Console.WriteLine("Bitte gebe die zu sortierenden Zahlen durch Kommata getrennt ein");
numbers = (Console.ReadLine() ?? string.Empty);
double[] mein_erstes_array;
try
{
  mein_erstes_array = numbers.Split(',').Select(double.Parse).ToArray();
}
catch (FormatException)
{
  Console.WriteLine("ERROR: !Ungültige Eingabe! Bitte gebe nur Zahlen ein, getrennt durch Kommata.");
  return;
}
BubbleSort(mein_erstes_array);

// Output:

Console.WriteLine(" ");
Console.WriteLine("Hier sind die Zahlen, aufsteigend sortiert nach Größe");
for (int i = 0; i < mein_erstes_array.Length; i++)
{
  Console.WriteLine(mein_erstes_array[i]);
}

// Methods

void BubbleSort(double[] toSort) // Code here :)
{
  double n = toSort.Length;
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n - 1 - i; j++)
    {
      if (toSort[j] > toSort[j + 1])
      {
        double temp = toSort[j];
        toSort[j] = toSort[j + 1];
        toSort[j + 1] = temp;
      }
    }
  }
}

// Test Methods:
bool RunTests()
{
  bool allTestsPassed = true;

  // Test 1: Already sorted array
  double[] sortedArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
  BubbleSort(sortedArray);
  if (!sortedArray.SequenceEqual(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }))
  {
    test1working = false;
    allTestsPassed = false;
  }

  // Test 2: Reverse sorted array
  double[] reverseArray = { 5.5, 4.4, 3.3, 2.2, 1.1 };
  BubbleSort(reverseArray);
  if (!reverseArray.SequenceEqual(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }))
  {
    test2working = false;
    allTestsPassed = false;
  }

  // Test 3: Unsorted array
  double[] unsortedArray = { 3.3, 1.1, 4.4, 5.5, 2.2 };
  BubbleSort(unsortedArray);
  if (!unsortedArray.SequenceEqual(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 }))
  {
    test3working = false;
    allTestsPassed = false;
  }

  // Test 4: Empty array
  double[] emptyArray = { };
  BubbleSort(emptyArray);
  if (!emptyArray.SequenceEqual(new double[] { }))
  {
    test4working = false;
    allTestsPassed = false;
  }

  // Test 5: Single element array
  double[] singleElementArray = { 1.1 };
  BubbleSort(singleElementArray);
  if (!singleElementArray.SequenceEqual(new double[] { 1.1 }))
  {
    test5working = false;
    allTestsPassed = false;;
  }

  // Test 6: Array with same elements
  double[] sameElementsArray = { 2.2, 2.2, 2.2, 2.2, 2.2 };
  BubbleSort(sameElementsArray);
  if (!sameElementsArray.SequenceEqual(new double[] { 2.2, 2.2, 2.2, 2.2, 2.2 }))
  {
    test6working = false;
    allTestsPassed = false;
  }

  return allTestsPassed;
}