


Product mouse = new Product(50);
Product keyboard = new Product(35);

keyboard.StockControlEvent += Keyboard_StockControlEvent;

static void Keyboard_StockControlEvent()
{
    Console.WriteLine($"Keyboard is about to out of stock!");
}

mouse.ProductName = "Mouse";
keyboard.ProductName = "Keyboard";

for (int i = 0; i < 5; i++)
{
    mouse.Sell(10);
    keyboard.Sell(10);
    Console.ReadLine();
}


public delegate void StockControl();

public class Product
{
    private int _stock;
    public Product(int stock)
    {
        _stock = stock;
    }

    public event StockControl StockControlEvent;
    public string ProductName { get; set; }
    public int Stock
    {
        get
        {
            return _stock;
        }
        set
        {
            _stock = value;
            if (value <= 15 && StockControlEvent != null)
            {
                StockControlEvent();
            }
        }
    }

    public void Sell(int amount)
    {
        if (amount <= Stock)
        {
            Stock -= amount;
            Console.WriteLine($"Stock Amount: {Stock}");
        }
        else
        {
            Console.WriteLine($"There is not enough Stock for this sale amount ({amount}). Stock Amount: {Stock}");
        }
    }
}
