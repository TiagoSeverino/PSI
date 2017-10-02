# M�dulo 9 - Exerc�cio 5

Crie um programa que simule as opera��e b�sicas de uma Conta Corrente chamado MovimentosContaCorrente. Adicione uma classe Contacorrente 

� Atributos da classe ContaCorrente: 
numeroConta (inteiro) >> n�o pode receber um valor menor ou igual a zero; 
titular (string) >> n�o pode receber um valor nulo ou string vazia; 
saldo (double) >> n�o pode ter um valor menor que zero; 

� Implementar um construtor que recebe valores para os atributos numeroConta e titular da classe ContaCorrente. 

� Implementar m�todos get e set para todos os atributos da classe exceto para o atributo saldo(o valor do atributo saldo s� poder� ser alterado atrav�s dos m�todos deposita, levantamento e transfere detalhados a seguir)

� Implementar o m�todo boolean deposita(double valor) que deposita um valor na conta corrente. Verifique se o valor enviado � maior que zero e adicione ao saldo o valor enviado. O m�todo retorna verdadeiro se o dep�sito foi realizado com sucesso ou falso em caso contr�rio.

 � Implementar o m�todo boolean levantamento(double valor) que realiza um levantamento na conta corrente.  Verifique se o valor enviado � maior que zero e se h� saldo suficiente para realizar o levantamento. O m�todo retorna verdadeiro se o levantamento foi realizado com sucesso ou falso e caso contr�rio. 

� Implementar o m�todo boolean transfere(double valor, ContaCorrente c2) que realiza uma transfer�ncia de um valor da conta corrente para a conta corrente c2. O m�todo retorna verdadeiro se a transfer�ncia foi realizada com sucesso ou falso em caso contr�rio. OBS: Verificar se o valor enviado � maior que zero, se o objeto c2 n�o � nulo e se h� saldo suficiente para realizar a transfer�ncia.

No programa MovimentosContaCorrente crie uma nova conta corrente com 300� de saldo e em nome de Jo�o Silva. Deposite 200� . Retire 400�. 
Crie outra conta corrente com 100� e em nome de Ana Silva.
Transfira 100� da conta do Jo�o para a Ana.
Mostre o saldo das duas contas.