int num1 = 0; int i = 0; int.TryParse(Console.ReadLine(), out num1);
for (i = 1; i <= num1; i++)
    if (i % 2 == 0)
    Console.WriteLine(i);
