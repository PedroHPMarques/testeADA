namespace ConsoleApp1;

public class Questao1
{
    static void questao1()
    {
        int[] numeros = new int[5];
        int pares = 0;
        int impares = 0;
        int positivos = 0;
        int negativos = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (numeros[i] % 2 == 0)
                pares++;
            else
                impares++;

            if (numeros[i] > 0)
                positivos++;
            else if (numeros[i] < 0)
                negativos++;
        }

        Console.WriteLine($"Números pares: {pares}");
        Console.WriteLine($"Números ímpares: {impares}");
        Console.WriteLine($"Números positivos: {positivos}");
        Console.WriteLine($"Números negativos: {negativos}");
    }
}