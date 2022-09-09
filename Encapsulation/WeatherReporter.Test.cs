using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace Encapsulation.Models.Tests
{
    public class WeatherReporterTest
    {
        private WeatherReporter? WeatherReporter1;
        private WeatherReporter? WeatherReporter2;
        private WeatherReporter? WeatherReporter3;
        private WeatherReporter? WeatherReporter4;

        [SetUp]
        public void Setup()
        {
            WeatherReporter1 = new WeatherReporter("London", 20);
            WeatherReporter2 = new WeatherReporter("California", 31);
            WeatherReporter3 = new WeatherReporter("Cape Town", 9);
            WeatherReporter4 = new WeatherReporter("Antartica", -30);
        }

        [Test]
        public void WeatherReporter_Should_Return_Correct_String_Response()
        {
            WeatherReporter1?.Print().Should().Be("I am in London and it is 🌦. Ahhh...it's just right 😊!. The temperature in Fahrenheit is 68.");
            WeatherReporter2?.Print().Should().Be("I am in California and it is 🌅. It's too hot 🥵!. The temperature in Fahrenheit is 87.8.");
            WeatherReporter3?.Print().Should().Be("I am in Cape Town and it is 🌤. It's too cold 🥶!. The temperature in Fahrenheit is 48.2.");
            WeatherReporter4?.Print().Should().Be("I am in Antartica and it is 🔆. It's too cold 🥶!. The temperature in Fahrenheit is -22.");
        }
    }
}
