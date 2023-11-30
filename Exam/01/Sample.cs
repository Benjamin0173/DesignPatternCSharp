using System;

class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int EngineSize { get; set; }
    public bool HasSunroof { get; set; }

    public void Display()
    {
        Console.WriteLine($"Car: {Model}, Color: {Color}, Engine Size: {EngineSize}L, Sunroof: {(HasSunroof ? "Yes" : "No")}");
    }
}


abstract class CarBuilder
{
    protected Car car;

    public void CreateCar()
    {
        car = new Car();
    }

    public abstract void SetModel();
    public abstract void SetColor();
    public abstract void SetEngineSize();
    public abstract void SetSunroof();

    public Car GetCar()
    {
        return car;
    }
}


class SedanCarBuilder : CarBuilder
{
    public override void SetModel()
    {
        car.Model = "Sedan";
    }

    public override void SetColor()
    {
        car.Color = "Black";
    }

    public override void SetEngineSize()
    {
        car.EngineSize = 2;
    }

    public override void SetSunroof()
    {
        car.HasSunroof = false;
    }
}


class CarManufacturer
{
    private CarBuilder builder;

    public CarManufacturer(CarBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructCar()
    {
        builder.CreateCar();
        builder.SetModel();
        builder.SetColor();
        builder.SetEngineSize();
        builder.SetSunroof();
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        CarBuilder builder = new SedanCarBuilder();
        CarManufacturer manufacturer = new CarManufacturer(builder);

        manufacturer.ConstructCar();

        Car car = builder.GetCar();
        car.Display();
    }
}
