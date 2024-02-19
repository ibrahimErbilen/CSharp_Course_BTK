
ProductDirector productDirector = new ProductDirector();
ProductDirector productDirector2 = new ProductDirector();

var builder = new NewCustomerProductBuilder();
var builder2 = new OldCustomerProductBuilder();

productDirector.GenerateProduct(builder);
productDirector2.GenerateProduct(builder2);

var model = builder.GetModel();
var model2 = builder2.GetModel();

Console.WriteLine($"New Customer Builder");
Console.WriteLine($"{model.Id}");
Console.WriteLine($"{model.CategoryName}");
Console.WriteLine($"{model.ProductName}");
Console.WriteLine($"{model.DiscountApplied}");
Console.WriteLine($"{model.DiscountedPrice}");
Console.WriteLine($"{model.UnitPrice}");

Console.WriteLine($"\nOld Customer Builder");
Console.WriteLine($"{model2.Id}");
Console.WriteLine($"{model2.CategoryName}");
Console.WriteLine($"{model2.ProductName}");
Console.WriteLine($"{model2.DiscountApplied}");
Console.WriteLine($"{model2.DiscountedPrice}");
Console.WriteLine($"{model2.UnitPrice}");

class ProductViewModel
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal DiscountedPrice { get; set; }
    public bool DiscountApplied { get; set; }
}

abstract class ProductBuilder
{
    public abstract void GetProductData();
    public abstract void ApplyDiscount();
    public abstract ProductViewModel GetModel();
}

class NewCustomerProductBuilder : ProductBuilder
{
    ProductViewModel model = new ProductViewModel();
    public override void ApplyDiscount()
    {
        model.DiscountedPrice = model.UnitPrice * (decimal)0.9;
        model.DiscountApplied = true;
    }

    public override ProductViewModel GetModel()
    {
        return model;
    }

    public override void GetProductData()
    {
        model.Id = 1;
        model.CategoryName = "Beverages";
        model.ProductName = "Chai";
        model.UnitPrice = 20;
    }
}

class OldCustomerProductBuilder : ProductBuilder
{
    ProductViewModel model = new ProductViewModel();
    public override void ApplyDiscount()
    {
        model.DiscountedPrice = model.UnitPrice;
        model.DiscountApplied = false;
    }

    public override ProductViewModel GetModel()
    {
        return model;
    }

    public override void GetProductData()
    {
        model.Id = 1;
        model.CategoryName = "Beverages";
        model.ProductName = "Chai";
        model.UnitPrice = 20;
    }
}

class ProductDirector
{
    public void GenerateProduct(ProductBuilder productBuilder)
    {
        productBuilder.GetProductData();
        productBuilder.ApplyDiscount();
    }
}
