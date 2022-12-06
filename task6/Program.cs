// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

System.Console.WriteLine("enter numberA:");
string enternum = Console.ReadLine();
int numb = Convert.ToInt32(enternum);

int test_numb = numb/2*2; // если число не integer, то при делении на 2 дробная часть откинется, а потом при умножении на 2 в результате получится число, не равное исходному.

if (numb == test_numb)
{
    Console.WriteLine ($"Число {numb} является четным.");
}
else
{
Console.WriteLine ($"Число {numb} является нечетным.");
}