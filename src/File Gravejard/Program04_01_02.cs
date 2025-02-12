int maxSum(int maximalSum) 
{
  if (maximalSum <= 0)
  {
    return 0;
  }

  int sum = 0;
  int i = 1;

  while (sum + i < maximalSum)
  {
    sum = sum + i;
    i = i + 1;
  }
  return sum;
}

Console.WriteLine(maxSum(11));
Console.WriteLine(maxSum(-11));
Console.WriteLine(maxSum(0));
Console.WriteLine(maxSum(100));