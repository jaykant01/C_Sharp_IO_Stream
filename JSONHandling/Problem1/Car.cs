using Newtonsoft.Json;
namespace JSONHandling;

public class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
}

class CarJson
{
    public static void ConvertCarToJson()
    {
        Car car = new Car { Brand = "Tesla", Year = 2024 };
        string json = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine("\nCar JSON:\n" + json);
    }
}
