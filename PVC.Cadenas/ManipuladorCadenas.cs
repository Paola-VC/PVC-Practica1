namespace PVC.Cadenas;

// Clase que contiene operaciones básicas con cadenas.
public class ManipuladorCadenas
{
    // Invierte el orden de los caracteres.
    public string Invertir(string texto)
    {
        ArgumentNullException.ThrowIfNull(texto);
        return new string(texto.Reverse().ToArray());
    }

    // Cuenta la cantidad de caracteres.
    public int ContarCaracteres(string texto)
    {
        ArgumentNullException.ThrowIfNull(texto);
        return texto.Length;
    }

    // Convierte una cadena a mayúsculas.
    public string ConvertirMayusculas(string texto)
    {
        ArgumentNullException.ThrowIfNull(texto);
        return texto.ToUpperInvariant();
    }

    // Comprueba si una palabra es palíndroma,
    // ignorando diferencias entre mayúsculas y minúsculas.
    public bool EsPalindromo(string texto)
    {
        ArgumentNullException.ThrowIfNull(texto);

        string normalizado = texto.ToLowerInvariant();
        string invertido = new string(normalizado.Reverse().ToArray());

        return normalizado == invertido;
    }
}
