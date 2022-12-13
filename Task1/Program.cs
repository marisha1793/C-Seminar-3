// Задача 19 Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] array = {5, 6, 3, 6, 5};
Console.Write("Введите пятизначное число: ");
int count = array.Length;
int index = 0;
while (index < count)
{
    Console.Write(array[index]);
    index++;
}
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine(" Это число - палиндром");
}
else
{
    Console.WriteLine(" Это число - не палиндром");
}


