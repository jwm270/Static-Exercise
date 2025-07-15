namespace StaticExercise
{
    public class Program //Why am I not making this class static? If the class was static, could I just use "WriteLine" without "Console"?
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
