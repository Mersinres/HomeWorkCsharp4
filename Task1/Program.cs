//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;

for (int i = 1; i < b; i++)
{
stepen = stepen * a;
}
Console.WriteLine("A в степени B равно: " + stepen);


///3, 5 -> 243 (3⁵)

//2, 4 -> 16s