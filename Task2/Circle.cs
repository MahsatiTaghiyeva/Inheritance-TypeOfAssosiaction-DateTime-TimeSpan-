using System;
class Circle : Shape
{
    public double Radius;
    public Circle(string color,double radius) : base(color)
    {
        Radius = radius;
        Area = 3.14*Radius*Radius;
    }
}