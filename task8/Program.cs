// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("enter number:");
string enternum = Console.ReadLine();
int numb = Convert.ToInt32(enternum);

int index = 1;
int test_numb = 0;

while (index <numb)
{
    test_numb = index/2*2; // если число не чётное, то при делении на 2 дробная часть откинется, а потом при умножении на 2 в результате получится число, не равное исходному.
    if (index == test_numb)
    {
        Console.WriteLine (index);
    }
    index++;
};

