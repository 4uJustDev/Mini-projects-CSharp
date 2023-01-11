Console.Write("Имя: ");
string? name = Console.ReadLine();
Console.Write("Город: ");
string? city = Console.ReadLine();

//3 способа вывода инфо
//(1)
Console.WriteLine("Имя = " + name + ", Город = " + city);
//(2)
Console.WriteLine("Имя = {0}, Город = {1}", name, city);
//(3)
Console.WriteLine($"Имя = {name}, Город = {city}");