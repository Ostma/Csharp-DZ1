/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int InputNumber()
{
Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);
return number;
}

int firstNum = InputNumber();
int secondNum = InputNumber();
int thirdNum = InputNumber();

if (firstNum > secondNum && firstNum > thirdNum)
Console.WriteLine(firstNum);
else
if (secondNum > firstNum && secondNum > thirdNum)
Console.WriteLine(secondNum);
else
if (thirdNum > firstNum && thirdNum > secondNum)
Console.WriteLine(thirdNum);
else
Console.WriteLine("Есть одинаковые числа"); // вывод сообщения, если есть два одинаковых числа