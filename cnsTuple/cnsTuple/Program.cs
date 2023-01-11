
//Кортеж

int z1 = 5;
var z2 = 5;

// (1)
var x1 = (2, 4);//кортеж
(int, int) x1a = (2, 4);//кортеж
var x1b = ("Миша", 20, 3.14);
Console.WriteLine(x1.Item1);
Console.WriteLine(x1.Item2);
Console.WriteLine();

// (2) названия полей кортежа
(int min, int max) x2 = (2, 4);
Console.WriteLine(x2.max);
Console.WriteLine(x2.min);
Console.WriteLine();

// (3) названия полей кортежа через инициализацию
var x3 = (min: 2, max: 4);
Console.WriteLine(x3.max);
Console.WriteLine(x3.min);
Console.WriteLine();

// (4) распаковка кортежа
var (min, max) = (2,4);
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine();

// (5) получение кортежа
var x5 = GetX5();
Console.WriteLine(x5.Item1);
Console.WriteLine(x5.Item2);
Console.WriteLine();

// (6) получение кортежа с именами и передача в качестве параметров

var x6 = GetX6(4, (5, 6));
Console.WriteLine(x6.min);
Console.WriteLine(x6.max);
Console.WriteLine();

(int, int) GetX5() => (1, 2);
(int min, int max) GetX6(int v, (int a, int b) p) => (v + p.a, v + p.b);
