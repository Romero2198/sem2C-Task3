Console.Write("Введите день недели(от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 5)
{
    Console.WriteLine($"{a} - нет");
}
else if (a == 6 || a == 7 )
{
    Console.WriteLine($"{a} - да");
}
else
{
    Console.WriteLine("Число должно быть от 1 до 7");
}

    