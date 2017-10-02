# Módulo 9 - Exercício 3

Criar um programa mealheiro
O programa pede ao utilizador qual o preço do objeto que quer comprar.
Se o porquinho tiver dinheiro suficiente ( ou mais), indica quanto dinheiro permaneceria no mealheiro após a compra. No caso contrário, mostra  quanto  dinheiro falta.

Deverá criar os seguintes métodos:
- Um método getMontante retornando a quantidade do mealheiro;

- Um método de Visor que apresenta os dados do mealheiro no formato seguinte:
- Está sem um tostão se o banco piggy não contém dinheiro
- Tem: <montante> euros no banco.

- Um método Abanar que mostra no terminal a mensagem "Bing Bing" se o mealheiro tiver dinheiro e não apresenta mensagem se não tiver.

- O método de Encher colocando um parâmetro com determinado montante (double)
no mealheiro. Apenas valor positivo será aceite (no caso caso contrário não faz nada);

- Um método Esvaziar (re) inicializando a quantidade do mealheiro para zero;

- Um método Tirar para retirar um montante  do mealheiro dado por parâmetro. Se a quantidade for negativa, será ignorada. Se a quantidade é maior do que a quantidade disponível, então o mealheiro será esvaziado. O método Tirar não retorna nada.

- Um método montanteSuficiente  com dois parâmetros que retorna true se o mealheiro tem dinheiro suficiente para gastar um orçamento específico dado no primeiro parâmetro (tipo double) e falso caso contrário. Se houver dinheiro suficiente, o segundo parâmetro saldo (tipo double e passado por referência) fica com a quantidade que permaneceria no mealheiro depois de retirar o orçamento dado; caso contrário ele irá conter a quantidade em falta no mealheiro para chegar a esse orçamento.
Se o orçamento for negativo (ou zero), o método retorna true e ao segundo parâmetro Saldo é atribuído ao valor remanescente no mealheiro:

Teste a classe! 