namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 1)
                    {
                Console.Write("Is your temp Fahrenheit (F) or Celsius(C)? ");
                var user = Console.ReadLine();


                //if user wants F to C
                if (user.ToUpper() == "F")
                {
                    Console.Write("Enter the Temp in Fahrenheit to conver into Celsius: ");
                    double Temp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"your conversion to celsius is {TempConverter.FahrenheitToCelsius(Temp)}");
                    //Console.WriteLine(TempConverter.FarenheitToCelsius(Temp));
                    //close the while loop
                    i++;
                }


                //If user wants C to F

                else if (user.ToUpper() == "C")
                {
                    Console.Write("Enter the Temp in Celsius to convert into Fahrenheit: ");
                    double Temp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"your conversion to Fahrenheit is {TempConverter.CelsiusToFahrenheit(Temp)}");
                    //Console.WriteLine(TempConverter.CelsiusToFarenheit(Temp));
                    //Close the while loop 
                    i++;
                }


                //if user did not enter c or f

                else
                {
                    Console.WriteLine($"{user} is not a valid conversion type. ");
                }
                
            }
            }
    }
}
