int num1 = 0;
int num2 = 0;
int max = num1;
int min = num2;
if (int.TryParse(Console.ReadLine(), out num1)) > (int.TryParse(Console.ReadLine(), out num2)) {
    Console.WriteLine(max);
}
else {
    max = num2;
    Console.Write(max);
}