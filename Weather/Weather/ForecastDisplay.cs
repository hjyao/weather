using System;

namespace Weather
{
    public class ForecastDisplay
    {
        public DateTime UpdatedTime { get; set; }
        public void Update(double temp, double humidity, double pressure, DateTime updatedTime)
        {
            UpdatedTime = updatedTime;
            Console.WriteLine("show forecast");
        }
    }
}