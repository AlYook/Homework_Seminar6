// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] GetArray()
{
Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите элемент под индексом {i}: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", array));
return array;
}

int ElCount(int[] array, int count = 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
Console.WriteLine(count);
return count;
}

int[] newArray = GetArray();
int newCount = ElCount(newArray);