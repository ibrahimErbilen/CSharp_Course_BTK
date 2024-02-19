

var personalCar = new PersonalCar { Brand = "Honda", Model = "Civic", RentPrice = 2900 };

SpecialOffer specialOffer = new SpecialOffer(personalCar);
specialOffer.DiscountPercentage = 10;

Console.WriteLine($"Concrete: {personalCar.RentPrice}");
Console.WriteLine($"SpecialOffer: {specialOffer.RentPrice}");


abstract class CarBase
{
    public abstract string Brand { get; set; }
    public abstract string Model { get; set; }
    public abstract decimal RentPrice { get; set; }
}

class PersonalCar : CarBase
{
    public override string Brand { get; set; }
    public override string Model { get; set; }
    public override decimal RentPrice { get; set; }
}

class CommercialCar : CarBase
{
    public override string Brand { get; set; }
    public override string Model { get; set; }
    public override decimal RentPrice { get; set; }
}


abstract class CarDecoratorBase : CarBase
{
    CarBase _carBase;

    protected CarDecoratorBase(CarBase carBase)
    {
        _carBase = carBase;
    }
}


class SpecialOffer : CarDecoratorBase
{
    public int DiscountPercentage { get; set; }
    private readonly CarBase _carBase;

    public SpecialOffer(CarBase carBase) : base(carBase)
    {
        _carBase = carBase;
    }

    public override string Brand { get; set; }
    public override string Model { get; set; }
    public override decimal RentPrice
    {
        get { return _carBase.RentPrice - _carBase.RentPrice * DiscountPercentage / 100; }
        set
        {

        }
    }
}
