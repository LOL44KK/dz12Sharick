public class Shop
{
    private List<StorageDevice> _storageDevices = new List<StorageDevice>();

    public void AddStorageDevice(StorageDevice device)
    {
        _storageDevices.Add(device);
    }

    public bool RemoveStorageDevice(string name)
    {
        if (_storageDevices.RemoveAll(x => x.Name == name) >= 1)
        {
            return true;

        }
        return false;
    }

    public void PrintAllDevices()
    {
        for (int i = 0; i < _storageDevices.Count; i++)
        {
            Console.WriteLine("index: " + (i+1));
            _storageDevices[i].Print();
            Console.WriteLine();
        }
    }

    public StorageDevice? FindDevice(string name)
    {
        return _storageDevices.Find(d => d.Name == name);
    }

    public bool UpdateDevice(string name, int quantity, double price)
    {
        var device = FindDevice(name);
        if (device != null)
        {
            device.Quantity = quantity;
            device.Price = price;
            return true;
        }
        return false;
    }
}
