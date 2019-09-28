using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinates = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        . ToArray();

            var topLeftPoint = new Point(rectangleCoordinates[0], rectangleCoordinates[1]);
            var bottomRightPoint = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);
            var rectangle = new Retangle(topLeftPoint, bottomRightPoint);

            int pointsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < pointsCount; i++)
            {
                int[] pointCoordinates = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                Point currentPoint = new Point(pointCoordinates[0], pointCoordinates[1]);

                Console.WriteLine(rectangle.Contains(currentPoint));
            }
            Console.ReadLine();
        }
    }
}
public class Point
{
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public int X { get; private set; }
    public int Y { get; private set; }
}
public class Retangle
{
    private Point topLeft;
    private Point bottomRight;
    public Retangle(Point topLeft, Point bottomRight)
    {
        this.topLeft = topLeft;
        this.bottomRight = bottomRight;
    }
    public bool Contains(Point point)
    {
        return this.topLeft.X <= point.X && this.bottomRight.X >= point.X && this.topLeft.Y <= point.Y && this.bottomRight.Y >= point.Y;
    }
}

