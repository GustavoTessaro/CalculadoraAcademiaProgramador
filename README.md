# Calculadora Console em C#

## Descrição
Este projeto implementa uma calculadora simples em console desenvolvida em C#. A aplicação permite aos usuÃ¡rios realizar operações aritiméticas básicas (adição, subtração, multiplicação, divisão) e também calcular a tabuada de um número especÃ­fico. Além disso, a calculadora mantém um histórico de todas as operações realizadas, que pode ser consultado a qualquer momento.

## Funcionalidades
*   **Operações Aritiméticas Básicas**: Suporta adição (`+`), subtração (`-`), multiplicação (`*`) e divisão (`/`).
*   **Cálculo de Tabuada**: Permite ao usuário inserir um nÃºmero e visualizar sua tabuada de 1 a 10.
*   **Histórico de Operações**: Armazena e exibe todas as operaÃ§Ãµes realizadas durante a sessÃ£o da calculadora.
*   **Tratamento de Erros**: Inclui validação de entrada para garantir que apenas números válidos sejam processados e impede divisão por zero.
*   **Interface Amigável**: Interage com o usuário atravÃ©s de prompts claros no console.

## Como Executar
Para executar esta aplicação, você precisará ter o .NET SDK instalado em sua máquina.

1.  **Salve o Código**: Salve o Código fornecido em um arquivo com extensão `.cs` (por exemplo, `Calculadora.cs`).
2.  **Abra o Terminal/Prompt de Comando**: Navegue até o diretório onde você salvou o arquivo `Calculadora.cs`.
3.  **Compile o Código**: Execute o seguinte comando para compilar o projeto:
    ```bash
    dotnet build
    ```
4.  **Execute a aplicação**: Após a compilação bem-sucedida, execute a aplicação com o comando:
    ```bash
    dotnet run
    ```

## Tecnologias Utilizadas
*   **C#**: Linguagem de programação.
*   **.NET SDK**: Ambiente de desenvolvimento para compilar e executar aplicações C#.

## Exemplo de Uso
```
Bem-vindo À  Calculadora Console!
Escolha a operação: +, -, *, /, Tabuada, Digite 1 para Histórico de Operações
+
Digite o primeiro número:
10
Digite o segundo número:
5
Resultado: 15
Deseja realizar outra operação? (s/n)
s
Escolha a operação: +, -, *, /, Tabuada, Digite 1 para Histórico de Operações
Tabuada
Digite o número para a tabuada:
7
Tabuada do 7:
7 x 1 = 7
7 x 2 = 14
7 x 3 = 21
7 x 4 = 28
7 x 5 = 35
7 x 6 = 42
7 x 7 = 49
7 x 8 = 56
7 x 9 = 63
7 x 10 = 70
Deseja realizar outra operação? (s/n)
s
Escolha a operação: +, -, *, /, Tabuada, Digite 1 para Histórico de Operações
1

Histórico de Operações:
10 + 5 = 15
Deseja realizar outra operação? (s/n)
n
Obrigado por usar a calculadora. AtÃ© mais!
```