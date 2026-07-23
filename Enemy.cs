class Game
{
    public string Name;
    public string Genre;
    public int Price;
    public double Rating;

    public Game(string name, string genre, int price, double rating)
    {
        Name = name;
        Genre = genre;
        Price = price;
        Rating = rating;
    }
}

class Player
{
    public string Name;
    public int Level;
    public int Gold;

    public Player(string name, int level, int gold)
    {
        Name = name;
        Level = level;
        Gold = gold;
    }
}

class Product
{
    public string Name;
    public string Category;
    public decimal Price;
    public bool InStock;

    public Product(string name, string category, decimal price, bool inStock)
    {
        Name = name;
        Category = category;
        Price = price;
        InStock = inStock;
    }
}

class Order
{
    public string Customer;
    public decimal Amount;
    public bool Paid;

    public Order(string customer, decimal amount, bool paid)
    {
        Customer = customer;
        Amount = amount;
        Paid = paid;
    }
}
