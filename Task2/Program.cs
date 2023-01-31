Console.Clear();
Console.Write("Введите число: ");
String Number = Console.ReadLine();
if(Number.Length < 3) {
    Console.WriteLine("Третьей цифры нет!");
    return;
};
Console.Write(Number[2]);