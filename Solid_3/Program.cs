using System;

//Порушено принцип підстановки Лісков
abstract class Figure
{
    abstract public int GetArea();
}

class Rectangle : Figure
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    override public int GetArea()
    {
        return Width * Height;
    }
}
class Square : Figure
{
    public int Side { get; set; }
    public override int GetArea()
    {
        return Side * Side;
    }
}
class Program
{
    static int Area(Figure figure)
    {
        return figure.GetArea();
    }
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(Area(rect));
        //Відповідь 100? Так, спочатку сторона квадрата 5, потом 10
        Console.ReadKey();
    }
}