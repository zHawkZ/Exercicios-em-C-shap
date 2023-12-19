using System;
using System.Collections.Generic;


namespace FirstProject.Entities
{
    internal class HourContract
    {
        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public DateTime Data { get; set; }

        public HourContract() { }

        public HourContract(double valuePerHour, int hours, DateTime data) { 
            ValuePerHour = valuePerHour;
            Hours = hours;
            Data = data;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
