using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{
    public enum DaysOfWeek
    {
        Sun, Mon, Tues, Wed, Thurs, Fri, Sat
    }

    class Program
    {
        private static void Main(string[] args)
        {
            List<Weather> daysForcasted = new List<Weather>();

            daysForcasted.Add(new Weather(DaysOfWeek.Tues, high: 34, low: 27));
            daysForcasted.Add(new Weather(DaysOfWeek.Wed, high: 35, low: 29));
            daysForcasted.Add(new Weather(DaysOfWeek.Thurs, high: 36, low: 26));
            daysForcasted.Add(new Weather(DaysOfWeek.Fri, high: 38, low: 28));
            daysForcasted.Add(new Weather(DaysOfWeek.Sat, high: 41, low: 33));

            var coldDays = from forecast in daysForcasted where forecast.HighTemp < 40 select forecast;

            foreach (var coldDay in coldDays)
            {
                Console.WriteLine("Cold weather on {0}", coldDay.Day);
            }
        }
        

    }

    class Weather
    {

        public DaysOfWeek Day;
        public int HighTemp;
        public int LowTemp;

        public Weather(DaysOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
        
    }
}
