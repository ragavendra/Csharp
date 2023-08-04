using System;


public partial class Program
{
    public static void Main_()
    {
        IVehicleFactory vehicle = new BigTruck();
        vehicle = new SmallCar();
    }

}

public interface IVehicleFactory
{
    public void Chasis();

    public void Windows();

    public void Axle();
}

public abstract class Car : IVehicleFactory
{
    public void Axle()
    {
        throw new NotImplementedException();
    }

    public void Chasis()
    {
        throw new NotImplementedException();
    }

    public void Windows()
    {
        throw new NotImplementedException();
    }
}

public abstract class Truck : IVehicleFactory
{
    public void Axle()
    {
        throw new NotImplementedException();
    }

    public void Chasis()
    {
        throw new NotImplementedException();
    }

    public void Windows()
    {
        throw new NotImplementedException();
    }
}

public class SmallCar : Car
{

}

public class BigTruck : Truck
{

}