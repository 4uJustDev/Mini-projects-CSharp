
using NameMaze;


// Point po = new Point(20, 20);
// Point po1 = new Point(5, 10);
// Point po2 = po + po1;
// po2.Print();

Console.Write($"Start \n");
var rand = new Random();
Main();

void Main()
{
    Console.Write("width: \n");
    var x = int.Parse(Console.ReadLine());
    Console.WriteLine("length: ");
    var y = int.Parse(Console.ReadLine());
    Point poq = new Point(x, y);

    var maze = Maze.Create(poq);

    DrawMaze(maze);

    Console.ReadKey();
}
void DrawMaze(Maze maze)
{
    Console.Clear();
    int c = 0;
    for (int row = 0; row < maze.Width; row++)
    {
        for (int col = 0; col < maze.Height; col++)
        {
            switch (maze[row, col])
            {
                case Cell.Wall: Console.Write("██"); break;
                case Cell.Exit: Console.Write("EX"); break;
                case Cell.Way: Console.Write("  "); break;
                case Cell.WayPassed: Console.Write("  "); break;
                case Cell.Inner: Console.Write("IN"); break;
                default:
                    Console.Write("  "); break;
                    c++;
                    //░░
            }
            c++;
            if (c % maze.Width == 0)
            {
                Console.Write('\n');
            }
        }
    }
    Console.Write('\n');
}
