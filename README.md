# Calculadora Simples em C#

Este é um projeto de console simples em C# que realiza operações básicas de aritmética, incluindo **soma**, **subtração**, **divisão**, e **multiplicação**. A calculadora é executada em loop até que o usuário escolha sair.

## Funcionalidades

- **Soma**: Realiza a soma de dois números fornecidos pelo usuário.
- **Subtração**: Realiza a subtração entre dois números.
- **Divisão**: Calcula o quociente da divisão entre dois números.
- **Multiplicação**: Calcula o produto de dois números.
- **Sair**: Encerra o programa.

## Estrutura do Código

- **Menu Principal**: Apresenta as opções de operações para o usuário e captura a escolha.
- **Switch Case**: Direciona o usuário para a operação escolhida. Caso o usuário insira uma opção inválida, o programa redireciona automaticamente para a opção de Soma.
- **Métodos de Operações**: Cada operação possui um método separado que calcula o resultado e exibe para o usuário. Após o cálculo, o programa retorna ao menu principal.

## Como Usar

1. Clone o repositório ou copie o código para o seu ambiente de desenvolvimento.
2. Compile e execute o programa.
3. No menu principal, selecione a operação desejada digitando o número correspondente:
   - **1** para Soma
   - **2** para Subtração
   - **3** para Divisão
   - **4** para Multiplicação
   - **5** para Sair
4. Para cada operação, insira dois números conforme solicitado. O resultado será exibido na tela.
5. Pressione qualquer tecla para retornar ao menu e realizar uma nova operação.

## Exemplo de Uso

```plaintext
Qual operação deseja realizar?

1- Soma
2- Subtração
3- Divisão
4- Multiplicação
5- Sair

Selecione uma Opção: 1
Primeiro Valor: 10
Segundo valor: 5
O resultado da soma é 15
