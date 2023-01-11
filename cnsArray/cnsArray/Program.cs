
//Массив

string[] cities = { "Тула", "Уфа", "Ялта", "Минск" };

Console.WriteLine(cities);
Console.WriteLine(cities[0]);
Console.WriteLine(cities[^1]);//Последний элемент в массиве

Console.WriteLine($"Длина массива = {cities.Length}\n");

//Способы обхода массивов
//(1)
for (int i = 0; i < cities.Length; i++) 
{
    Console.WriteLine(cities[i]);
}
Console.WriteLine();

//(2)
foreach (var item in cities)
{
    Console.WriteLine(item);
}
Console.WriteLine();

//(3)
Console.WriteLine(String.Join<string>('\n', cities));
Console.WriteLine();

// Изменить размер массива
Array.Resize<string>(ref cities, 3);
Console.WriteLine(String.Join<string>(' ', cities));

// Создать пустой массив
string[] citiesNew1 = { };
string[] citiesNew2 = Array.Empty<string>();
Console.WriteLine();

////Копирование элементов массива
Array.Resize<string>(ref citiesNew1, 10);
Array.Copy(cities, citiesNew1,2);
Console.WriteLine(String.Join<string>(' ', citiesNew1));
Console.WriteLine();