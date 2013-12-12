using System;

namespace Weather
{
    public class StatisticsDisplay
    {
        public DateTime UpdatedTime { get; set; }
        public void Update(double temp, double humidity, double pressure, DateTime updatedTime)
        {
            UpdatedTime = updatedTime;
            Console.WriteLine("show statistics");
        }
    }
}