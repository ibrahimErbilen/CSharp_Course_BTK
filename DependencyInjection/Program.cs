#region main

IKernel kernel = new StandardKernel();
// kernel.Bind<IProductDal>().To<NHProductDal>().InSingletonScope();
kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

ProductManager productManager = new ProductManager(kernel.Get<IProductDal>());
productManager.Save();

#endregion


public interface IProductDal
{
    void Save();
}

public class EfProductDal : IProductDal
{
    public void Save()
    {
        Console.WriteLine($"Saved with EF");
    }
}

public class NHProductDal : IProductDal
{
    public void Save()
    {
        Console.WriteLine($"Saved with NH");
    }
}

public class ProductManager
{
    private IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void Save()
    {
        _productDal.Save();
    }
}
