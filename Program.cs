class Programm
{
    static void Main()
    {
        // var Names = new List<string>();
        // Names.Add("Алекссандр");
        // Names.Add("Алекссандр");
        // Names.Add("Алекссандр");
        // Names.Add("Алекссандр");
        // Names.Add("Алекссандр");
        // foreach (string name in Names)
        // {
        //     Console.WriteLine(name);
        // }
        // Names.RemoveAt(1);
        // Console.WriteLine(Names.Count());

        // var Players = new Dictionary<string, int>();
        // Players.Add("Александр", 120);
        // Players.Add("Виктор", 30);
        // Players.Add("Константин", 50);
        // Players.Add("Марат", 70);
        // Console.WriteLine(Players["Александр"]);
        // Console.WriteLine(Players.ContainsKey("Александр"));

        // foreach (var player in Players)
        // {
        //     Console.WriteLine($"Имя игрока - {player.Key}, уровень игрока - {player.Value}");
        // }

        // var queue = new Queue<string>();
        // queue.Enqueue("Игрок 1");
        // queue.Enqueue("Игрок 2");
        // queue.Enqueue("Игрок 3");
        // queue.Enqueue("Игрок 4");
        // queue.Dequeue();
        // foreach (string player in queue)
        // {
        //     Console.WriteLine(player);
        // }
        // Console.WriteLine(queue.Count());

        // var stak = new Stack<string>();
        // stak.Push("Действие 1");
        // stak.Push("Действие 2");
        // stak.Push("Действие 3");
        // stak.Push("Действие 4");
        // string LastAction = stak.Peek();
        // Console.WriteLine(LastAction);
        // stak.Pop();
        // foreach (string action in stak)
        // {
        //     Console.WriteLine(action);
        // }
        // Console.WriteLine(stak.Count());

        // Dictionary<string, int> scores = new Dictionary<string, int>();

        // var Players = new Dictionary<string, int>();
        // Players.Add("Masha", 40);
        // Players.Add("Any", 140);
        // Players.Add("Kitill", 20);
        // Players.Add("Eldar", 10);

        // var queueFight = new Queue<string>();
        // queueFight.Enqueue("Деруться Маша и Аня");
        // queueFight.Enqueue("Деруться Максим и Кирил");

        // var lastAction = new Stack<string>();
        // lastAction.Push("Максим совершил действие 1");
        // lastAction.Push("Максим совершил действие 2");
        // lastAction.Push("Максим совершил действие 3");
        // lastAction.Push("Максим совершил действие 4");

        // var players = new HashSet<string>();
        // players.Add("Маша");
        // players.Add("Александр");
        // players.Add("Маша");
        // players.Add("Александр");
        // players.Add("Кирилл");
        // players.Add("Маша");

        // foreach (string player in players)
        // {
        //     Console.WriteLine(player);
        // }
        // Console.WriteLine(players.Count);

        // var rooms = new HashSet<int>();
        // rooms.Add(1);
        // rooms.Add(2);
        // rooms.Add(1);
        // rooms.Add(3);
        // rooms.Add(3);
        // rooms.Add(4);
        // rooms.Add(2);
        // rooms.Add(1);

        // foreach (int room in rooms)
        // {
        //     Console.WriteLine($"Игрок посетил комнату {room}");
        // }

        // var players = new Dictionary<string, int>();
        // var namePlayers = new List<string>();

        // players.Add("Александр", 20);
        // players.Add("Маша", 40);
        // players.Add("Кирил", 60);

        // namePlayers.Add("Александр");
        // namePlayers.Add("Маша");
        // namePlayers.Add("Кирил");

        // foreach (string namePlayer in namePlayers)
        // {
        //     Console.WriteLine($"Имя игрока - {namePlayer}, его уровень - {players[namePlayer]}");
        // }

        // var quequeFight = new Queue<string>();
        // quequeFight.Enqueue("Александр");
        // quequeFight.Enqueue("Маша");
        // quequeFight.Enqueue("Кирил");

        // Console.WriteLine(
        //     $"На бой выходит {quequeFight.Peek()}, у него {players[quequeFight.Peek()]} здоровья"
        // );

        // var newItems = new List<string>();
        // var uniqueItems = new HashSet<string>();

        // newItems.Add("Палка");

        // newItems.Add("Бутылка воды");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Бутылка пива");
        // newItems.Add("Свиной оккорок");
        // newItems.Add("Свиной оккорок");
        // newItems.Add("Палка");

        // foreach (string item in newItems)
        // {
        //     uniqueItems.Add(item);
        // }

        // foreach (string uniqueItem in uniqueItems)
        // {
        //     Console.WriteLine(uniqueItem);
        // }
        // Console.WriteLine(newItems.Count);
        // Console.WriteLine(uniqueItems.Count);

        var players = new Dictionary<int, string>();
        var listAllId = new List<int>();
        var processedId = new HashSet<int>();

        players.Add(1, "Маша");
        players.Add(2, "Кирил");
        players.Add(3, "Максим");

        listAllId.Add(1);
        listAllId.Add(2);
        listAllId.Add(3);

        foreach (int id in listAllId)
        {
            if (processedId.Add(id))
            {
                Console.WriteLine($"Обрабатываем ID: {id}, имя: {players[id]}");
            }
        }
    }
}
