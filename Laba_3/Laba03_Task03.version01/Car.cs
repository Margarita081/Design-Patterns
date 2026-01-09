using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03_Task03.version01
{
    public class Client
    {

        public void Do(string type, string model)
        {
            switch (type)
            {
                case "Vehicle":
                    {
                        var vehicleFactory = new VehicleFactory();
                        Car car1;
                        if (model == "Audi")
                            car1 = vehicleFactory.CreateAudi();
                        else if (model == "Honda")
                            car1 = vehicleFactory.CreateHonda();
                        else if (model == "Tesla")
                            car1 = vehicleFactory.CreateTesla();
                        else
                            throw new Exception("Model not found");

                        Console.WriteLine(car1);
                        break;
                    }

                case "Cargo":
                    {
                        var cargoFactory = new CargoFactory();
                        Car car2;
                        if (model == "Volvo")
                            car2 = cargoFactory.CreateVolvo();
                        else if (model == "Man")
                            car2 = cargoFactory.CreateMan();
                        else if (model == "Scania")
                            car2 = cargoFactory.CreateScania();
                        else
                            throw new Exception("Model not found");

                        Console.WriteLine(car2);
                        break;
                    }

                case "Tank":
                    {
                        var tankFactory = new TankFactory();
                        Car car3;
                        if (model == "Abrams")
                            car3 = tankFactory.CreateAbrams();
                        else if (model == "Merkava")
                            car3 = tankFactory.CreateMerkava();
                        else if (model == "Tiger")
                            car3 = tankFactory.CreateTiger();
                        else
                            throw new Exception("Model not found");

                        Console.WriteLine(car3);
                        break;
                    }

                default:
                    throw new Exception("Type not found");
            }
        }
    }

    public abstract class Car
    {
        public event Action<string, object, object> PropertyChanged;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    string old = _name;
                    _name = value;
                    OnPropertyChanged("Name", old ?? "null", value ?? "null");
                }
            }
        }
        private string _weight;
        public string Weight
        {
            get { return _weight; }
            set
            {
                if (_weight != value)
                {
                    string old = _weight;
                    _weight = value;
                    OnPropertyChanged("Weight", old ?? "null", value ?? "null");
                }
                ;
            }
        }
        private string _length;
        public string Length
        {
            get { return _length; }
            set
            {
                if (_length != value)
                {
                    string old = _length;
                    _length = value;
                    OnPropertyChanged("Length", old ?? "null", value ?? "null");
                }
                ;
            }
        }
        private string _maxSpeed;
        public string MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (_maxSpeed != value)
                {
                    string old = _maxSpeed;
                    _maxSpeed = value;
                    OnPropertyChanged("MaxSpeed", old ?? "null", value ?? "null");
                }
                ;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(propertyName, oldValue, newValue);
            }
        }

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
        private string _wheelDrive;
        public string WheelDrive
        {
            get { return _wheelDrive; }
            set
            {
                if (_wheelDrive != value)
                {
                    string old = _wheelDrive;
                    _wheelDrive = value;
                    OnPropertyChanged("WheelDrive", old ?? "null", value ?? "null");
                }
            }
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set
            {
                if (_color != value)
                {
                    string old = _color;
                    _color = value;
                    OnPropertyChanged("Color", old ?? "null", value ?? "null");
                }
            }
        }

        private TypeVehicle _typeVehicle;
        public TypeVehicle TypeVehicle
        {
            get { return _typeVehicle; }
            set
            {
                if (_typeVehicle != value)
                {
                    TypeVehicle old = _typeVehicle;
                    _typeVehicle = value;
                    OnPropertyChanged("TypeVehicle", old, value);
                }
            }
        }
    }

    public class Tank : Car
    {
        private string _proiectileCaliber;
        public string ProiectileCaliber
        {
            get { return _proiectileCaliber; }
            set
            {
                if (_proiectileCaliber != value)
                {
                    string old = _proiectileCaliber;
                    _proiectileCaliber = value;
                    OnPropertyChanged("ProiectileCaliber", old ?? "null", value ?? "null");
                }
            }
        }

        private string _shotsPerMinute;
        public string ShotsPerMinute
        {
            get { return _shotsPerMinute; }
            set
            {
                if (_shotsPerMinute != value)
                {
                    string old = _shotsPerMinute;
                    _shotsPerMinute = value;
                    OnPropertyChanged("ShotsPerMinute", old ?? "null", value ?? "null");
                }
            }
        }

        private string _crewSize;
        public string CrewSize
        {
            get { return _crewSize; }
            set
            {
                if (_crewSize != value)
                {
                    string old = _crewSize;
                    _crewSize = value;
                    OnPropertyChanged("CrewSize", old ?? "null", value ?? "null");
                }
            }
        }
    }

    public class Cargo : Car
    {
        private string _tonnage;
        public string Tonnage
        {
            get { return _tonnage; }
            set
            {
                if (_tonnage != value)
                {
                    string old = _tonnage;
                    _tonnage = value;
                    OnPropertyChanged("Tonnage", old ?? "null", value ?? "null");
                }
            }
        }

        private string _tankVolume;
        public string TankVolume
        {
            get { return _tankVolume; }
            set
            {
                if (_tankVolume != value)
                {
                    string old = _tankVolume;
                    _tankVolume = value;
                    OnPropertyChanged("TankVolume", old ?? "null", value ?? "null");
                }
            }
        }

        private string _axlesAmount;
        public string AxlesAmount
        {
            get { return _axlesAmount; }
            set
            {
                if (_axlesAmount != value)
                {
                    string old = _axlesAmount;
                    _axlesAmount = value;
                    OnPropertyChanged("AxlesAmount", old ?? "null", value ?? "null");
                }
            }
        }
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
}
