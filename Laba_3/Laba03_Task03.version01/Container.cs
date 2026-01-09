using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba03_Task03.version01
{
    public class Container
    {
        private List<Car> _cars = new List<Car>();

        public void Add(Car car)
        {
            if (car == null) throw new ArgumentNullException("car");

            string className = car.GetType().Name;
            Console.WriteLine("A new instance of the class has been added " + className);
            car.PropertyChanged += OnCarPropertyChanged;
            _cars.Add(car);
        }

        private void OnCarPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            Console.WriteLine($"Property {propertyName} changed from {oldValue} to {newValue}");
        }

        public List<Car> GetCars()
        {
            return new List<Car>(_cars);
        }
    }
}
