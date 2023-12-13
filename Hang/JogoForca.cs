namespace Hangman_Game.Hang;

public class JogoForca
{
    public string NickNamePlayer { get; set; }
    private string PalavraSecreta { get ; set; }
    private string LetrasCorretas { get; set; }
    private int MaximoTentativas { get; set; }
    private int QuantidadeTentativas { get; set; }
    private int QuantidadeErros { get; set; }

    public JogoForca()
    {
    }

    public JogoForca(string nickNamePlayer)
    {
        NickNamePlayer = nickNamePlayer;
    }

    public JogoForca(string nickNamePlayer, string palavraSecreta, string letrasCorretas, int maximoTentativas, int quantidadeTentativas, int quantidadeErros)
    {
        NickNamePlayer = nickNamePlayer;
        PalavraSecreta = palavraSecreta;
        LetrasCorretas = letrasCorretas;
        MaximoTentativas = maximoTentativas;
        QuantidadeTentativas = quantidadeTentativas;
        QuantidadeErros = quantidadeErros;
    }

    public static void DesenharForca(int erros)
    {
        Console.WriteLine("  +---+");
        Console.WriteLine("  |   |");

        switch (erros)
        {
            case 0:
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            break;
            case 1:
            Console.WriteLine("  O   |");
            Console.WriteLine("      |");
            Console.WriteLine("      |");
            break;
            case 2:
            Console.WriteLine("  O   |");
            Console.WriteLine("  |   |");
            Console.WriteLine("      |");
            break;
            case 3:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|   |");
            Console.WriteLine("      |");
            break;
            case 4:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("      |");
            break;
            case 5:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" /    |");
            break;
            case 6:
            Console.WriteLine("  O   |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine(" / \\  |");
            break;
        }
        Console.WriteLine("      |");
        Console.WriteLine("=========");
    }
}
