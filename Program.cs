//Задача 1: Напишите программу, которая принимает на вход число
 //и проверяет, кратно ли оно одновременно 7 и 23.
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
 Console.WriteLine($"Заданое число {num} кратно 7 и 23");   
}
else 
{
    Console.WriteLine($"Заданное число {num} не кратно 7 и 23");
}

//Задача 2: Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной 
//четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите точку X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("X ≠ 0 и Y ≠ 0, введите другие значения");  
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в I четверти");   
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во II четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в III четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в IV четверти"); 
}

//Задача 3: Напишите программу, которая принимает на вход целое число
 //из отрезка [10, 99] и показывает наибольшую цифру числа.

 Console.WriteLine("Введите число из отрезка [10, 99]: ");
 int num = Convert.ToInt32(Console.ReadLine());
 int num1 = num/10;
 int num2 = num % 10;
 if (num1 > num2)
 {
   Console.WriteLine($"Наибольшее число {num1}"); 
 }
 else
{
   Console.WriteLine($"Наибольшее число {num2}");
}

 //Задача 4: Напишите программу, которая на вход принимает натуральное 
 //число N, а на выходе показывает его цифры через запятую.
 Console.WriteLine("Введите число N: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Число должно быть натуральным.");
            return;
        }

        List<int> digits = new List<int>();

        if (num == 0)
        {
            digits.Add(0);
        }
        else
        {
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }
            digits.Reverse(); // Инвертируем порядок цифр
        }

        Console.WriteLine(string.Join(", ", digits));
    
