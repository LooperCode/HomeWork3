Console.WriteLine("Введите число");
double n = Convert.ToInt32(Console.ReadLine());
double i = 1;
while (i <= n) {
    
    double s = Math.Pow(i, 3);
    
Console.WriteLine($"{s}");
i++;
}