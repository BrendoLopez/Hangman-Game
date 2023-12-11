namespace Hangman_Game.Hang;

public class Palavra
{
    public string PalavraSecreta { get; private set; }

    public Palavra(string[] palavras)
    {
        Random random = new Random();
        int indiceAleatorio = random.Next(0, palavras.Length);
        PalavraSecreta = palavras[indiceAleatorio];
    }
}
