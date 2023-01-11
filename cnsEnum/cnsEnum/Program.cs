class Program {
    //перечислимый тип
   public enum SingleColor { Red, Green = 55, Blue }

    static void Main() 
    {
        SingleColor singleColor;
        singleColor = SingleColor.Green;

        Console.WriteLine(singleColor);
        Console.WriteLine(singleColor.ToString("D"));
        Console.WriteLine(Enum.GetUnderlyingType(singleColor.GetType()));
    }
}