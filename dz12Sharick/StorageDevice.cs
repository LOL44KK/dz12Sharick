public abstract class StorageDevice
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public StorageDevice(string name, string manufacturer, string model, int quantity, double price)
    {
        Name = name;
        Manufacturer = manufacturer;
        Model = model;
        Quantity = quantity;
        Price = price;
    }

    public abstract void Print();
}
