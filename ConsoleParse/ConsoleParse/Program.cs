Console.WriteLine("number?");

int value1 = int.Parse(Console.ReadLine());
Console.WriteLine(value1);
Console.WriteLine();

int value2;
int.TryParse(Console.ReadLine(), out value2);
Console.WriteLine(value2);
Console.WriteLine();

int value3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(value3);
Console.WriteLine();
Console.WriteLine($"Проверка суммы:{value1+value2+value3}");



