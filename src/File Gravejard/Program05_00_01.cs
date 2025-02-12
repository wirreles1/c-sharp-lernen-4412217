int theNumber = new Random().Next(20);
int guessNum = 0;
int NumberofGuesses = 0;
Console.WriteLine("Lass uns das Spiel 'Zahlen raten' spielen!");
Console.WriteLine("Ich denke mir eine Zahl zwischen 0 und 20 aus.");
Console.WriteLine("Versuche meine Zahl zu erraten, oder tippe -1 um das Spiel zu beenden.");

while (guessNum != theNumber)
{
  guessNum = Convert.ToInt32(Console.ReadLine());
  NumberofGuesses += 1;
  if (guessNum == -1)
  {
    Console.WriteLine("Du hast das Spiel abgebrochen");
    theNumber = guessNum;
  }
  else if (theNumber == guessNum)
  {
    Console.WriteLine($"Du hast es mit {NumberofGuesses} Versuchen geschaft!!");
  }
  else if (theNumber < guessNum)
  {
    Console.WriteLine("Nein, meine Zahl ist niedriger");
  }
  else if (theNumber > guessNum)
  {
    Console.WriteLine("Nein, meine Zahl ist höher");
  }

}