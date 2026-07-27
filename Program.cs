class Programm
{
    static async Task Main()
    {
        Ork ork = new Ork("Ork", 200, 300, 40, 60);
        Console.WriteLine(ork.HaveArmor);

        var allItems = new Dictionary<int, Item>();
        allItems.Add(1, new Potion("Зелье лечения", 50, 100));
        allItems.Add(2, new Scroll("Древний свиток", 10, 300));
        allItems.Add(3, new Sword("Обычный меч", 60, 30));
        allItems.Add(4, new Arch("Драконий лук", 80, 1000));
        allItems.Add(5, new Key("Ключ от дома", 2, 10));

        Shop shop = new Shop(allItems);

        Player player = new Player("Семён", 40, 100, 300, 1500, 120);
        Goblin goblin = new Goblin("Гоблин", 30, 150, 25);
        Dragon dragon = new Dragon("Дракон", 300, 300, 20);

        player.AllPrice();
        CycleFight.Fight(goblin, "обычный удар", dragon, "Огенный урон");

        CycleFight.TypeOfDamageWrestlerOne += (string typeOfStrike) =>
        {
            return typeOfStrike;
        };
        CycleFight.TypeOfDamageWrestlerTwo += (string typeOfStrike) =>
        {
            return typeOfStrike;
        };

        player.AddItem(allItems[2]);

        player.BuyItem("Древний свиток");
        player.BuyItem("Драконий лук");
        player.BuyItem("Драконий лук");
        player.ShowItems();
        Console.WriteLine(player.Gold);
        player.SaleItem("Драконий лук");
        player.ShowItems();
        Console.WriteLine(player.Gold);
        Dungeon dungeon = new Dungeon();

        await dungeon.LoadDungeon();
    }
}
