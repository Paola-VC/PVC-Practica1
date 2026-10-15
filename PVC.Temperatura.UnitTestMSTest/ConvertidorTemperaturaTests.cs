using Microsoft.VisualStudio.TestTools.UnitTesting;
using PVC.Temperatura;

namespace PVC.Temperatura.UnitTestMSTest;

[TestClass]
public class ConvertidorTemperaturaTests
{
    private readonly ConvertidorTemperatura _convertidor = new();

    // Verifica la conversión del punto de congelación.
    [TestMethod]
    public void CelsiusAFahrenheit_Cero_Retorna32()
    {
        Assert.AreEqual(32.0, _convertidor.CelsiusAFahrenheit(0), 0.001);
    }

    // Verifica la conversión del punto de ebullición.
    [TestMethod]
    public void CelsiusAFahrenheit_Cien_Retorna212()
    {
        Assert.AreEqual(212.0, _convertidor.CelsiusAFahrenheit(100), 0.001);
    }

    // Verifica una temperatura negativa.
    [TestMethod]
    public void CelsiusAFahrenheit_Menos40_RetornaMenos40()
    {
        Assert.AreEqual(-40.0, _convertidor.CelsiusAFahrenheit(-40), 0.001);
    }

    // Verifica la conversión de Fahrenheit a Celsius.
    [TestMethod]
    public void FahrenheitACelsius_32_RetornaCero()
    {
        Assert.AreEqual(0.0, _convertidor.FahrenheitACelsius(32), 0.001);
    }

    // Verifica el punto de ebullición en Celsius.
    [TestMethod]
    public void FahrenheitACelsius_212_Retorna100()
    {
        Assert.AreEqual(100.0, _convertidor.FahrenheitACelsius(212), 0.001);
    }
}
