public class RemovableHDD : StorageDevice
{
    public int DiskSize { get; set; } 
    public int UsbSpeed { get; set; } 

    public RemovableHDD(string name, string manufacturer, string model, int quantity, double price, int diskSize, int usbSpeed)
        : base(name, manufacturer, model, quantity, price)
    {
        DiskSize = diskSize;
        UsbSpeed = usbSpeed;
    }

    public override void Print()
    {
        Console.WriteLine("Removable HDD:");
        Console.WriteLine($"  Name: {Name}");
        Console.WriteLine($"  Manufacturer: {Manufacturer}");
        Console.WriteLine($"  Model:        {Model}");
        Console.WriteLine($"  Quantity:     {Quantity}");
        Console.WriteLine($"  Price:        {Price}$");
        Console.WriteLine($"  Disk Size:    {DiskSize} GB");
        Console.WriteLine($"  USB Speed:    {UsbSpeed} MB/s");
    }
}
