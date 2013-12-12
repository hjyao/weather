using System;

namespace Weather
{
    public class WeatherData
    {
        private readonly CurrentConditionsDisplay currentConditionsDisplay;
        private readonly StatisticsDisplay statisticsDisplay;
        private readonly ForecastDisplay forecastDisplay;

        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Temperature { get; set; }

        public WeatherData(CurrentConditionsDisplay currentConditionsDisplay, StatisticsDisplay statisticsDisplay, ForecastDisplay forecastDisplay)
        {
            this.currentConditionsDisplay = currentConditionsDisplay;
            this.statisticsDisplay = statisticsDisplay;
            this.forecastDisplay = forecastDisplay;
        }

        public void MeasurementsChanged(DateTime currentTime)
        {
            var temp = Temperature;
            var humidity = Humidity;
            var pressure = Pressure;
            var updatedTime = currentTime;

            currentConditionsDisplay.Update(temp, humidity, pressure, updatedTime);
            statisticsDisplay.Update(temp, humidity, pressure, updatedTime);
            forecastDisplay.Update(temp, humidity, pressure, updatedTime);
        }
    }
}
