public class DVD : StorageDevice
{
    public int ReadSpeed { get; set; } 
    public int WriteSpeed { get; set; }

    public DVD(string name, string manufacturer, string model, int quantity, double price, int readSpeed, int writeSpeed)
        : base(name, manufacturer, model, quantity, price)
    {
        ReadSpeed = readSpeed;
        WriteSpeed = writeSpeed;
    }

    public override void Print()
    {
        Console.WriteLine("DVD:");
        Console.WriteLine($"  Name: {Name}");
        Console.WriteLine($"  Manufacturer: {Manufacturer}");
        Console.WriteLine($"  Model:        {Model}");
        Console.WriteLine($"  Quantity:     {Quantity}");
        Console.WriteLine($"  Price:        {Price}");
        Console.WriteLine($"  Read Speed:   {ReadSpeed}x");
        Console.WriteLine($"  Write Speed:  {WriteSpeed}x");
    }
}
