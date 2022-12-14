// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] newArray = GetArray();
FindIntersection();

int[] GetArray()
{
string[] WordArray = {"k1", "b1", "k2", "b2"};

int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите точку отрезка {WordArray[i]}: ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"отрезок 1 ({array[0]};{array[1]}); отрезок 2 ({array[2]};{array[3]})");
return array;
}

void FindIntersection()
{
double k1 = newArray[0];
double b1 = newArray[1];
double k2 = newArray[2];
double b2 = newArray[3];

double X = (b2 - b1) / (k1 - k2);
double Y = k1 * X + b1;
double inter1 = k1 * X + b1;
double inter2 = k2 * X + b2;

Console.WriteLine($"{inter1}; {inter2}");
}