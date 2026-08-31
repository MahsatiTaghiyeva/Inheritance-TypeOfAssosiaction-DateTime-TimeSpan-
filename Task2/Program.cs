class Program
{
    static void Main(string[] args)
    {

        Circle circle1 = new Circle("Red", 5);
        circle1.GetInfo();

        Console.WriteLine("----------------");

        Rectangle rectangle1 = new Rectangle("Blue", 4);
        rectangle1.GetInfo();
    }
}
