// Задача 1: программа запрашивает натур число M.
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Не использовать массив.
// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3

Console.Clear();
Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
List<int> numbers = new List<int>();
for (int i = 0; i < m; i++)
{
    numbers.Add(Convert.ToInt32(Console.ReadLine()));
}
Console.Write($"Кол-во элементов > 0: {numbers.Where(n => n > 0).Count()}");

