// Абстрактний клас Button
abstract class Button
{
    public abstract void Paint();
}

// Клас ButtonFactory
abstract class ButtonFactory
{
    public abstract Button CreateButton();
}

// Конкретні класи Button
class WindowsButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("Render a button in Windows style.");
    }
}

class IOSButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("Render a button in iOS style.");
    }
}

class AndroidButton : Button
{
    public override void Paint()
    {
        Console.WriteLine("Render a button in Android style.");
    }
}

// Конкретні фабрики для стилів кнопок
class WindowsButtonFactory : ButtonFactory
{
    public override Button CreateButton()
    {
        return new WindowsButton();
    }
}

class IOSButtonFactory : ButtonFactory
{
    public override Button CreateButton()
    {
        return new IOSButton();
    }
}

class AndroidButtonFactory : ButtonFactory
{
    public override Button CreateButton()
    {
        return new AndroidButton();
    }
}

// Клієнтський код
class Client
{
    private ButtonFactory buttonFactory;
    private Button button;

    public Client(ButtonFactory factory)
    {
        buttonFactory = factory;
    }

    public void Run()
    {
        button = buttonFactory.CreateButton();
        button.Paint();
    }
}