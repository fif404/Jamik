//Скрипников Сергей 17 вар 3.3
Console.WriteLine("Введите число n: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число x: ");
double x = double.Parse(Console.ReadLine());
double s = 0;
double z = 2;
for (int i = 0; i < n; i += 1)
{
    z *= 2;
    s = 1 + Math.Pow(x, z) / z!;
}
Console.WriteLine("ответ:" + s);  