﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metro
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
        public Station(string name, string color, List<Station> transfers)
        {
            this.name = name;
            this.color = color;
            this.transfers.AddRange(transfers);
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
        public List<Station> GetTransfersList()
        {
            return transfers; 
        }
    }
}
