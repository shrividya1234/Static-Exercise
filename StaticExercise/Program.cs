namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celciusConvertion = TempConvertion.CelsiusToFahrenheit(20);
            var farhenConvertion = TempConvertion.FahrenheitToCelsius(68);
            Console.WriteLine("AFTER CONVERTION");
            Console.WriteLine($"Celcius convertion: {celciusConvertion}");
            Console.WriteLine($"Fahrenheit convertion: {farhenConvertion}");
            
        }
    }
}
