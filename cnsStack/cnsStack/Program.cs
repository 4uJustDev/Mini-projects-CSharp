
// Стек

using System.Collections;

Stack x = new();
x.Push("Рязань");
x.Push(100500);

Console.WriteLine($"Смотрим -> {x.Peek()}");
Console.WriteLine(x.Pop());
Console.WriteLine(x.Pop());
Console.WriteLine();

for (int i = 0; i<10; i++){
    x.Push(i);
}

var item1 = x.Peek();
Console.WriteLine($"Элемент без удаления {item1}");
Console.WriteLine();

