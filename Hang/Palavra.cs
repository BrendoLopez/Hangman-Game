﻿namespace Hangman_Game.Hang;

public class Palavra
{
    public string[] PalavraTema { get; set; } = { "Futebol", "Hospital", "Escola", "Oceano" };
    public string[] PalavraSecreta { get; set; } = { "GANDULA", "CIRURGIAO", "COORDENAÇAO", "TARTARUGA" };

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
        Console.WriteLine($"{nickNamePlayer.NickNamePlayer}, um tema será sorteado para o jogo iniciar...");
        string[] palavras = { "Futebol", "Hospital", "Escola", "Oceano" };
        Palavra palavraTema = new Palavra(palavras);
        Palavra palavraSecreta = new Palavra();

        int indiceSorteado = palavraTema.GerarIndiceAleatorio(palavras);
        //Console.WriteLine($"O tema sorteado é {indiceSorteado}");

        for (int i = 0; i < palavraTema.PalavraTema.Length; i++)
        {
            if (indiceSorteado == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"O tema sorteado foi: >> {palavraTema.PalavraTema[i]} <<");
            }
            else if (indiceSorteado == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"O tema sorteado foi: >> {palavraTema.PalavraTema[i]} <<");
            }
            else if (indiceSorteado == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"O tema sorteado foi: >> {palavraTema.PalavraTema[i]} <<");
            }
            else if (indiceSorteado == 3)
            {
                Console.WriteLine();
                Console.WriteLine($"O tema sorteado foi: >> {palavraTema.PalavraTema[i]} <<");
            }
        }

        JogoForca tentativas = new JogoForca();
        tentativas.QuantidadeTentativas = 0;
        tentativas.MaximoTentativas = 6;

        Console.WriteLine();
        Console.WriteLine("1ª tentativa: Pense em uma única letra que contenha na palavra relacionada ao tema sorteado!");
        Console.WriteLine("_ _ _ _ _ _ _ _ _");
        string letraTentativaUsuario = Console.ReadLine();
        int posicaoArrayPalavraSecreta = 0;

        for (int i = 0; i <= indiceSorteado; i++)
        {
            posicaoArrayPalavraSecreta = i;
        }
        Console.WriteLine(posicaoArrayPalavraSecreta);

        for (int i = tentativas.QuantidadeTentativas; i <= tentativas.QuantidadeErros; i++)
        {
            if (letraTentativaUsuario == palavraSecreta.PalavraSecreta[i])
            {
                Console.WriteLine(palavraSecreta.PalavraSecreta[i]);
            }
        }

        //Mostrar a palavra inteira.
        //if (indiceSorteado == 0)
        //{
        //    Console.WriteLine($"{palavraSecreta.PalavraSecreta[0]}");
        //}
        //else if (indiceSorteado == 1)
        //{
        //    Console.WriteLine($"{palavraSecreta.PalavraSecreta[1]}");
        //}
        //else if (indiceSorteado == 2)
        //{
        //    Console.WriteLine($"{palavraSecreta.PalavraSecreta[2]}");
        //}
        //else if (indiceSorteado == 3)
        //{
        //    Console.WriteLine($"{palavraSecreta.PalavraSecreta[3]}");
        //}
    }
}
