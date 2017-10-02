# Módulo 10 Exercício 3 - Heranças e reescrita de métodos

1. Crie um projeto em consola C# chamado Heranca.

2. Defina uma classe para modelar os funcionários do banco. Sabendo que todo o funcionário possui nome e salário, encapsule os atributos.

3. Crie uma classe para cada tipo específico de funcionário herdando da classe Funcionario. Considere apenas três tipos específicos de funcionários: gerentes, telefonistas e caixas. Os gerentes possuem um nome de utilizador e uma senha para aceder ao sistema do banco. As telefonistas possuem um código de estação de trabalho. As Caixas possuem um número de balcão.

4. Teste o funcionamento dos três tipos de funcionários criando um objeto de cada uma das classes: Gerente, Telefonista e Caixas.

5. Suponha que todos os funcionários recebem um aumento de 10% do salário. Acrescente um método na classe Funcionario para calcular esse aumento

6. Altere a classe TestaFuncionarios para imprimir o aumento de cada funcionário assim como os outros dados. Depois, execute o teste novamente.

7. Suponha que os gerentes recebem um aumento maior que os outros funcionários(um aumento de 20%). Reescreva o método AumentaSalario() na classe Gerente. Porém, devemos permitir que as classes filhas possam reescrever o método e para tal precisamos alterá-lo na classe Funcionario acrescentando o modificador virtual.

8. Reescreva o método AumentaSalario() (utilizando a palavra override) e execute o teste novamente.

9. Defina na classe Funcionario um método para imprimir na tela o nome, salário e aumento dos funcionários. 

10. Reescreva o método que imprime os dados dos funcionários nas classes Gerente, Telefonista e Caixa para acrescentar a impressão dos dados específicos de cada tipo de funcionário chame-o MostraDados(). 

11. Modifique a classe TestaFuncionarios para utilizar o método MostraDados().