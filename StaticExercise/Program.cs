namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 1)
                    {
                Console.WriteLine("Is your temp Farenheite (F) or Celcius(C)? ");
                var user = Console.ReadLine();


                //if user wants F to C
                if (user.ToUpper() == "F")
                {
                    Console.Write("Enter the Temp in Farenheit to conver into Celcius: ");
                    double Temp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"your conversion to celcius is {TempConverter.FarenheitToCelsius(Temp)}");
                    Console.WriteLine(TempConverter.FarenheitToCelsius(Temp));
                    //close the while loop
                    i++;
                }


                //If user wants C to F

                else if (user.ToUpper() == "C")
                {
                    Console.Write("Enter the Temp in Celcius to convert into Farenheit: ");
                    double Temp = double.Parse(Console.ReadLine());
                    Console.WriteLine($"your conversion to Farenheite is {TempConverter.CelsiusToFarenheit(Temp)}");
                    Console.WriteLine(TempConverter.CelsiusToFarenheit(Temp));
                    //Close the while loop 
                    i++;
                }


                //if user did not enter c or f

                else
                {
                    Console.WriteLine("You did not enter a valid conversion type. ");
                }
                Console.ReadLine();
            }
            }
    }
}
