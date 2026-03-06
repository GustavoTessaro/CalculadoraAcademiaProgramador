# Calculadora Console em C#

## DescriÃ§Ã£o
Este projeto implementa uma calculadora simples em console desenvolvida em C#. A aplicaÃ§Ã£o permite aos usuÃ¡rios realizar operaÃ§Ãµes aritmÃ©ticas bÃ¡sicas (adiÃ§Ã£o, subtraÃ§Ã£o, multiplicaÃ§Ã£o, divisÃ£o) e tambÃ©m calcular a tabuada de um nÃºmero especÃ­fico. AlÃ©m disso, a calculadora mantÃ©m um histÃ³rico de todas as operaÃ§Ãµes realizadas, que pode ser consultado a qualquer momento.

## Funcionalidades
*   **OperaÃ§Ãµes AritmÃ©ticas BÃ¡sicas**: Suporta adiÃ§Ã£o (`+`), subtraÃ§Ã£o (`-`), multiplicaÃ§Ã£o (`*`) e divisÃ£o (`/`).
*   **CÃ¡lculo de Tabuada**: Permite ao usuÃ¡rio inserir um nÃºmero e visualizar sua tabuada de 1 a 10.
*   **HistÃ³rico de OperaÃ§Ãµes**: Armazena e exibe todas as operaÃ§Ãµes realizadas durante a sessÃ£o da calculadora.
*   **Tratamento de Erros**: Inclui validaÃ§Ã£o de entrada para garantir que apenas nÃºmeros vÃ¡lidos sejam processados e impede divisÃ£o por zero.
*   **Interface AmigÃ¡vel**: Interage com o usuÃ¡rio atravÃ©s de prompts claros no console.

## Como Executar
Para executar esta aplicaÃ§Ã£o, vocÃª precisarÃ¡ ter o .NET SDK instalado em sua mÃ¡quina.

1.  **Salve o cÃ³digo**: Salve o cÃ³digo fornecido em um arquivo com extensÃ£o `.cs` (por exemplo, `Calculadora.cs`).
2.  **Abra o Terminal/Prompt de Comando**: Navegue atÃ© o diretÃ³rio onde vocÃª salvou o arquivo `Calculadora.cs`.
3.  **Compile o cÃ³digo**: Execute o seguinte comando para compilar o projeto:
    ```bash
    dotnet build
    ```
4.  **Execute a aplicaÃ§Ã£o**: ApÃ³s a compilaÃ§Ã£o bem-sucedida, execute a aplicaÃ§Ã£o com o comando:
    ```bash
    dotnet run
    ```

## Tecnologias Utilizadas
*   **C#**: Linguagem de programaÃ§Ã£o.
*   **.NET SDK**: Ambiente de desenvolvimento para compilar e executar aplicaÃ§Ãµes C#.

## Exemplo de Uso
```
Bem-vindo Ã  Calculadora Console!
Escolha a operaÃ§Ã£o: +, -, *, /, Tabuada, Digite 1 para HistÃ³rico de OperaÃ§Ãµes
+
Digite o primeiro nÃºmero:
10
Digite o segundo nÃºmero:
5
Resultado: 15
Deseja realizar outra operaÃ§Ã£o? (s/n)
s
Escolha a operaÃ§Ã£o: +, -, *, /, Tabuada, Digite 1 para HistÃ³rico de OperaÃ§Ãµes
Tabuada
Digite o nÃºmero para a tabuada:
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
Deseja realizar outra operaÃ§Ã£o? (s/n)
s
Escolha a operaÃ§Ã£o: +, -, *, /, Tabuada, Digite 1 para HistÃ³rico de OperaÃ§Ãµes
1

HistÃ³rico de OperaÃ§Ãµes:
10 + 5 = 15
Deseja realizar outra operaÃ§Ã£o? (s/n)
n
Obrigado por usar a calculadora. AtÃ© mais!
```