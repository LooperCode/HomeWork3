﻿Console.WriteLine("Введите пятизначное число");
int insert = Convert.ToInt32(Console.ReadLine());
int thousand = insert;
int last = insert % 100;
if (insert > 99999) {
    Console.WriteLine("Некорректное число");
}
else if (insert < 9999) {
    Console.WriteLine("Некорректное число");
}
else {
while (thousand > 999) {
    
    thousand = thousand / 100;
}
thousand = (thousand % 10) * 100 + (insert / 1000) % 10 * 10 + (insert / 10000);
last = (last % 10) * 10 + (last / 10);
last = last * 1000;
int reverse = last + thousand;
if (insert == reverse) {
    Console.WriteLine ($"Число {insert} является палиндромом, потому что в обратном порядке: {reverse}");
}
else {
    Console.WriteLine($"Число {insert} не является палиндромом, потому что в обратном порядке: {reverse}");
}
}
 


