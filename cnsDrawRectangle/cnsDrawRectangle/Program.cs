using System;
using System.Reflection.Metadata.Ecma335;

bool Zalivka = true;
Console.WriteLine("Программа для рисовки прямоугольника");

Console.WriteLine("Введите длину прямоугольника: ");
int.TryParse(Console.ReadLine(), out int length);

Console.WriteLine("Введите ширину прямоугольника: ");
int.TryParse(Console.ReadLine(), out int wide);

Console.WriteLine("Введите символ рисования: ");
char.TryParse(Console.ReadLine(), out char symbol);

Console.WriteLine("Заполнить прямоугольник ? [Y/N]: ");
Zalivka = (Console.ReadLine().ToUpper() == "Y");

char symbolInner = ' ';


if (Zalivka == true)
{
    Console.WriteLine("Введите символ заполнения: ");
    char.TryParse(Console.ReadLine(), out symbolInner);
}

for (int i = 0; i < length; i++)
{
    if (Zalivka == true)
    {
        if (i % (length - 1) == 0)
        {
            Console.WriteLine(new String(symbol, wide));
        }
        else
        {
            Console.WriteLine(symbol + new String(symbolInner, wide - 2) + symbol);
        }
    }
    else
    {
        if (i % (length - 1) == 0)
        {
            Console.WriteLine(new String(symbol, wide));
        }
        else
        {
            Console.WriteLine(symbol + new String(' ', wide - 2) + symbol);
        }
    }
}