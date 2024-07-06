static void Inform()
{
    Console.WriteLine("O V O N");

    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    Console.Write($"Hello {name}! ");

    Console.Write("Enter your product: ");
    string product = Console.ReadLine();

    Console.Write("Enter count your product: ");
    string count = Console.ReadLine();

    Console.Write("Enter your address: ");
    string address = Console.ReadLine();

    Console.WriteLine($"Здравствуйте, {name}, вы заказали {count} {product} на адрес {address}, все верно?");
    Check(name, product, count, address);
}
Inform();
static void Check(string name, string product, string count, string address)
{
    string check = Console.ReadLine();
    if (check == "Да" || check == "Yes")
    {
        Console.WriteLine($"{name}!Ваш заказ {product} в количестве {count} оформлен! Ожидайте доставку по адресу {address}  к 5 июля");
    }
    else
    {
        Inform();
    }
}
