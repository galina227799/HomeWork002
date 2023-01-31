Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
int Number = int.Parse(Console.ReadLine());
if(Number==6 || Number == 7){
    Console.WriteLine("Ура, это выходной!");
   return;
};
Console.WriteLine("Это не выходной :(");