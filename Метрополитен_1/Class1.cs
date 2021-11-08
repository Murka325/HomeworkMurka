﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro1
{
    public class Line
    {
        List<Station> stations;
        string name;
        string color;

        public Line(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public string GetStation(string station)
        {
            return station;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void AddStation(string name, string color)
        {
            stations.Add(new Station(name, this.color));
        }
        public void AddStation(string name, string color, List<Station> transfers)
        {
            Station station = new Station(name, color);
            stations.Add(station);
        }
        public Station FindStationByName(string name)
        {
            foreach(Station i in stations)
            {
                if (i.GetName() == name)
                {
                    return i;
                }
            }
            return null;
        }
        public void RemoveStation(string name)
        {
            stations.Remove(FindStationByName(name));
        }
        public List<Station> GetStationList(string name)
        {
            List<Station> help = new List<Station>();
            for (int i = 1; i < stations.Count - 1; i++)
            {
                help.Add(stations[i - 1]);
                help.Add(stations[i + 1]);
            }
            if (stations.IndexOf(FindStationByName(name)) == 0)
            {
                help.Add(stations[1]);
            }
            else if (stations.IndexOf(FindStationByName(name)) == stations.Count - 1)
            {
                help.Add(stations[stations.Count - 2]);
            }
            return help;
        }

    }
}
