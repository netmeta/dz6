// Задача 3 *.Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 1*2=3
// 3*3=9
// 8, 3, 4, 2 -> 28

Console.Clear();
Console.Write("Введите длину массива: ");
bool isParsedSize = int.TryParse(Console.ReadLine(), out int size);
if (!isParsedSize)
{
    Console.WriteLine("Ошибка! ");
    return;
}

int[] array1 = new int[size];
FillArray(array1);
PrintArray(array1);
Console.Write($"Сумма произведений пар чисел: {SumOfProductsNumbers(array1)}");

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(10);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
    
}

int SumOfProductsNumbers(int[] array)
{
    int product = 0;
    for (int i = 0; i < array.Length / 2; i++) 
    {
        product += array[i] * array[array.Length - 1 - i];
    }
    return product;
}
