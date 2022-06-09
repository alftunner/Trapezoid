namespace Trapezoid;

public class TrapezoidClass
{
    public Point a, b, c, d;
    public double perimeter;
    public double square;

    public TrapezoidClass()
    {
        a = new Point();
        b = new Point();
        c = new Point();
        d = new Point();
        this.calcSquare();
        this.calcPerimeter();
    }

    public void checkTrapezoid()
    {
        if (a.calculateSegment(b) == c.calculateSegment(d))
        {
            Console.WriteLine("Трапеция - равнобокая");
        }
        else
        {
            Console.WriteLine("Трапеция - не равнобокая");
        }
    }

    public void showLengthOfSides()
    {
        Console.WriteLine($"Длина стороны AB - {a.calculateSegment(b)}");
        Console.WriteLine($"Длина стороны BC - {b.calculateSegment(c)}");
        Console.WriteLine($"Длина стороны CD - {c.calculateSegment(d)}");
        Console.WriteLine($"Длина стороны AD - {a.calculateSegment(d)}");
    }

    public void calcPerimeter()
    {
        this.perimeter = a.calculateSegment(b) + b.calculateSegment(c) + c.calculateSegment(d) + a.calculateSegment(d);
    }

    public void calcSquare()
    {
        double chislitel = Math.Pow(a.calculateSegment(d) - b.calculateSegment(c), 2) +
            Math.Pow(a.calculateSegment(b), 2) - Math.Pow(c.calculateSegment(d), 2);
        double znamenatel = 2 * (a.calculateSegment(d) - b.calculateSegment(c));
        this.square = (b.calculateSegment(c) + a.calculateSegment(d)) / 2 
                      * Math.Sqrt(Math.Pow(a.calculateSegment(b), 2) - Math.Pow(chislitel / znamenatel,2));
    }

    public bool compareOfSquare(double averageSquare)
    {
        if (this.square > averageSquare)
        {
            return true;
        }

        return false;
    }

    public static double calcAverageSquare(TrapezoidClass[] trapezoids)
    {
        double squareSumm = 0;
        foreach (TrapezoidClass trapezoid in trapezoids)
        {
            squareSumm += trapezoid.square;
        }

        return squareSumm / trapezoids.Length;
    }
}