#region main

var nikon = Camera.GetCamera("Nikon");
var sony = Camera.GetCamera("Sony");
var nikon1 = Camera.GetCamera("Nikon");

Console.WriteLine($"Nikon : {nikon.Id}");
Console.WriteLine($"Nikon1: {nikon1.Id}");
Console.WriteLine($"Sony  : {sony.Id}");

#endregion


class Camera
{
    public static Dictionary<string, Camera> _cameras = new Dictionary<string, Camera>();
    private static object _lock = new object();
    public Guid Id { get; set; }

    private Camera()
    {
        Id = Guid.NewGuid();
    }

    public static Camera GetCamera(string brand)
    {
        lock (_lock)
        {
            if (!_cameras.ContainsKey(brand))
            {
                _cameras.Add(brand, new Camera());
            }
        }

        return _cameras[brand];
    }
}
