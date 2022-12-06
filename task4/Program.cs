// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("enter numberA:");
string enternum = Console.ReadLine();
int numbA = Convert.ToInt32(enternum);

System.Console.WriteLine("enter numberB:");
enternum = Console.ReadLine();
int numbB = Convert.ToInt32(enternum);


System.Console.WriteLine("enter numberC:");
enternum = Console.ReadLine();
int numbC = Convert.ToInt32(enternum);
int max = numbA;


if (numbB > max)
{
    max = numbB;
    
}

if (numbC > max)
    {
        max = numbC;
    }


Console.WriteLine ($"Число {max} является максимальным.");