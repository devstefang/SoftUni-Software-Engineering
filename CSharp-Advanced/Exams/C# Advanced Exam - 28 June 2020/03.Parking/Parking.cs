using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Parking
{
    public class Parking
    {
        private List<Car> data;
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }
        public void Add(Car car)
        {
            if (Capacity > this.data.Count)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car car = this.data.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
            if (car != null)
            {
                this.data.Remove(car);
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            int latestCar = this.data.Max(x => x.Year);
            Car car = this.data.Where(x => x.Year == latestCar).FirstOrDefault();
            if (car == null)
            {
                return null;
            }
            return car;
        }
        public Car GetCar(string manufacturer, string model)
        {
            Car car = this.data.Where(x => x.Manufacturer == manufacturer && x.Model == model).FirstOrDefault();
            if (car == null)
            {
                return null;
            }
            return car;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
