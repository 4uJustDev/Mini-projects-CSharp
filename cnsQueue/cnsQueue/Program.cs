
// Очередь

using System.Collections;

Queue x = new();
x.Enqueue(6);   
x.Enqueue(4);   
x.Enqueue(1);   
x.Enqueue("Hello");
Console.WriteLine($"Смотрим -> {x.Peek()}");//посмотреть элементы

while (x.Count > 0)
{
    Console.WriteLine(x.Dequeue());//извлечь объекты
}
Console.WriteLine();

// Обобщенная очередь

Queue<int> numbers = new();
numbers.Enqueue(1);
numbers.Enqueue(2);
numbers.Enqueue(3);
numbers.Enqueue(4);
Console.WriteLine($"Сумма = {numbers.Sum()}");

while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}
