﻿Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[3] {num1, num2, num3};
int index = 0;
int max = 0;
while (index < 3)
{
    if (numbers[index] > max)
        {
            max = numbers[index];
            index++;
        }
}
Console.WriteLine("Максимальное число: " + max);

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());  
// if (num1 > num2)
// {
//     Console.WriteLine("Максимальное число " + num1);
//     Console.WriteLine("Минимальное число " + num2);
// }
// if (num1 < num2)
// {
//     Console.WriteLine("Максимальное число " + num2);
//     Console.WriteLine("Минимальное число " + num1);
// }
// if (num1 == num2)
// {
//     Console.WriteLine("Числа равны");
// }   