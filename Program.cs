class Programm
{
    public static void Main()
    {
        // Game game1 = new Game("The Witcher 3: Wild Hunt", "RPG", 1499, 9.8);
        // Game game2 = new Game("Cyberpunk 2077", "RPG", 1999, 8.5);
        // Game game3 = new Game("Red Dead Redemption 2", "Action-adventure", 2499, 9.7);
        // Game game4 = new Game("God of War Ragnarok", "Action-adventure", 2999, 9.6);
        // Game game5 = new Game("Elden Ring", "Soulslike", 2499, 9.5);
        // Game game6 = new Game("Hades", "Roguelike", 899, 9.4);
        // Game game7 = new Game("Stardew Valley", "Simulation", 499, 9.7);
        // Game game8 = new Game("Doom Eternal", "Shooter", 1499, 9.2);
        // Game game9 = new Game("Resident Evil 4 Remake", "Survival horror", 2499, 9.3);
        // Game game10 = new Game("Baldur's Gate 3", "RPG", 2699, 9.8);

        // List<Game> games = new List<Game>
        // {
        //     game1,
        //     game2,
        //     game3,
        //     game4,
        //     game5,
        //     game6,
        //     game7,
        //     game8,
        //     game9,
        //     game10,
        // };

        // var resultGames = games
        //     .Where(game => game.Rating > 8.5)
        //     .OrderByDescending(game => game.Rating)
        //     .Select(game => game.Name);
        // foreach (var game in resultGames)
        // {
        //     Console.WriteLine(game);
        // }

        string[] names =
        {
            "Артем",
            "Елена",
            "Максим",
            "Анна",
            "Дмитрий",
            "Ольга",
            "Сергей",
            "Мария",
            "Алексей",
            "Наталья",
            "Иван",
            "Светлана",
            "Павел",
            "Екатерина",
            "Михаил",
            "Татьяна",
            "Андрей",
            "Юлия",
            "Николай",
            "Ирина",
            "Виктор",
            "Анастасия",
            "Георгий",
            "Ксения",
            "Владимир",
            "Полина",
            "Константин",
            "Вероника",
            "Степан",
            "Алиса",
        };

        int[] levels =
        {
            5,
            12,
            8,
            20,
            3,
            15,
            7,
            25,
            10,
            18,
            1,
            22,
            14,
            9,
            30,
            6,
            11,
            16,
            4,
            28,
            19,
            13,
            2,
            24,
            17,
            21,
            26,
            23,
            27,
            29,
        };

        int[] golds =
        {
            150,
            480,
            230,
            1250,
            80,
            720,
            190,
            2100,
            410,
            980,
            50,
            1670,
            650,
            310,
            3500,
            120,
            550,
            830,
            95,
            2800,
            1050,
            590,
            60,
            1850,
            890,
            1420,
            2450,
            1730,
            2650,
            3100,
        };

        List<Player> players = new List<Player>();

        for (int i = 0; i < 30; i++)
        {
            players.Add(new Player(names[i], levels[i], golds[i]));
        }

        var MaxLevelPlayer = players.Max(player => player.Level);
        var AverageLevel = players.Average(player => player.Level);
        var AllSumGold = players.Sum(player => player.Gold);
        var Have50Level = players.Any(player => player.Level >= 50);
        var GoldPlayers = players.All(player => player.Gold > 0);

        // Console.WriteLine(MaxLevelPlayer);
        // Console.WriteLine(AverageLevel);
        // Console.WriteLine(AllSumGold);
        // Console.WriteLine(Have50Level);
        // Console.WriteLine(GoldPlayers);

        List<Product> products = new List<Product>
        {
            new Product("Ноутбук", "Электроника", 85000m, true),
            new Product("Смартфон", "Электроника", 45000m, true),
            new Product("Наушники", "Аксессуары", 3500m, false),
            new Product("Книга 'Война и мир'", "Книги", 1200m, true),
            new Product("Футболка", "Одежда", 1800m, true),
            new Product("Кроссовки", "Обувь", 7500m, false),
            new Product("Планшет", "Электроника", 32000m, true),
            new Product("Кофеварка", "Бытовая техника", 12000m, true),
            new Product("Монитор", "Электроника", 28000m, false),
            new Product("Стул", "Мебель", 6500m, true),
            new Product("Рюкзак", "Аксессуары", 4200m, true),
            new Product("Телевизор", "Электроника", 65000m, true),
            new Product("Джинсы", "Одежда", 3500m, false),
            new Product("Пылесос", "Бытовая техника", 18000m, true),
            new Product("Стол", "Мебель", 12000m, true),
            new Product("Клавиатура", "Электроника", 4500m, false),
            new Product("Сумка", "Аксессуары", 2800m, true),
            new Product("Микроволновка", "Бытовая техника", 9000m, true),
            new Product("Шкаф", "Мебель", 25000m, false),
            new Product("Мышка", "Электроника", 1500m, true),
        };

        var resultProduct = products
            .Where(product => product.InStock && product.Price < 5000)
            .OrderBy(product => product.Price)
            .Select(product => product.Name);
        // foreach (string product in resultProduct)
        // {
        //     Console.WriteLine(product);
        // }
        var resultPlayers2 = players
            .Where(player => player.Level > 20)
            .OrderByDescending(player => player.Level)
            .Take(10)
            .Skip(3)
            .Select(player => player.Name);

        // foreach (var playerr in resultPlayers2)
        // {
        //     Console.WriteLine(playerr);
        // }

        List<Order> orders = new List<Order>
        {
            new Order("Иван Петров", 1500m, true),
            new Order("Мария Смирнова", 3200m, false),
            new Order("Алексей Иванов", 850m, true),
            new Order("Елена Козлова", 4200m, true),
            new Order("Дмитрий Соколов", 2300m, false),
            new Order("Ольга Михайлова", 5600m, true),
            new Order("Сергей Федоров", 1200m, true),
            new Order("Анна Морозова", 7800m, false),
            new Order("Павел Волков", 3450m, true),
            new Order("Наталья Зайцева", 2100m, true),
            new Order("Михаил Орлов", 9300m, false),
            new Order("Татьяна Киселева", 1800m, true),
            new Order("Андрей Макаров", 6700m, true),
            new Order("Юлия Андреева", 4500m, false),
            new Order("Николай Григорьев", 2900m, true),
            new Order("Ирина Никитина", 8100m, true),
            new Order("Виктор Степанов", 3700m, false),
            new Order("Светлана Егорова", 5200m, true),
            new Order("Георгий Семенов", 6400m, true),
            new Order("Ксения Осипова", 1100m, false),
            new Order("Владимир Тихонов", 4800m, true),
            new Order("Полина Фомина", 7200m, true),
            new Order("Константин Новиков", 3900m, false),
            new Order("Вероника Кузнецова", 5600m, true),
            new Order("Степан Белов", 2600m, true),
            new Order("Алиса Карпова", 8400m, false),
            new Order("Артем Денисов", 1900m, true),
            new Order("Екатерина Шмидт", 7100m, true),
            new Order("Максим Лебедев", 4300m, false),
            new Order("Дарья Маркова", 9800m, true),
            new Order("Александр Фролов", 3100m, true),
            new Order("Оксана Соловьева", 6700m, false),
            new Order("Даниил Куликов", 5400m, true),
            new Order("Валентина Захарова", 2200m, true),
            new Order("Игорь Борисов", 7600m, false),
            new Order("Евгения Гусева", 3800m, true),
            new Order("Станислав Павлов", 6200m, true),
            new Order("Людмила Виноградова", 1500m, false),
            new Order("Василий Сергеев", 4900m, true),
            new Order("Надежда Романова", 8500m, true),
            new Order("Евгений Щербаков", 2700m, false),
            new Order("Галина Ковалева", 6000m, true),
            new Order("Борис Тимофеев", 3200m, true),
            new Order("Анастасия Чернова", 9300m, false),
            new Order("Леонид Мартынов", 1800m, true),
            new Order("Лилия Емельянова", 7400m, true),
            new Order("Аркадий Голубев", 5100m, false),
            new Order("Инна Полякова", 2900m, true),
            new Order("Никита Цветков", 6600m, true),
            new Order("Алла Богданова", 8200m, false),
        };

        int CountPaidOrder = orders.Count(order => order.Paid);
        decimal SumPaidOrder = orders.Where(order => order.Paid).Sum(product => product.Amount);
        bool Order50k = orders.Any(product => product.Amount > 50000);

        decimal AverageSumOrder = orders
            .Where(product => product.Paid)
            .Average(product => product.Amount);
        var SortOrder = orders
            .OrderBy(product => product.Amount)
            .Select(product => product.Customer);
        Console.WriteLine(CountPaidOrder);
        Console.WriteLine(SumPaidOrder);
        Console.WriteLine(Order50k);
        Console.WriteLine(AverageSumOrder);
        foreach (var Customer in SortOrder)
        {
            Console.WriteLine(Customer);
        }
    }
}
