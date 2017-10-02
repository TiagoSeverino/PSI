# M�dulo 10 Exerc�cio 3 - Heran�as e reescrita de m�todos

1. Crie um projeto em consola C# chamado Heranca.

2. Defina uma classe para modelar os funcion�rios do banco. Sabendo que todo o funcion�rio possui nome e sal�rio, encapsule os atributos.

3. Crie uma classe para cada tipo espec�fico de funcion�rio herdando da classe Funcionario. Considere apenas tr�s tipos espec�ficos de funcion�rios: gerentes, telefonistas e caixas. Os gerentes possuem um nome de utilizador e uma senha para aceder ao sistema do banco. As telefonistas possuem um c�digo de esta��o de trabalho. As Caixas possuem um n�mero de balc�o.

4. Teste o funcionamento dos tr�s tipos de funcion�rios criando um objeto de cada uma das classes: Gerente, Telefonista e Caixas.

5. Suponha que todos os funcion�rios recebem um aumento de 10% do sal�rio. Acrescente um m�todo na classe Funcionario para calcular esse aumento

6. Altere a classe TestaFuncionarios para imprimir o aumento de cada funcion�rio assim como os outros dados. Depois, execute o teste novamente.

7. Suponha que os gerentes recebem um aumento maior que os outros funcion�rios(um aumento de 20%). Reescreva o m�todo AumentaSalario() na classe Gerente. Por�m, devemos permitir que as classes filhas possam reescrever o m�todo e para tal precisamos alter�-lo na classe Funcionario acrescentando o modificador virtual.

8. Reescreva o m�todo AumentaSalario() (utilizando a palavra override) e execute o teste novamente.

9. Defina na classe Funcionario um m�todo para imprimir na tela o nome, sal�rio e aumento dos funcion�rios. 

10. Reescreva o m�todo que imprime os dados dos funcion�rios nas classes Gerente, Telefonista e Caixa para acrescentar a impress�o dos dados espec�ficos de cada tipo de funcion�rio chame-o MostraDados(). 

11. Modifique a classe TestaFuncionarios para utilizar o m�todo MostraDados().