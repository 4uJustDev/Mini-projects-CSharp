using System;
using System.Reflection.Metadata.Ecma335;

bool Zalivka = true;
Console.WriteLine("Программа для рисовки ромба");

Console.WriteLine("Введите ширину ромба: ");
int.TryParse(Console.ReadLine(), out int wide);

Console.WriteLine("Введите символ рисования: ");
char.TryParse(Console.ReadLine(), out char symbol);

Console.WriteLine("Заполнить ромб ? [Y/N]: ");
Zalivka = (Console.ReadLine().ToUpper() == "Y");

char symbolInner = ' ';

if (Zalivka == true)
{
    Console.WriteLine("Введите символ заполнения: ");
    char.TryParse(Console.ReadLine(), out symbolInner);
}
if(wide %  2 == 1)
{
    if (Zalivka != true)
    {
        symbolInner = ' ';
    }
    int symetric = (wide - 1) / 2;
    int symetricInfinity = symetric-1;
    Console.WriteLine(new String(' ', symetric) + symbol + new String(' ', symetric));
    for (int j = 0; j < wide - 2; j++)
    {
        if (j <= symetricInfinity)
        {
            symetric--;
            drawLineA(symbol, symbolInner, symetric, wide);
        }
        if (j > symetricInfinity)
        {
            symetric++;
            drawLineA(symbol, symbolInner, symetric, wide);
        }
    }
    symetric++;
    Console.WriteLine(new String(' ', symetric) + symbol + new String(' ', symetric));
}
if (wide % 2 == 0)
{
    if (Zalivka != true)
    {
        symbolInner = ' ';
    }
    int symetric = wide/2;
    int symetricInfinity = symetric;
    Console.WriteLine(new String(' ', symetric - 1) + symbol + symbol + new String(' ', symetric-1));
    for (int j = 0; j < wide - 2; j++)
    {
        if (j <= symetricInfinity - 2)
        {
            symetric--;
            drawLineB(symbol, symbolInner, symetric, wide);
        }
        if (j == symetricInfinity - 2)
        {
            drawLineB(symbol, symbolInner, symetric, wide);
        }
            if (j > symetricInfinity - 2)
        {
            symetric++;
            drawLineB(symbol, symbolInner, symetric, wide);
        }
    }
}

static void drawLineA(char Sym, char SymInner, int mid , int Width)
{
    Console.WriteLine(new String(' ', mid) + Sym + new String(SymInner, Width - 2 - (mid * 2)) + Sym + new String(' ', mid));
}
static void drawLineB(char Sym, char SymInner, int mid, int Width)
{
    Console.WriteLine(new String(' ', mid - 1) + Sym + new String(SymInner, Width - 2 - ((mid - 1) * 2)) + Sym + new String(' ', mid - 1));
}
