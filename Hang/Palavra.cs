namespace Hangman_Game.Hang;

public class Palavra
{
    public string[] PalavraTema { get; set; } = { "Futebol", "Hospital", "Escola", "Oceano"};
    public string[] PalavraSecreta { get; set; } = { "GANDULA", "CIRURGIAO", "COORDENAÇAO", "TARTARUGA"};

    public Palavra()
    {
        
    }

    public Palavra(string[] palavraTema)
    {
        PalavraTema = palavraTema;
    }

    public int GerarIndiceAleatorio(string[] palavras)
    {
        PalavraTema = palavras;
        Random random = new Random();
        int indiceAleatorio = random.Next(0, palavras.Length);
        PalavraTema = new string[] { palavras[indiceAleatorio] };
        return indiceAleatorio;
    }


    public static void StartGame(JogoForca nickNamePlayer)
    {
        Console.WriteLine($"{nickNamePlayer.NickNamePlayer}, um tema será sorteado para o jogo iniciar.");
        string[] palavras = { "Futebol", "Hospital", "Escola", "Oceano" };
        Palavra palavraTema = new Palavra(palavras);

        int indiceSorteado = palavraTema.GerarIndiceAleatorio(palavras);
        Console.WriteLine($"O tema sorteado é {indiceSorteado}");

        //for (int i = 0; i < palavraTema.PalavraTema.Length; i++)
        //{
        //    Console.WriteLine(palavraTema.PalavraTema[i]);
        //}
    }
}
