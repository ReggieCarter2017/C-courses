int num1 = 0;
int num2 = 0;
int num3 = 0;
int max = 0;
int num = 0;

    for (int i = 0; i < 3; i++)
    {
        int.TryParse(Console.ReadLine(), out num);
            if (num >= max){
                max = num;
            }
    }
    Console.Write(max);