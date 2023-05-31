using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public static double FarenheitToCelsius(double farenheit)
        {
            return (farenheit - 32) / 1.8;
          
        }



        public static double CelsiusToFarenheit(double Celcius)
        {
            return (Celcius * 9) / 5 + 32;
            
        }
    }
}


