//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.WriteLine("Введите первое число ");
int number1 = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int number2 = int.Parse(System.Console.ReadLine());

int Quatro(int number3)
{
int summ = 1;
for(int i = 0; i != number2; i++)
{
    summ = summ * number1;
}
return summ;
}

System.Console.WriteLine(Quatro(number1));