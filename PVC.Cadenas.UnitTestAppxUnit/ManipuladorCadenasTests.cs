using PVC.Cadenas;
using Xunit;

namespace PVC.Cadenas.UnitTestAppxUnit;

public class ManipuladorCadenasTests
{
    private readonly ManipuladorCadenas _manipulador = new();

    // Comprueba que una palabra se invierte correctamente.
    [Fact]
    public void Invertir_Hola_RetornaAloh()
    {
        Assert.Equal("aloH", _manipulador.Invertir("Hola"));
    }

    // Comprueba que una cadena vacía permanece vacía.
    [Fact]
    public void Invertir_CadenaVacia_RetornaVacia()
    {
        Assert.Equal("", _manipulador.Invertir(""));
    }

    // Comprueba la cantidad de caracteres.
    [Fact]
    public void ContarCaracteres_Hola_RetornaCuatro()
    {
        Assert.Equal(4, _manipulador.ContarCaracteres("Hola"));
    }

    // Comprueba que una cadena vacía tiene cero caracteres.
    [Fact]
    public void ContarCaracteres_CadenaVacia_RetornaCero()
    {
        Assert.Equal(0, _manipulador.ContarCaracteres(""));
    }

    // Comprueba la conversión a mayúsculas.
    [Fact]
    public void ConvertirMayusculas_Hola_RetornaHOLA()
    {
        Assert.Equal("HOLA", _manipulador.ConvertirMayusculas("Hola"));
    }

    // Comprueba una palabra palíndroma.
    [Fact]
    public void EsPalindromo_Reconocer_RetornaVerdadero()
    {
        Assert.True(_manipulador.EsPalindromo("Reconocer"));
    }

    // Comprueba una palabra que no es palíndroma.
    [Fact]
    public void EsPalindromo_Casa_RetornaFalso()
    {
        Assert.False(_manipulador.EsPalindromo("Casa"));
    }

    // Comprueba que los valores nulos generan una excepción.
    [Fact]
    public void Invertir_ValorNulo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentNullException>(
            () => _manipulador.Invertir(null!));
    }
}
