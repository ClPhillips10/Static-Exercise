using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            var result = (farenheit - 32) / 1.8;
            return result;
        }



        public static double CelsiusToFarenheit(double Celcius)
        {
            var result = (Celcius * 9) / 5 + 32;
            return result;
        }
    }
}


