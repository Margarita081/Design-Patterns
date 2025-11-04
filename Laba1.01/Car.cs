using Laba1._01;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// obj - Car  properties - weight, lenght, maxSpeed
// obj - Vehichle prop - car + WheelDrive(front/back), class(hatchback, sedan, coupe
// obj - cargo = prop - car + tonnage, tank volume, axlesAmont
//  obj - tank, prop - car + Projectile caliber, shotsPeMinute, CrewSize
namespace Laba1._01;

public class Client
{

    public void Do(string type, string model)
    {
        switch (type)
        {
            case "Vehicle":
                var vehicleFactory = new VehicleFactory();
                Car car1 = model switch
                {
                    "Audi" => vehicleFactory.CreateAudi(),
                    "Honda" => vehicleFactory.CreateHonda(),
                    "Tesla" => vehicleFactory.CreateTesla(),
                    _ => throw new Exception("not find")
                };
                Console.WriteLine(car1);
                break;

            case "Cargo":
                var cargoFactory = new CargoFactory();
                Car car2 = model switch
                {
                    "Volvo" => cargoFactory.CreateVolvo(),
                    "Man" => cargoFactory.CreateMan(),
                    "Scania" => cargoFactory.CreateScania(),
                    _ => throw new Exception("not find")
                };
                Console.WriteLine(car2);
                break;

            case "Tank":
                var tankFactory = new TankFactory();
                Car car3 = model switch
                {
                    "Abrams" => tankFactory.CreateAbrams(),
                    "Merkava" => tankFactory.CreateMerkava(),
                    "Tiger" => tankFactory.CreateTiger(),
                    _ => throw new Exception("not find")
                };
                Console.WriteLine(car3);
                break;
            default:
                throw new Exception("Don't find nothing");
        }
    }
}

public abstract class Car
{
    public string Weight { get; set; }
    public string Length { get; set; }
    public string MaxSpeed { get; set; }

    public string Name { get; set; }
    public override string ToString()
    {
        return Name;
    }
}

public enum TypeVehicle
{
    Hatchback,
    Sedan,
    Coupe
}
public class Vehicle : Car
{
    public string WheelDrive { get; set; }
    public string Color { get; set; }

    public TypeVehicle TypeVehicle { get; set; }
}

public class Tank : Car
{
    public string ProiectileCaliber { get; set; }
    public string ShotsPerMinute { get; set; }
    public string CrewSize { get; set; }
}

public class Cargo : Car
{
    public string Tonnage { get; set; }
    public string TankVolume { get; set; }
    public string AxlesAmount { get; set; }
}


public class Audi : Vehicle
{
    public Audi()
    {
        Name = "Audi";
    }
}
public class Honda : Vehicle
{
    public Honda()
    {
        Name = "Honda";
    }
}
public class Tesla : Vehicle
{
    public Tesla()
    {
        Name = "Tesla";
    }
}

public class Volvo : Cargo
{
    public Volvo()
    {
        Name = "Volvo";
    }
}
public class Man : Cargo
{
    public Man()
    {
        Name = "Man";
    }
}

public class Scania : Cargo
{
    public Scania()
    {
        Name = "Scania";
    }
}

public class Abrams : Tank
{
    public Abrams()
    {
        Name = "Abrams";
    }
}

public class Merkava : Tank
{
    public Merkava()
    {
        Name = "Merkava";
    }
}
public class Tiger : Tank
{
    public Tiger()
    {
        Name = "Tiger";
    }
}

public interface IVehicleFactory
{
    Car CreateAudi();
    Car CreateHonda();
    Car CreateTesla();
}

public interface ICargoFactory
{
    Car CreateVolvo();
    Car CreateMan();
    Car CreateScania();
}

public interface ITankFactory
{
    Car CreateAbrams();
    Car CreateMerkava();
    Car CreateTiger();
}

public class VehicleFactory : IVehicleFactory
{
    public Car CreateAudi() => new Audi();
    public Car CreateHonda() => new Honda();
    public Car CreateTesla() => new Tesla();
}

public class CargoFactory : ICargoFactory
{
    public Car CreateVolvo() => new Volvo();
    public Car CreateMan() => new Man();
    public Car CreateScania() => new Scania();
}

public class TankFactory : ITankFactory
{
    public Car CreateAbrams() => new Abrams();
    public Car CreateMerkava() => new Merkava();
    public Car CreateTiger() => new Tiger();
}


