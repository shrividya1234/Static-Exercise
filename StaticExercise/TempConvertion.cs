namespace StaticExercise;

public class TempConvertion
{
    public static double FahrenheitToCelsius(double Fahrenheit)
    {
        var result = (Fahrenheit - 32) / 1.8;
        return result;
    }

    public static double CelsiusToFahrenheit(double Celsius)
    {
        var result1 = (Celsius * 9) / 5 + 32;
        return result1;
    }
}