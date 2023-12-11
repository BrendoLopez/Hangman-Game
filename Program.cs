using Hangman_Game.Hang;

class Program
{
    static void Main()
    {
        int erros = 6;

        for (int i = 0; i <= erros; i++)
        {
            DesenhoForca.DesenharForca(int.Parse(Console.ReadLine()));
        }
    }
}