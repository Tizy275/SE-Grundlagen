﻿Console.WriteLine("Bitte Alter als Zahl angeben:");

var inputAge = Console.ReadLine();

var age = int.Parse(inputAge);

if (age < 16) // Bedingung ist Ausdruck, der True oder False ergibt.
{
   Console.WriteLine("Nein");
}

else if (age >= 16 && age < 18) // Beliebig viele else-if Anweisungen pro if-Anweisung
{
   Console.WriteLine("Vielleicht");
}

else // Aber immer nur 1 else pro if-Anweisung
{
   Console.WriteLine("Willkommen");
}

Console.WriteLine("Done");

Console.WriteLine("Bitte Zahl für aktuellen Wochentag eingeben:");

var inputWeekday = Console.ReadLine();

var weekday = int.Parse(inputWeekday);

switch (weekday)
{
   case 1:
      Console.WriteLine("Montag");
      break;
   case 2:
      Console.WriteLine("Dienstag");
      break;
   case 3:
      Console.WriteLine("Mittwoch");
      break;
   case 4:
      Console.WriteLine("Donnerstag");
      break;
   case 5:
      Console.WriteLine("Freitag");
      break;
   default:
      Console.WriteLine("Zahl ist kein Wochentag");
      break;
}
