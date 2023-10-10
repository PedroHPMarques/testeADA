using System;

class Exercicio1
{
    public static void Executar()
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

class Exercicio2
{
    public static void Executar()
    {
        Console.Write("Digite o primeiro número (N1): ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número (N2): ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int multiplicacao = 0;
        int divisao = 0;

        if (numero2 != 0)
        {
            // Calcula a multiplicação
            if (numero2 > 0)
            {
                for (int i = 0; i < numero2; i++)
                {
                    multiplicacao += numero1;
                }
            }
            else
            {
                for (int i = 0; i > numero2; i--)
                {
                    multiplicacao -= numero1;
                }
            }

            // Calcula a divisão
            int n1Abs = Math.Abs(numero1);
            int n2Abs = Math.Abs(numero2);

            while (n1Abs >= n2Abs)
            {
                n1Abs -= n2Abs;
                divisao++;
            }

            // Define o sinal do resultado da divisão
            if ((numero1 < 0 && numero2 > 0) || (numero1 > 0 && numero2 < 0))
            {
                divisao = -divisao;
            }
        }

        Console.WriteLine($"Multiplicação: {multiplicacao}");
        Console.WriteLine($"Divisão Inteira: {divisao}");
    }
    }

    

class Exercicio3
{
    public static void Executar()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        
        string[] palavras = frase.Split(' ');

        int palavrasMaiusculas = 0;
        int palavrasMinusculas = 0;
        int palavrasIniciamMaiuscula = 0;
        int palavrasIniciamMinuscula = 0;

        foreach (string palavra in palavras)
        {
            if (!string.IsNullOrEmpty(palavra))
            {
                if (char.IsUpper(palavra[0]))
                {
                    palavrasIniciamMaiuscula++;

                    if (palavra.Length > 1 && char.IsUpper(palavra[1]))
                    {
                        palavrasMaiusculas++;
                    }
                }
                else
                {
                    palavrasIniciamMinuscula++;

                    if (palavra.Length > 1 && char.IsLower(palavra[1]))
                    {
                        palavrasMinusculas++;
                    }
                }
            }
        }

        int totalPalavras = palavras.Length;

        Console.WriteLine($"Palavras maiúsculas: {palavrasMaiusculas}");
        Console.WriteLine($"Palavras minúsculas: {palavrasMinusculas}");
        Console.WriteLine($"Palavras iniciam com letra maiúscula: {palavrasIniciamMaiuscula}");
        Console.WriteLine($"Palavras iniciam com letra minúscula: {palavrasIniciamMinuscula}");
        Console.WriteLine($"Quantidade total de palavras: {totalPalavras}");
    }
}

class Exercicio4
{
    public static void Executar()
    {
        Int32 numero;
        numero = Convert.ToInt16(!(21 > 21));
        Console.WriteLine(numero);
    }
    
    /*
    Resposta: Letra C
    Neste exercício o console ira retornar o valor '1' pois 21 não é maior que 21, logo a 
    operação é do tipo False, como possui uma '!' ela se torna True.
    Com isso a variável numero tentará converter o valor booleano true
    para um número inteiro de 16 bits, o que resulta em 1.  
    
     */
 
    
}

class Exercicio5
{
    public static void Executar()
    {
        for (int i = -5; i <= 7; i += 3)
        {
            Console.WriteLine(i);
        }
        
        /*
         Resposta: Letra E
         
        O código contém um loop for que inicia a variável i com o valor -5, 
        continua enquanto i for menor ou igual a 7 e a cada iteração incrementa i em 3
        
        na primeira iteração o console imprime -5
        depois -5+3 = -2, então o console imprime -2
        depois -2+3 = 1, entao o console imprime 1
        depois 1+3 = 4, então o console imprime 4
        depois 4+3 = 7, então o console imprime 7
        por fim 7 +3 = 10, porém 10 é maior que 7 e encerra-se o loop
        
        */

}
}

class Program
{
static void Main()
{
Console.WriteLine("Escolha o exercício a ser executado (1-5):");
int escolha = Convert.ToInt32(Console.ReadLine());

switch (escolha)
{
    case 1:
        Exercicio1.Executar();
        break;
    case 2:
        Exercicio2.Executar();
        break;
    case 3:
        Exercicio3.Executar();
        break;
    case 4:
        Exercicio4.Executar();
        break;
    case 5:
        Exercicio5.Executar();
        break;
    default:
        Console.WriteLine("Escolha inválida.");
        break;
}
}
}