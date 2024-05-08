
using System;

class Program
{
    static void Main()
    {
        // Quantidade de sorvetes comprados pelo cliente
        int quantidade = 30; // Exemplo: o cliente comprou 30 sorvetes

        // Preço por unidade para até 25 unidades
        double precoPorUnidadeAte25 = 1.50;

        // Preço por unidade para mais de 25 unidades
        double precoPorUnidadeAcima25 = 1.25;

        double valorTotal;

        // Verifica se a quantidade é até 25 unidades
        if (quantidade <= 25)
        {
            valorTotal = quantidade * precoPorUnidadeAte25;
        }
        else
        {
            // Calcula o valor para as primeiras 25 unidades
            double valorPara25 = 25 * precoPorUnidadeAte25;

            // Calcula o valor para as unidades acima de 25
            double valorParaAcima25 = (quantidade - 25) * precoPorUnidadeAcima25;

            // Soma os valores
            valorTotal = valorPara25 + valorParaAcima25;
        }

        Console.WriteLine("O cliente irá pagar R$ " + valorTotal.ToString("0.00"));
    }
}

using System;

class Program
{
    static void Main()
    {
        // Variável com o número escolhido
        int numero = 7; // Exemplo: número escolhido é 7

        // Verifica se o número é maior que 10
        if (numero > 10)
        {
            // Se for maior que 10, realiza o cálculo número + 10 * 2
            int resultado = numero + (10 * 2);
            Console.WriteLine("O resultado do cálculo é: " + resultado);
        }
        else
        {
            // Se não for maior que 10, realiza o cálculo número + 9 * 3 - 8
            int resultado = numero + (9 * 3) - 8;
            Console.WriteLine("O resultado do cálculo é: " + resultado);
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Número escolhido
        int numero = -5; // Exemplo: número escolhido é -5

        // Verifica se o número é positivo, negativo ou zero
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        // Duas variáveis numéricas
        int numero1 = 15; // Exemplo: primeiro número é 15
        int numero2 = 20; // Exemplo: segundo número é 20

        // Verifica qual número é maior
        if (numero1 > numero2)
        {
            Console.WriteLine("O primeiro número (" + numero1 + ") é maior que o segundo número (" + numero2 + ").");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O segundo número (" + numero2 + ") é maior que o primeiro número (" + numero1 + ").");
        }
        else
        {
            Console.WriteLine("Os dois números são iguais.");
        }
    }
}
 
using System;

class Program
{
    static void Main()
    {
        // Notas dos alunos
        double nota1 = 8.5; // Exemplo: primeira nota é 8.5
        double nota2 = 6.0; // Exemplo: segunda nota é 6.0

        // Cálculo da média
        double media = (nota1 + nota2) / 2;

        // Verifica se o aluno foi aprovado ou reprovado
        if (media >= 7.0)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}


