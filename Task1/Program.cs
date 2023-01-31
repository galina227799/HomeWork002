Console.Clear();
Console.Write("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine());
if(Number/100 == 0 || Number/1000 != 0) {
    Console.WriteLine("Введено не техзначное число!");
    return;
};
Console.WriteLine((Number/10)%10);