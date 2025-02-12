int maxNum = 0;
Console.WriteLine("Lass uns das Spiel 'Zahlen raten' spielen!");
Console.WriteLine("Ich werde mir eine Zahl zwischen 0 und einer von dir gewählten Zahl ausdenken.");
Console.WriteLine("Bitte wähle die gewünschte Zahl:");
maxNum = Convert.ToInt32(Console.ReadLine());
int theNumber = new Random().Next(maxNum);
int guessNum = 0;
int NumberofGuesses = 0;
if ((guessNum == theNumber) && (NumberofGuesses == 0))
{
  Console.WriteLine("ERROR: Um diesen Fehler zu vermeiden wähle bitte eine größere maximale Zahl");
}
else
{
  Console.WriteLine($"Ich habe mir eine Zahl zwischen 0 und {maxNum} ausgedacht.");
  Console.WriteLine("Versuche meine Zahl zu erraten, oder tippe -1 um das Spiel zu beenden.");
}




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
  if (NumberofGuesses == 5)
  {
    Console.WriteLine("Tipp: Versuche die Zahl in der Mitte des Bereichs zu erraten");
  }
}