# Módulo 9 - Exercício 5

Crie um programa que simule as operaçõe básicas de uma Conta Corrente chamado MovimentosContaCorrente. Adicione uma classe Contacorrente 

• Atributos da classe ContaCorrente: 
numeroConta (inteiro) >> não pode receber um valor menor ou igual a zero; 
titular (string) >> não pode receber um valor nulo ou string vazia; 
saldo (double) >> não pode ter um valor menor que zero; 

• Implementar um construtor que recebe valores para os atributos numeroConta e titular da classe ContaCorrente. 

• Implementar métodos get e set para todos os atributos da classe exceto para o atributo saldo(o valor do atributo saldo só poderá ser alterado através dos métodos deposita, levantamento e transfere detalhados a seguir)

• Implementar o método boolean deposita(double valor) que deposita um valor na conta corrente. Verifique se o valor enviado é maior que zero e adicione ao saldo o valor enviado. O método retorna verdadeiro se o depósito foi realizado com sucesso ou falso em caso contrário.

 • Implementar o método boolean levantamento(double valor) que realiza um levantamento na conta corrente.  Verifique se o valor enviado é maior que zero e se há saldo suficiente para realizar o levantamento. O método retorna verdadeiro se o levantamento foi realizado com sucesso ou falso e caso contrário. 

• Implementar o método boolean transfere(double valor, ContaCorrente c2) que realiza uma transferência de um valor da conta corrente para a conta corrente c2. O método retorna verdadeiro se a transferência foi realizada com sucesso ou falso em caso contrário. OBS: Verificar se o valor enviado é maior que zero, se o objeto c2 não é nulo e se há saldo suficiente para realizar a transferência.

No programa MovimentosContaCorrente crie uma nova conta corrente com 300€ de saldo e em nome de João Silva. Deposite 200€ . Retire 400€. 
Crie outra conta corrente com 100€ e em nome de Ana Silva.
Transfira 100€ da conta do João para a Ana.
Mostre o saldo das duas contas.