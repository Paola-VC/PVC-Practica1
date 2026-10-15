namespace PVC.Temperatura;

// Clase encargada de convertir temperaturas.
public class ConvertidorTemperatura
{
    // Convierte grados Celsius a Fahrenheit.
    public double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32;
    }

    // Convierte grados Fahrenheit a Celsius.
    public double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5.0 / 9.0;
    }
}
