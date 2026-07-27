using Spectre.Console;

abstract class Character
{
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }
    public int Damage { get; protected set; }

    public Character(string name, int health, int maxHealth, int damage) // праильно ли я назвал maxHealth ?
    {
        if (health < 0 || maxHealth < 0 || damage < 0)
            throw new Exception("Введены невалидные значения");

        Name = name;
        Health = health;
        MaxHealth = maxHealth;
        Damage = damage;
    }

    public void Attack(string nameEnemy, string typeOfDamage)
    {
        Console.WriteLine($"{Name} ударил {typeOfDamage} {nameEnemy}");
    }

    public void TakeDamage(int damageEnemy)
    {
        if (damageEnemy < 0)
        {
            try
            {
                throw new Exception("Веденно некоректное значение урона");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        else
        {
            Console.WriteLine($"{Name} получил {damageEnemy} урона");
            Health -= damageEnemy;
            HealthZero();
            if (Health < MaxHealth * 0.2)
            {
                Console.WriteLine($"У {Name} критический уровень здоровья!");
            }
        }
    }

    void HealthZero()
    {
        if (Health < 0)
            Health = 0;
    }
}

abstract class Inventory : Character
{
    public int MaxWeightInventory { get; private set; }
    public int ActualWeightInventory { get; private set; }
    public List<Item> ItemsInventory { get; protected set; }

    public Inventory(string name, int health, int maxHealth, int damage, int maxWeightInventory)
        : base(name, health, maxHealth, damage)
    {
        if (maxWeightInventory <= 0)
            throw new Exception("Ведены невалидные данные");
        MaxWeightInventory = maxWeightInventory;
        ItemsInventory = new List<Item>();
        ActualWeightInventory = 0;
    }

    public void AddItem(Item item)
    {
        if (item.Weight + ActualWeightInventory <= MaxWeightInventory)
        {
            ItemsInventory.Add(item);
            ActualWeightInventory += item.Weight;
            Console.WriteLine($"Вы положили в интвентарь - {item.Name}");
        }
        else
        {
            try
            {
                throw new Exception("Вес слишком большой, больше положить в инвентарь нельзя");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }

    public bool SearchItem(string itemName)
    {
        int CountSearchItem = ItemsInventory.Count(item => item.Name == itemName);
        if (CountSearchItem <= 0)
        {
            try
            {
                throw new Exception("Такого предмета нет в вашем инвенторе");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return false;
            }
        }
        else
        {
            Console.WriteLine($"В вашем инвенторе лежат {CountSearchItem} {itemName}");
            return true;
        }
    }

    public void DeleteItem(string itemName)
    {
        bool hasElmentBeenFoundOrNot = SearchItem(itemName);
        if (hasElmentBeenFoundOrNot)
        {
            bool delete = AnsiConsole.Confirm($"Удалить {itemName} из инвентаря?");
            if (delete)
            {
                var item = ItemsInventory.First(item => item.Name == itemName);
                ItemsInventory.Remove(item);
            }
        }
    }

    public void ShowItems()
    {
        foreach (var item in ItemsInventory)
        {
            Console.WriteLine(item.Name);
        }
    }

    public void SortPrice()
    {
        var sortedPrice = ItemsInventory.OrderByDescending(item => item.Price).ToList();
        ItemsInventory = sortedPrice;
        ShowItems();
    }

    public void AllPrice()
    {
        int sum = ItemsInventory.Sum(item => item.Price);

        Console.WriteLine($"Общая стоимость вашего инвенторя составляет: {sum}");
    }
}

abstract class Item
{
    public string Name { get; protected set; }
    public int Weight { get; protected set; }
    public int Price { get; protected set; }

    public Item(string name, int weight, int price)
    {
        if (weight <= 0 || price < 0)
            throw new Exception("Введены невалидные значениея");
        Name = name;
        Weight = weight;
        Price = price;
    }
}

class CycleFight
{
    public static Func<string, string> TypeOfDamageWrestlerOne;
    public static Func<string, string> TypeOfDamageWrestlerTwo;

    public static void Fight(
        Character wrestlerOne,
        string typeOfDamageWrestlerOne,
        Character wrestlerTwo,
        string typeOfDamageWrestlerTwo
    )
    {
        while (true)
        {
            wrestlerOne.Attack(
                wrestlerTwo.Name,
                TypeOfDamageWrestlerOne?.Invoke(typeOfDamageWrestlerOne)
            );
            wrestlerTwo.TakeDamage(wrestlerOne.Damage);
            if (wrestlerTwo.Health <= 0)
            {
                try
                {
                    throw new Exception($"{wrestlerTwo.Name} умер");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    break;
                }
            }
            wrestlerTwo.Attack(
                wrestlerOne.Name,
                TypeOfDamageWrestlerTwo?.Invoke(typeOfDamageWrestlerTwo)
            );
            wrestlerOne.TakeDamage(wrestlerTwo.Damage);
            if (wrestlerOne.Health <= 0)
            {
                try
                {
                    throw new Exception($"{wrestlerOne.Name} умер");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    break;
                }
            }
        }
    }
}

class Dungeon
{
    public async Task LoadMap()
    {
        await Task.Delay(3000);
        Console.WriteLine("Карта загружена");
    }

    public async Task LoadMonsters()
    {
        await Task.Delay(5000);
        Console.WriteLine("Монстры загружены");
    }

    public async Task LoadInventory()
    {
        await Task.Delay(2000);
        Console.WriteLine("Инвентарь загружен");
    }

    public async Task LoadDungeon()
    {
        Console.WriteLine("Начинается загрузка...");

        await Task.WhenAll(LoadMap(), LoadMonsters(), LoadInventory());

        Console.WriteLine("Подземелье готово.");
    }
}

interface IFly
{
    void Fly();
}

interface StealingGold
{
    void StealingGold();
}

interface HaveArmor
{
    public int HaveArmor { get; protected set; }
}

interface CanUse
{
    void Use();
}

interface IUse
{
    void Use();
}

class Player : Inventory, CanUse
{
    public int Gold { get; private set; }

    public Player(
        string name,
        int health,
        int maxHealth,
        int damage,
        int gold,
        int maxWeightInventory
    )
        : base(name, health, maxHealth, damage, maxWeightInventory)
    {
        if (gold <= 0)
            throw new Exception("Ведены невалидные данные");
        Gold = gold;
    }

    public void Use()
    {
        Console.WriteLine("Игрок умеет использовать предметы");
    }

    public void BuyItem(string itemName)
    {
        var itemInCollection = Shop.AllItems.Where(shopitem => shopitem.Value.Name == itemName);

        var haveItem = itemInCollection.Any();
        if (!haveItem)
        {
            try
            {
                throw new Exception("Такого предмета в магазине нет");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        foreach (var item in itemInCollection)
        {
            if (Gold - item.Value.Price >= 0)
            {
                AddItem(Shop.AllItems[item.Key]);
                Gold -= item.Value.Price;
            }
            else
            {
                Console.WriteLine("У вас недостаточно денег для покупки");
            }
        }
    }

    public void SaleItem(string itemName)
    {
        var itemInventory = ItemsInventory.FirstOrDefault(item => item.Name == itemName);
        if (itemInventory == null)
        {
            try
            {
                throw new Exception("В вашем инвенторе нет такого предмета");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        else
        {
            ItemsInventory.Remove(itemInventory);
            Gold += itemInventory.Price;
            Console.WriteLine(
                $"Вы успешно продали {itemName} и получили {itemInventory.Price} золота"
            );
        }
    }
}

class Shop
{
    public static Dictionary<int, Item> AllItems { get; private set; }

    public Shop(Dictionary<int, Item> allItems)
    {
        AllItems = new Dictionary<int, Item>();
        AllItems = allItems;
    }

    public static void ShowAssortment()
    {
        foreach (var item in Shop.AllItems)
        {
            Console.WriteLine(
                $"В наличии есть {item.Value.Name}, его стоимоть: {item.Value.Price}, а вес - {item.Value.Weight}"
            );
        }
    }
}

class Dragon : Character, IFly
{
    public Dragon(string name, int health, int maxHealth, int damage)
        : base(name, health, maxHealth, damage) { }

    public void Fly()
    {
        Console.WriteLine("Дракон летит");
    }
}

class Goblin : Character, StealingGold
{
    public Goblin(string name, int health, int maxHealth, int damage)
        : base(name, health, maxHealth, damage) { } // из класса в клас один и тот же конструктор, как его сократить ?

    public void StealingGold()
    {
        Console.WriteLine("Гоблин ворует золото");
    }
}

class Ork : Character, HaveArmor
{
    public int HaveArmor { get; set; } // тут помоему какая-то лажа, как сделать правильно броню ?

    public Ork(string name, int health, int maxHealth, int damage, int armor)
        : base(name, health, maxHealth, damage)
    {
        if (armor < 0)
            throw new Exception("Броня не может иметь отрицательную прочность"); // и тут я скоировал код с Character, это же плохо

        HaveArmor = armor;
    }
}

class Potion : Item, IUse
{
    public Potion(string name, int weight, int price)
        : base(name, weight, price) { }

    public void Use()
    {
        Console.WriteLine("Выпить зелье");
    }
}

class Scroll : Item, IUse
{
    public Scroll(string name, int weight, int price)
        : base(name, weight, price) { }

    public void Use()
    {
        Console.WriteLine("Прочиать свиток");
    }
}

class Sword : Item, IUse
{
    public Sword(string name, int weight, int price)
        : base(name, weight, price) { }

    public void Use()
    {
        Console.WriteLine("Атаковать мечом");
    }
}

class Arch : Item, IUse
{
    public Arch(string name, int weight, int price)
        : base(name, weight, price) { }

    public void Use()
    {
        Console.WriteLine("Стрелять из лука");
    }
}

class Key : Item
{
    public Key(string name, int weight, int price)
        : base(name, weight, price) { }
}
