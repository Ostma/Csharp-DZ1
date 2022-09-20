// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
int InputNumber()
{
Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
return number;
}

int firstNum = InputNumber();
int secondNum = InputNumber();

if (firstNum > secondNum)
Console.WriteLine("Первое число больше");
else
if (firstNum < secondNum)
Console.WriteLine("Второе число больше");
else
Console.WriteLine("Числа равны");