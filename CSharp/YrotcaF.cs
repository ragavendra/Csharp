using System;

public interface IShapesFactory
{
    public void Draw();
}

public enum Shapes
{
    Circle,
    Rhombus
}

public class ShapesFactory : IShapesFactory
{
    public ShapesFactory()
    {
    }

    public void Draw()
    {
        throw new NotImplementedException();
    }
}

public class Circle : ShapesFactory
{
    public void Draw()
    {
        Console.WriteLine("Drawing circle.");
    }
}

public class Rhombus : IShapesFactory
{
    public void Draw()
    {
        Console.WriteLine("Drawing rhombus.");
    }
}

public partial class Program
{
    public static void Main_1()
    {

        Console.WriteLine("Please enter 0 - Circle, 1 - Rhombus.");
        var response = Console.ReadKey();
        IShapesFactory shape;

        switch (response.Key)
        {
            case ConsoleKey.D0: 
                shape = new Circle();
                break;

            case ConsoleKey.D1: 
                shape = new Rhombus();
                break;
            
            default:
                Console.WriteLine("Invalid choice " + response.Key);
                return;
                // break;
        }

        Console.Write("Shape is - ");
        shape.Draw();
    }
}