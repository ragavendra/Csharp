using System;

public abstract class CoffeDecorator
{
    protected double _cost;

    public abstract void AddIngredient();
}

public class Cream : CoffeDecorator
{
    public Coffe _coffe;

    private int _count;

    public Cream(Coffe coffe)
    {
        _cost = 0.3;
        _coffe = coffe;
    }

    public override void AddIngredient()
    {
        Console.WriteLine("Adding cream!");
        _coffe.TotalCost += _cost;
        _count++;
    }
}

public class Sugar : CoffeDecorator
{
    public Coffe _coffe;

    private int _count;

    public Sugar(Coffe coffe)
    {
        _cost = 0.25;
        _coffe = coffe;
    }

    public override void AddIngredient()
    {
        Console.WriteLine("Adding sugar!");
        _coffe.TotalCost += _cost;
        _count++;
    }
}

public class Coffe
{
    private double _totalCost;

    public Coffe()
    {
        _totalCost = 1.15;
    }

    public double TotalCost
    {
        get { return _totalCost; }
        set { _totalCost = value; }
    }
}

public partial class Program
{
    public static void Main_7()
    {
        Coffe coffe = new Coffe();
        var coffeDecorator = new Cream(coffe);
        coffeDecorator.AddIngredient();
        coffeDecorator.AddIngredient();

        var sugar = new Sugar(coffe);
        sugar.AddIngredient();

        Console.WriteLine("Coffe cost " + coffe.TotalCost);
    }
}