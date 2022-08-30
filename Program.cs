// Задача 25
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень");
// int degree = Convert.ToInt32(Console.ReadLine());

// int result = num;
// for (int i = 1; i < degree; i++)
// {
//     result = result * num;
// }
// Console.WriteLine(result);

// задача 27
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// for (int i = 1000000000; i > 0; i /= 10)
// {
//     result = result + ((num / i) % 10);
// }
// Console.WriteLine(result);

//задача 29

int[] array = {0, 0, 0, 0, 0, 0, 0, 0};
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите число");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"[{array[0]}");
for (int i = 1; i < array.Length; i++)
{
    Console.Write($", {array[i]}");
}
Console.Write("]");
