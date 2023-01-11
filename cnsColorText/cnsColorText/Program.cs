for (int colorId = 0; colorId < 16; colorId++)
{
    if (colorId == 0)
    {
        Console.BackgroundColor = ConsoleColor.White;
    }
    Console.ForegroundColor = (ConsoleColor)colorId;
    int colorId2 = 15 - colorId;
    Console.BackgroundColor = (ConsoleColor)colorId2;
    Console.WriteLine($"Text with {colorId}id");
    Console.BackgroundColor = (ConsoleColor)0;
    Console.ResetColor();
}