namespace dz12Sharick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            shop.AddStorageDevice(new FlashDrive("USB Flash", "SanDisk", "Cruzer", 10, 15.99, 64, 480));
            shop.AddStorageDevice(new DVD("DVD-R", "Verbatim", "DVD", 50, 0.99, 16, 8));
            shop.AddStorageDevice(new RemovableHDD("External HDD", "Seagate", "Backup Plus", 5, 89.99, 1000, 500));

            shop.PrintAllDevices();

            Console.WriteLine();
            Console.WriteLine("shop.RemoveStorageDevice(\"DVD-R\")");
            Console.WriteLine("shop.UpdateDevice(\"External HDD\", 1, 5000);");
            Console.WriteLine();
            shop.RemoveStorageDevice("DVD-R");
            shop.UpdateDevice("External HDD", 1, 5000);
            shop.PrintAllDevices();

            Console.WriteLine();
            Console.WriteLine("shop.FindDevice(\"External HDD\")");
            if (shop.FindDevice("External HDD") != null)
            {
                shop.FindDevice("External HDD").Print();
            }
        }
    }

}
