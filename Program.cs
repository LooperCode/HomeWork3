//Определение диапозона координат по вводу четверти координатной плоскости
Console.WriteLine("Введите четверть плоскости");
double insert = Convert.ToDouble(Console.ReadLine());
if (insert == 1){
    Console.WriteLine("Возможный диапозон координат: x > 0, y > 0");
}
else if (insert == 2){
    Console.WriteLine("Возможный диапозон координат: x < 0, y > 0");
}
else if (insert == 3){
    Console.WriteLine("Возможный диапозон координат: x < 0, y < 0");
}
else if (insert == 4){
    Console.WriteLine("Возможный диапозон координат: x > 0, y < 0");
}
else {
    Console.WriteLine("Вы ввели не корректное значение");
}





