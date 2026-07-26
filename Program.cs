class Program
{
    static async Task Main()
    {
        // await WaitTreeSeconds();
        // Console.WriteLine(await RollDice());
        // await Task.WhenAll(LoadWorld(), LoadPlayer());

        //  await Task.WhenAny(DownloadMusic(), DownloadMap(), DownloadTexture());
        await Task.WhenAll(LoadPlayer(), LoadWorld(), LoadSetting());
        Console.WriteLine("Первый файл загружен!");
    }

    static async Task WaitTreeSeconds()
    {
        Console.WriteLine("Ждём...");
        await Task.Delay(3000);
        Console.WriteLine("Готово");
    }

    static async Task<int> RollDice()
    {
        await Task.Delay(1000);
        Random rnd = new Random();
        int num = rnd.Next(7);
        return num;
    }

    static async Task LoadPlayer()
    {
        Console.WriteLine("Ждём 4 секунды");
        await Task.Delay(4000);
    }

    static async Task LoadWorld()
    {
        Console.WriteLine("Ждём 2 секунды");

        await Task.Delay(2000);
    }

    static async Task LoadSetting()
    {
        Console.WriteLine("Ждём 1 секунду");

        await Task.Delay(1000);
    }

    static async Task DownloadTexture()
    {
        Console.WriteLine("Ждём 2 секунды");

        await Task.Delay(2000);
    }

    static async Task DownloadMusic()
    {
        Console.WriteLine("Ждём 5 секунды");

        await Task.Delay(5000);
    }

    static async Task DownloadMap()
    {
        Console.WriteLine("Ждём 3 секунды");

        await Task.Delay(3000);
    }
}
