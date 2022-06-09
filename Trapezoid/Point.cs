namespace Trapezoid;
using static System.Console;
public class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public Point()
    {
        this.enterCoordFromKeyboard();
    }

    public void enterCoordFromKeyboard()
    {
        Write("Введите координату x: ");
        while (!int.TryParse(ReadLine(), out this.x))
        {
            Write("Введите координату x: ");
        }
        Write("Введите координату y: ");
        while (!int.TryParse(ReadLine(), out this.y))
        {
            Write("Введите координату y: ");
        }
    }

    public double calculateSegment(Point point)
    {
        double lengthOfSegment = Math.Sqrt(Math.Pow(point.x - this.x, 2) + Math.Pow(point.y - this.y, 2));
        return Math.Round(lengthOfSegment);
    }
}