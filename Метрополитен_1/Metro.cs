using System;
using System.Collections.Generic;
using System.Text;

namespace Metro
{
    class Metro
    {
        List<Line> lines;
        string city;
        public Metro(string city)
        {
            this.city = city;
            lines = new List<Line>();
        }
        public string GetCity()
        {
            return city;
        }
        public void AddLine(string name, string color)
        {
            Line line = new Line(name, color);
            lines.Add(line);
        }
        public void RemoveLine(string name)
        {
            foreach (Line i in lines)
            {
                if (i.GetName() == name)
                {
                    lines.Remove(i);
                }
            }
        }
    }
}
