public interface ICryptoService
{
    string Encrypt(string input);
    string Decrypt(string input);
}

public class CryptoService : ICryptoService
{
    private const int Shift = 3; // Enkel Caesar-chiffer med 3 steg

    public string Encrypt(string input)
    {
        return new string(input.Select(c => (char)(c + Shift)).ToArray());
    }

    public string Decrypt(string input)
    {
        return new string(input.Select(c => (char)(c - Shift)).ToArray());
    }
}
