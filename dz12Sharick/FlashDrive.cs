public class FlashDrive : StorageDevice
{
    public int MemorySize { get; set; }
    public int UsbSpeed { get; set; }

    public FlashDrive(string name, string manufacturer, string model, int quantity, double price, int memorySize, int usbSpeed)
        : base(name, manufacturer, model, quantity, price)
    {
        MemorySize = memorySize;
        UsbSpeed = usbSpeed;
    }

    public override void Print()
    {
        Console.WriteLine("Flash Drive:");
        Console.WriteLine($"  Manufacturer: {Manufacturer}");
        Console.WriteLine($"  Model:        {Model}");
        Console.WriteLine($"  Quantity:     {Quantity}");
        Console.WriteLine($"  Price:        {Price}");
        Console.WriteLine($"  Memory Size:  {MemorySize} GB");
        Console.WriteLine($"  USB Speed:    {UsbSpeed} MB/s");
    }
}
