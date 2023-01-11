//Список

using System.Collections;

ArrayList arrayList = new();
arrayList.Add(123);
arrayList.Add("Привет");
arrayList.Add(3.14);
for (int i =0; i<3; i++)
{
    Console.WriteLine(arrayList[i]);
}
Console.WriteLine();

//Обобщенный список

List<string> cities = new() { "Москва", "Воронеж", "Севастополь" };
cities.Add("Астана");
cities.AddRange(new string[] { "Тула", "Ялта" });
//Удаление в списке
cities.RemoveAt(1);
cities.Reverse();
Console.WriteLine(String.Join(' ', cities));
//сортировка списка
cities.Sort();  
Console.WriteLine(String.Join(' ', cities));

