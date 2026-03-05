
using System.Collections.Specialized;
using System.Text;

Console.WriteLine("Bem-vindo à Calculadora Console!");

Boolean continuar = true;
double num1 = 0, num2 = 0;

while (continuar == true)
{
    Boolean confirmacao = true;
    Boolean confirmacao2 = true;
    Boolean voltarTabuada = false;

    Console.WriteLine("Escolha a operação: +, -, *, /, Tabuada");
    string operacao = Console.ReadLine();

    if (String.Equals(operacao, "Tabuada", StringComparison.OrdinalIgnoreCase))
    {

        double numeroTabuada = 0;

        try
        {
            Console.WriteLine("Digite o número para a tabuada:");
            numeroTabuada = Convert.ToDouble(Console.ReadLine());

        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite um número válido.");
            continue;
        }

        Console.WriteLine($"Tabuada do {numeroTabuada}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");
        }

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
                    voltarTabuada = true;
                }
                else
                {
                    Console.WriteLine("Resposta inválida. Por favor, digite 's' para sim ou 'n' para não.");
                }
            }

        }

    }
    else
        if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
        {
            Console.WriteLine("Operação inválida. Tente novamente.");
            continue;
        }

    if (voltarTabuada == true)
    {
        continue;
    }

    if (continuar == false)
    {
        break;
    }

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
