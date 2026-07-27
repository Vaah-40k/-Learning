class Program
{
    static async Task Main()
    {
        Console.Title = "Dungeon System Demo";

        await DemonstrateDungeonLoading();

        DemonstrateCharacters();

        DemonstrateInventory();

        DemonstrateShop();

        DemonstrateBattle();

        Console.WriteLine();
        Console.WriteLine("=== Демонстрация завершена ===");
    }

    static async Task DemonstrateDungeonLoading()
    {
        Console.WriteLine("=== Загрузка подземелья ===");

        Dungeon dungeon = new Dungeon();
        await dungeon.LoadDungeon();

        Console.WriteLine();
    }

    static void DemonstrateCharacters()
    {
        Console.WriteLine("=== Персонажи ===");

        Dragon dragon = new Dragon("Дракон", 300, 300, 40);
        Goblin goblin = new Goblin("Гоблин", 100, 100, 15);
        Ork ork = new Ork("Орк", 200, 200, 30, 50);

        dragon.Fly();
        goblin.StealingGold();

        Console.WriteLine($"Броня орка: {ork.HaveArmor}");
        Console.WriteLine();
    }

    static void DemonstrateInventory()
    {
        Console.WriteLine("=== Инвентарь ===");

        Player player = new Player("Семён", 100, 100, 30, 1500, 120);

        player.AddItem(new Sword("Стальной меч", 30, 300));
        player.AddItem(new Potion("Зелье лечения", 10, 100));
        player.AddItem(new Scroll("Свиток огня", 5, 500));

        player.ShowItems();

        Console.WriteLine();
    }

    static void DemonstrateShop()
    {
        Console.WriteLine("=== Магазин ===");

        Dictionary<int, Item> items = new()
        {
            { 1, new Sword("Меч", 40, 300) },
            { 2, new Potion("Зелье", 10, 100) },
            { 3, new Scroll("Свиток", 5, 500) },
        };

        Shop shop = new Shop(items);

        Shop.ShowAssortment();

        Console.WriteLine();
    }

    static void DemonstrateBattle()
    {
        Console.WriteLine("=== Бой ===");

        CycleFight.TypeOfDamageWrestlerOne += type => type;
        CycleFight.TypeOfDamageWrestlerTwo += type => type;

        Goblin goblin = new Goblin("Гоблин", 100, 100, 20);
        Dragon dragon = new Dragon("Дракон", 250, 250, 35);

        CycleFight.Fight(goblin, "обычным ударом", dragon, "огненным дыханием");
    }
}
