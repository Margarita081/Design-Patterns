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

public static class CreateCar
{
    public abstract class Car
    {
        public string Weight { get; set; }
        public string Length { get; set; }
        public string MaxSpeed { get; set; }

        public abstract object CloneCar();
    }

    public enum TypeVehicle
    {
        Hatchback,
        Sedan,
        Coupe
    }
    public class Vehichle : Car
    {
        public string WheelDrive { get; set; }
        public string Color { get; set; }

        public TypeVehicle TypeVehicle { get; set; }

        public override object CloneCar()
        {
            return new Vehichle
            {
                WheelDrive = this.WheelDrive,
                Color = this.Color,
                TypeVehicle = this.TypeVehicle,
                Weight = this.Weight,
                Length = this.Length,
                MaxSpeed = this.MaxSpeed,
            };
        }

    }

    public class Cargo : Car
    {
        public string Tonnage { get; set; }
        public string TankVolume { get; set; }
        public string AxlesAmount { get; set; }
        public override object CloneCar()
        {
            return new Cargo
            {
                Tonnage = this.Tonnage,
                TankVolume = this.TankVolume,
                AxlesAmount = this.AxlesAmount,
                Weight = this.Weight,
                Length = this.Length,
                MaxSpeed = this.MaxSpeed,
            };
        }
    }

    public abstract class Tank : Car
    {
        public string ProiectileCaliber { get; set; }
        public string ShotsPerMinute { get; set; }
        public string CrewSize { get; set; }

    }



    public class Audi : Vehichle
    {
        public Audi()
        {
            WheelDrive = "";
            Color = "";
            TypeVehicle = TypeVehicle.Sedan;
            Weight = "";
            Length = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Audi)base.CloneCar();
            return clone;
        }
    }

    public class Honda : Vehichle
    {
        public Honda()
        {
            WheelDrive = "";
            Color = "";
            TypeVehicle = TypeVehicle.Hatchback;
            Weight = "";
            Length = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Honda)base.CloneCar();
            return clone;
        }
    }

    public class Tesla : Vehichle
    {
        public Tesla()
        {
            WheelDrive = "";
            Color = "";
            TypeVehicle = TypeVehicle.Coupe;
            Weight = "";
            Length = "";
            MaxSpeed = "";

        }
        public override object CloneCar()
        {
            var clone = (Tesla)base.CloneCar();
            return clone;
        }
    }

    public class Volvo : Cargo
    {
        public Volvo()
        {
            Tonnage = "";
            TankVolume = "";
            AxlesAmount = "";
            Weight = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Volvo)base.CloneCar();
            return clone;
        }
    }

    public class Man : Cargo
    {
        public Man()
        {
            Tonnage = "";
            TankVolume = "";
            AxlesAmount = "";
            Weight = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Man)base.CloneCar();
            return clone;
        }
    }

    public class Scania : Cargo
    {
        public Scania()
        {
            Tonnage = "";
            TankVolume = "";
            AxlesAmount = "";
            Weight = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Scania)base.CloneCar();
            return clone;
        }
    }

    public class Abrams : Tank
    {
        public Abrams()
        {
            ProiectileCaliber = "";
            ShotsPerMinute = "";
            CrewSize = "";
            Weight = "";
            Length = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Abrams)CloneCar();
            return clone;
        }
    }
    public class Merkava : Tank
    {
        public Merkava()
        {
            ProiectileCaliber = "11";
            ShotsPerMinute = "23";
            CrewSize = "344";
            Weight = "422";
            Length = "31";
            MaxSpeed = "65";
        }
        public override object CloneCar()
        {
            var clone = (Merkava)CloneCar();
            return clone;
        }
    }

    public class Tiger : Tank
    {
        public Tiger()
        {
            ProiectileCaliber = "";
            ShotsPerMinute = "";
            CrewSize = "";
            Weight = "";
            Length = "";
            MaxSpeed = "";
        }
        public override object CloneCar()
        {
            var clone = (Tiger)CloneCar();
            return clone;
        }
    }
}

