class Programm
{
    public static void Main()
    {
        // Lamp lamp = new Lamp();
        // lamp.Switch(lamp.TurnOn);
        // lamp.Switch(lamp.TurnOff);

        // Console.WriteLine(Calculator.Calculate(Calculator.Sum, 123, 41));
        // Console.WriteLine(Calculator.Calculate(Calculator.Subtract, 123, 41));
        // Console.WriteLine(Calculator.Calculate(Calculator.Multiply, 123, 41));
        // Console.WriteLine(Calculator.Calculate(Calculator.Divide, 400, 10));

        // NumberChecker numberChecker = new NumberChecker();
        // Console.WriteLine(numberChecker.Chek(numberChecker.IsEven, 123));
        // Console.WriteLine(numberChecker.Chek(numberChecker.IsPositive, -1));
        // Console.WriteLine(numberChecker.Chek(numberChecker.IsNegative, 1));

        // нормальный ли вывод выше ? в плане длины

        // Messenger messenger = new Messenger();
        // messenger.Message(messenger.DisplayMessage, "хай");
        // messenger.Message(messenger.DisplayUpperMessage, "хай");

        //Rectangle.Calculate(Rectangle.Perimeter, 23, 432);
        //  Rectangle.Calculate(Rectangle.Square, 23, 432);

        // Player player = new Player(300);
        // player.TakeDamage(280);
        // player.TakeDamage(30);

        PlayerHealthChange playerHealthChange = new PlayerHealthChange(400);
        playerHealthChange.OnHealthChanged += playerHealthChange.ActualHealth;
        playerHealthChange.OnHealthChanged += playerHealthChange.WarningLowHealth;

        playerHealthChange.TakeDamage(180);
        playerHealthChange.TakeDamage(200);

        Door door = new Door();
        door.OnOpenDoor += door.SoundOpenDoor;
        door.OnOpenDoor += door.DisplayMessageOpen;
        door.OnOpenDoor += door.LightOn;

        door.Open();

        door.OnClosed += door.SoundCloseDoor;
        door.OnClosed += door.DisplayMessageClose;
        door.OnClosed += door.LightOff;
        door.Close();
    }
}
