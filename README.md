🧮 Calculadora Console em C#
Uma calculadora interativa desenvolvida em .NET que roda diretamente no terminal. Além das operações básicas, ela oferece funcionalidades de tabuada e histórico.
🚀 Funcionalidades
Operações Básicas: Soma, Subtração, Multiplicação e Divisão.
Gerador de Tabuada: Gera automaticamente a tabuada de 1 a 10 para qualquer número informado.
Histórico de Operações: Armazena e exibe todas as contas feitas durante a sessão atual.
Tratamento de Erros: Validação para evitar que o programa feche caso o usuário digite letras em vez de números ou tente dividir por zero.
🛠️ Tecnologias Utilizadas
C# (Linguagem de programação)
.NET (Plataforma de execução)
Coleções Genéricas (List<T>): Utilizadas para gerenciar o histórico de forma dinâmica.
📖 Como usar
Iniciar: Ao rodar o programa, você verá as opções de operação.
Escolher Operação:
Digite os símbolos (+, -, *, /) para cálculos normais.
Digite Tabuada para gerar a tabela de um número.
Digite 1 para visualizar o histórico de cálculos já realizados.
Entrada de Dados: Siga as instruções no console para inserir os números.
Continuar ou Sair: Após cada operação, o sistema perguntará se você deseja realizar um novo cálculo (s/n).
💻 Estrutura do Código Principal
O código utiliza um laço de repetição while principal para manter a aplicação rodando e estruturas de controle como switch e if/else para direcionar a lógica conforme a escolha do usuário.

// Exemplo de como o histórico é armazenado
List<string> historicoOperacoes = new List<string>();
historicoOperacoes.Add($"{num1} + {num2} = {resultado}");
