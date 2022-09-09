namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private readonly string _location;
        private readonly double _temperature;
        private double _newTemp;
        private const double FARENHEIT_RATIO = 9.0 / 5.0;
        private const int FARENHEIT_DIFF = 32;
        private const int HOT = 30;
        private const int COLD = 10;
        private const int DECIMAL_PLACES = 2;

        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public string Print()
        {
            _newTemp = Math.Round(FARENHEIT_RATIO * _temperature + FARENHEIT_DIFF, DECIMAL_PLACES);
            return $"I am in {_location} and it is {Check1()}. {Check2()}. The temperature in Fahrenheit is {_newTemp}.";
        }

        public string Check1()
        {
            if (_location == "London") return "🌦";
            else if (_location == "California") return "🌅";
            else if (_location == "Cape Town") return "🌤";
            return "🔆";
        }

        public string Check2()
        {
            if (_temperature > HOT) return "It's too hot 🥵!";
            else if (_temperature < COLD) return "It's too cold 🥶!";
            return "Ahhh...it's just right 😊!";
        }

    }
}

