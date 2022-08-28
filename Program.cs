int num1 = 0;
int num2 = 0;
int max = int.Parse(Console.ReadLine()!);
int min = int.Parse(Console.ReadLine()!);
if (max > min) {
    Console.Write($"Максимальное число: {max}");
}
else {
    max = min;
    Console.Write($"Максимальное число: {max}");
}