using System;
class Rectangle : Shape
{
    double Length;
    public Rectangle(string color, double length) : base(color)
    {
        Length = length;
    }
    public void FindArea()
    {
        Area = Length*Length;
    }
}