bool isContinue = false;
do 
{
    Console.Write("Длина линии: ");
    int.TryParse(Console.ReadLine(), out int width);

    Console.WriteLine(new String('-', width));
    
    Console.WriteLine("Повторить [Y/N] ?");
    isContinue = Console.ReadLine()?.ToUpper() == "Y";
    
} while (isContinue);
