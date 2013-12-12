using System;
using Weather;
using Xunit;

namespace WeatherTest
{
    public class WeatherDataTest
    {
        [Fact]
        public void should_update_panel_of_current_condition()
        {
            var currentConditionsDisplay = new CurrentConditionsDisplay();
            var currentTime = new DateTime();
            var weatherData = new WeatherData(currentConditionsDisplay, new StatisticsDisplay(), new ForecastDisplay());
            weatherData.MeasurementsChanged(currentTime);
            
            Assert.Equal(currentTime, currentConditionsDisplay.UpdatedTime);
        }
        
        [Fact]
        public void should_update_panel_of_forecast()
        {
            var currentTime = new DateTime();
            var forecastDisplay = new ForecastDisplay();
            var weatherData = new WeatherData(new CurrentConditionsDisplay(), new StatisticsDisplay(), forecastDisplay);
            weatherData.MeasurementsChanged(currentTime);

            Assert.Equal(currentTime, forecastDisplay.UpdatedTime);
        }
        
        [Fact]
        public void should_update_panel_of_statistics()
        {
            var currentTime = new DateTime();
            var statisticsDisplay = new StatisticsDisplay();
            var weatherData = new WeatherData(new CurrentConditionsDisplay(), statisticsDisplay, new ForecastDisplay());
            weatherData.MeasurementsChanged(currentTime);

            Assert.Equal(currentTime, statisticsDisplay.UpdatedTime);
        }
    }
}
