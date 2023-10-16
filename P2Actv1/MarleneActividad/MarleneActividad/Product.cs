public class Product
{
    string[] productNames = {
            "Smartphone",
            "Laptop",
            "Digital Camera",
            "T-shirt",
            "Jeans",
            "Running Shoes",
            "Cookbook",
            "Refrigerator",
            "Coffee Maker",
            "Sofa",
            "Dining Table",
            "Board Game",
            "Necklace",
            "Tennis Racket",
            "Lipstick",
            "Car Battery",
            "Chocolate Bar",
            "Pain Reliever",
            "Printer",
            "Acoustic Guitar",
            "Dog Food",
            "Hiking Boots",
            "Drill Set",
            "Lawn Mower",
            "Oil Paints",
            "Suitcase",
            "Wrench Set",
            "Backpack",
            "Camping Tent"
        };
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; } = double.MaxValue;
    public int Qty { get; set; }

    public Product()
    {
        Price = Double.Round(new Random().NextDouble() * 100, 2);
        Name = productNames[new Random().Next(0, productNames.Length)];
        Qty = new Random().Next(100);
    }
    public Product(string name)
    {
        this.Name = name;
        Qty = new Random().Next(100);
        Price = Double.Round(new Random().NextDouble() * 100, 2);
    }



}
