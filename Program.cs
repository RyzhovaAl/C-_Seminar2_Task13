// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = num;
while (result > 999)
{
    result = result / 10;
}
if(result > 99 && result < 1000)
{
    Console.WriteLine($"Третья цифра числа {num} -> {result % 10}"); 
} 
else
{
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}