namespace Hangman_Game.Hang;

public class InterfaceJogo
{
    public static void IniciarJogo()
    {
        Console.WriteLine("Caro jogador, nos forneça o seu nick para podermos mencioná-lo futuramente.");
        Console.Write("Nickname: ");
        JogoForca nickPlayer = new JogoForca();
        nickPlayer.NickNamePlayer = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Olá {nickPlayer.NickNamePlayer}, deseja ver as instruções do game? ");
        Console.Write("Digite '1' para SIM ou '2' para NÃO: ");
        int instrucoes;
        string instructions = Console.ReadLine();

        while (!int.TryParse(instructions, out instrucoes) || instrucoes != 1 && instrucoes != 2)
        {
            Console.WriteLine();
            Console.WriteLine("Digite o comando correto: ");
            Console.Write("Digite '1' para SIM ou '2' para NÃO: ");
            instructions = Console.ReadLine();

            if (instrucoes == 1)
            {
                break;
            }
        }

        if (instrucoes == 1)
        {
            Console.WriteLine("");
            Console.WriteLine($"{nickPlayer.NickNamePlayer} o game funciona da seguinte maneira: ");
            Console.WriteLine("O jogo só finaliza quando você utilizar todas as suas tentativas, temos o total de 6 tentativas.");
            Console.WriteLine($"Não existe tempo, você pode levar todo o tempo do mundo, boa sorte!");
            Console.WriteLine("");
        }

        Console.WriteLine("Tudo certo então? Vamos prosseguir!");
        Console.Write("Pressione alguma tecla para continuarmos: ");
        Console.ReadKey();
        Console.Clear();
    }

    public static void RealizarJogada()
    {

    }

    public static void ExibirPlavra()
    {

    }
}
