// Словарь

Dictionary<int, string> x = new();

x.Add(10, "Калуга"); 
x.Add(11, "Псков"); 
x.Add(12, "Самара"); 
x.Add(13, "Брянск");

Console.WriteLine(x[10]);

x[11] = "Воронеж";
x[99] = "Курск";

foreach (var item in x)
{
    Console.WriteLine($"key = {item.Key}, value = {item.Value}");
}