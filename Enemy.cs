class Lamp
{
    public void Switch(Action action)
    {
        action?.Invoke();
    }

    public void TurnOn()
    {
        Console.WriteLine("Лампочка включена");
    }

    public void TurnOff()
    {
        Console.WriteLine("Лампочка выключена");
    }
}

class Calculator
{
    public static int Calculate(Func<int, int, int> operation, int a, int b)
    {
        return operation(a, b);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        return a / b;
    }
}

class NumberChecker
{
    public bool Check(Predicate<int> predicate, int number)
    {
        return predicate(number);
    }

    public bool IsPositive(int number)
    {
        return number > 0;
    }

    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public bool IsNegative(int number)
    {
        return number < 0;
    }
}

class Messenger
{
    public void Message(Action<string> action, string message)
    {
        action(message);
    }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void DisplayUpperMessage(string message)
    {
        Console.WriteLine(message.ToUpper());
    }
}

class Rectangle
{
    public static int Calculate(Func<int, int, int> formula, int longside, int shortside)
    {
        Console.WriteLine(formula(longside, shortside)); // я понимаю что мы возвращаем значение и должны выводить его в другом месте, но сейчас это обучение, так что для сокращения кода напишу вывод сразу тут
        return formula(longside, shortside);
    }

    public static int Perimeter(int longside, int shortside)
    {
        return longside * 2 + shortside * 2;
    }

    public static int Square(int longside, int shortside)
    {
        return longside * shortside;
    }
}

class Player
{
    public int Health { get; private set; }
    public event Action OnDeath;

    public Player(int health)
    {
        if (health < 0)
            return;

        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            return;
        Health -= damage;
        Console.WriteLine($"Игрок получил {damage} урона");

        if (Health <= 0)
        {
            OnDeath += MessageDeath;
            OnDeath += PlaySoundDeath;
            OnDeath += DisplayScreenDeath;
            OnDeath();
        }
    }

    void MessageDeath() // ставлю private, ибо не вижу смысла в выводе активностей связанных с смертью персонажа по вне этого класса, поправь меня если я не прав
    {
        Console.WriteLine("Игрок умер");
    }

    void PlaySoundDeath()
    {
        Console.WriteLine("Звук смерти");
    }

    void DisplayScreenDeath()
    {
        Console.WriteLine("Экран смерти");
    }
}

class PlayerHealthChange
{
    public int Health { get; private set; }

    public event Action<int> OnHealthChanged;

    public PlayerHealthChange(int health)
    {
        if (health < 0)
            return;

        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
            return;
        Health -= damage;
        OnHealthChanged?.Invoke(Health);
    }

    public void ActualHealth(int health)
    {
        if (health >= 30)
            Console.WriteLine($"Осталось: {health} здоровья");
    }

    public void WarningLowHealth(int health)
    {
        if (Health < 30)
        {
            Console.WriteLine("Низкий уровень здоровья!");
        }
    }
}

class Door
{
    public event Action OnOpenDoor;
    public event Action OnClosed;

    public void Open()
    {
        OnOpenDoor?.Invoke();
    }

    public void Close()
    {
        OnClosed?.Invoke();
    }

    public void SoundOpenDoor()
    {
        Console.WriteLine("Дверь откртылась (звук)");
    }

    public void DisplayMessageOpen()
    {
        Console.WriteLine("Дверь откртылась");
    }

    public void LightOn()
    {
        Console.WriteLine("Свет включлся");
    }

    public void SoundCloseDoor()
    {
        Console.WriteLine("Дверь закрылась (звук)");
    }

    public void DisplayMessageClose()
    {
        Console.WriteLine("Дверь закрылась");
    }

    public void LightOff()
    {
        Console.WriteLine("Свет выключлся");
    }
}
