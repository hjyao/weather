namespace Weather
{
    public class WeatherData
    {
        private readonly CurrentConditionsDisplay currentConditionsDisplay;
        private readonly StatisticsDisplay statisticsDisplay;
        private readonly ForecastDisplay forecastDisplay;

        public WeatherData()
        {
            currentConditionsDisplay = new CurrentConditionsDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }

        public void MeasurementsChanged()
        {
            var temp = GetTemperature();
            var humidity = GetHumidity();
            var pressure = GetPressure();

            currentConditionsDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);

        }

        private double GetPressure()
        {
            return 20.00D;
        }

        private double GetHumidity()
        {
            return 10.00D;
        }

        private double GetTemperature()
        {
            return 5.00D;
        }
    }
}
