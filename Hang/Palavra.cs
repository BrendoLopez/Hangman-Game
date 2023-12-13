namespace Hangman_Game.Hang;

public class Palavra
{
    public string[] PalavraTema { get; set; } = { "Futebol", "Hospital", "Escola", "Oceano"};
    public string[] PalavraSecreta { get; set; } = { "GANDULA", "CIRURGIAO", "COORDENAÇAO", "TARTARUGA"};

    public Palavra(string[] palavras)
    {
        //Random random = new Random();
        //int indiceAleatorio = random.Next(0, palavras.Length);
        //PalavraSecreta = palavras[indiceAleatorio];
    }

    public static void StartGame()
    {
        JogoForca nickPlayer = new JogoForca();
        Console.WriteLine($"{nickPlayer.NickNamePlayer}");
    }
}
