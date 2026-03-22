using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Task_1_3
{
    public class Ship
    {
        private int ID { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string ShipType { get; set; }

        public Ship() { }

        public void Create(int id, string model, string serialNumber, string shipType)
        {
            ID = id;
            Model = model;
            SerialNumber = serialNumber;
            ShipType = shipType;
        }

        public string PrintObject()
        {
            return $"Ship: ID={ID}, model - {Model}, seria number = {SerialNumber}, type - {ShipType}.";
        }
    }


    public class Manufacturer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        private bool IsAChildCompany { get; set; }

        public void Create(string name, string address, bool isAChildCompany)
        {
            Name = name;
            Address = address;
            IsAChildCompany = isAChildCompany;
        }

        public string PrintObject()
        {
            return $"Name- {Name}, address - {Address}, IsAChildCompany - {IsAChildCompany}";
        }

    }
}
