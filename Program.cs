                                            //Семинар(1)С# Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше

/*Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine(" Наибольшее из введеных чисел " + numberOne);
    Console.WriteLine(" Наименьшее из введеных чисел " + numberTwo);
}

else 
{
     Console.WriteLine(" Наибольшее из введеных чисел " + numberTwo);
     Console.WriteLine(" Наименьшее из введеных чисел " + numberOne);
}

Console.ReadLine();
*/

                                             //Семинар(1)С# Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo && numberOne > numberThree)
{
    Console.WriteLine("Максимальное число" + numberOne);
}

else if (numberTwo > numberOne && numberTwo > numberThree)
{
    Console.WriteLine("Максимальное число" + numberTwo);
}

else Console.WriteLine("Максимальное число" + numberThree);

Console.ReadLine();
*/

                                                   //Семинар(1)С# Задача 3:Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
{
    Console.Write("Число чётное");
}

else
{
    Console.WriteLine("Число нечётное");
}

Console.ReadLine();
*/

                                                    //Семинар(1)С# Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int a = 1;

while (a <= number)
{
    if ((a % 2) == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}

Console.ReadLine(   );
*/

                                                   //Семинар(2)С# Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.WriteLine("Введите число");
string number = Console.ReadLine();

Console.WriteLine(number[1]);
*/

                                                     //Семинар(2)С# Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

 /*Console.WriteLine("Введите число");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    Console.WriteLine(number[2]);
}
else Console.WriteLine("Цифры не существует");

Console.ReadLine();
*/

                                                     //Семинар(2)С# Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

/*Console.WriteLine("Введите день недели");
int number = Convert.ToInt32 (Console.ReadLine());

if (number <= 7 && number >= 1)
{
    if (number == 6 || number == 7)
    Console.WriteLine("Ура! Выходной!!!");
    else Console.WriteLine("Снова на работу!");
}
else Console.WriteLine("Данные некорректны");

Console.ReadLine();
*/

