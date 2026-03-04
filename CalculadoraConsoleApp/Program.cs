
using System.Collections.Specialized;
using System.Text;

Console.WriteLine("Bem-vindo à Calculadora Console!");

Boolean continuar = true;
double num1 = 0, num2 = 0;

while (continuar == true)
{
    Boolean confirmacao = true;

    while (confirmacao == true)
    {
        try
        {
            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToDouble(Console.ReadLine());

            confirmacao = false;
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite números válidos.");
            continue;
        }
    }

    Console.WriteLine("Escolha a operação: +, -, *, /");
    string operacao = Console.ReadLine();

    double resultado = 0;

    switch (operacao)
    {
        case "+":
            resultado = num1 + num2;
            break;
        case "-":
            resultado = num1 - num2;
            break;
        case "*":
            resultado = num1 * num2;
            break;
        case "/":
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                continue;
            }
            break;
        default:
            Console.WriteLine("Operação inválida. Tente novamente.");
            continue;
    }

    Console.WriteLine($"Resultado: {resultado}");

    Boolean confirmacao2 = true;

    while (confirmacao2 == true)
    {
        Console.WriteLine("Deseja realizar outra operação? (s/n)");
        string resposta = Console.ReadLine().ToLower();

        if (String.Equals(resposta, "n", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Obrigado por usar a calculadora. Até mais!");
            continuar = false;
            break;
        }
        else
        {
            if (String.Equals(resposta, "s", StringComparison.OrdinalIgnoreCase))
            {
                confirmacao2 = false;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Por favor, digite 's' para sim ou 'n' para não.");
            }
        }

    }

}
