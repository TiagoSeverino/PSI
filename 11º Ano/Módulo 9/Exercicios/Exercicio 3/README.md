# M�dulo 9 - Exerc�cio 3

Criar um programa mealheiro
O programa pede ao utilizador qual o pre�o do objeto que quer comprar.
Se o porquinho tiver dinheiro suficiente ( ou mais), indica quanto dinheiro permaneceria no mealheiro ap�s a compra. No caso contr�rio, mostra  quanto  dinheiro falta.

Dever� criar os seguintes m�todos:
- Um m�todo getMontante retornando a quantidade do mealheiro;

- Um m�todo de Visor que apresenta os dados do mealheiro no formato seguinte:
- Est� sem um tost�o se o banco piggy n�o cont�m dinheiro
- Tem: <montante> euros no banco.

- Um m�todo Abanar que mostra no terminal a mensagem "Bing Bing" se o mealheiro tiver dinheiro e n�o apresenta mensagem se n�o tiver.

- O m�todo de Encher colocando um par�metro com determinado montante (double)
no mealheiro. Apenas valor positivo ser� aceite (no caso caso contr�rio n�o faz nada);

- Um m�todo Esvaziar (re) inicializando a quantidade do mealheiro para zero;

- Um m�todo Tirar para retirar um montante  do mealheiro dado por par�metro. Se a quantidade for negativa, ser� ignorada. Se a quantidade � maior do que a quantidade dispon�vel, ent�o o mealheiro ser� esvaziado. O m�todo Tirar n�o retorna nada.

- Um m�todo montanteSuficiente  com dois par�metros que retorna true se o mealheiro tem dinheiro suficiente para gastar um or�amento espec�fico dado no primeiro par�metro (tipo double) e falso caso contr�rio. Se houver dinheiro suficiente, o segundo par�metro saldo (tipo double e passado por refer�ncia) fica com a quantidade que permaneceria no mealheiro depois de retirar o or�amento dado; caso contr�rio ele ir� conter a quantidade em falta no mealheiro para chegar a esse or�amento.
Se o or�amento for negativo (ou zero), o m�todo retorna true e ao segundo par�metro Saldo � atribu�do ao valor remanescente no mealheiro:

Teste a classe! 