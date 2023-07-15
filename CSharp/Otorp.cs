using System;

public class ProtoType
{
    public ProtoType CreateShallow()
    {
        return (ProtoType) MemberwiseClone();
    }

    public void A()
    {
        Console.WriteLine("This is A");
    }

    public void B(){}
}

public partial class Program
{
    public static void Main_6()
    {
        var proto = new ProtoType();
        ProtoType proClone = proto.CreateShallow();
        proClone.A();
    }
}