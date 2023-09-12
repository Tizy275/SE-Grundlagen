Console.WriteLine("Willkommen beim Tascherechner");

bool checkParse1 = false;
bool checkParse2 = false;
int num1 = 0;
int num2 = 0;

while (!checkParse1 || !checkParse2)
{
   Console.WriteLine("Bitte gebe Zahl 1 an:");
   var input1 = Console.ReadLine();

   Console.WriteLine("Bitte gebe Zahl 2 an:");
   var input2 = Console.ReadLine();

   checkParse1 = int.TryParse(input1, out num1);
   checkParse2 = int.TryParse(input2, out num2);

}
var result = num1 + num2;
Console.WriteLine($"{num1} + {num2} = {result}");