using System;
using System.Collections.Generic;
using System.Text;

namespace Metro1
{
    public class Station
    {
        string name;
        string color;
        Line line;
        bool isWheelchairAccesible;
        bool hasParkAndRide;
        bool hasNearbyCableCar;
        List<Station> transfers;
        public Station(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public bool IsWheelchairAccesible()
        {
            return isWheelchairAccesible;
        }
        public bool HasParkAndRide()
        {
            return hasParkAndRide;
        }
        public bool HasNearbeCableCar()
        {
            return hasNearbyCableCar;
        }
        public string GetLineName()
        {
            return line.GetName();
        }
    }
}
