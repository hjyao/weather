using System;

namespace Weather
{
    public class CurrentConditionsDisplay
    {
        public DateTime UpdatedTime { get; set; }
        public void Update(double temp, double humidity, double pressure, DateTime updatedTime)
        {
            UpdatedTime = updatedTime;
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humidity", temp, humidity);
        }
    }
}