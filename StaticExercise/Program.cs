namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68); //20
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68
            
            Console.WriteLine($"Celsius {celcius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
