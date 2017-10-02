# M�dulo 10 Projeto 1


Escreve um	programa	em	c# Windows Forms que	resolva	o	seguinte	problema: 

Pretende-se	uma	pequena	aplica��o	que	efetue	a	gest�o	da	informa��o	relacionada	com	jogadores	de	t�nis.

Os	dados	a	considerar	t�m	em	conta	que,	para	o	ranking dos	jogadores,	s�o	contabilizados	dez	jogos	realizados	anualmente.	Para	que	seja	poss�vel	manipular	a informa��o,	�	necess�rio	que	os	dados	de	cada	jogador	sejam	guardados	numa lista designado	Ranking.	Tendo	por	base	esta	informa��o,	e	as	imagens	indicadas, constr�i	um	programa	que efetue	a	gest�o	dos	jogadores	de	t�nis.

1. Crie um formul�rio (FormJogadores) semelhante	ao apresentado	na	figura.





1.1. O	bot�o	�Guardar�	permite	registar	na	tabela	um	novo	jogador 

1.2. soma das vit�rias e das derrotas tem que ser igual 10. Quando insere as vit�rias o n�mero de derrotas deve ser automaticamente alterado e vice-versa.

1.3. O bot�o	�Sair�	permite	fechar	a	janela. (this.Close())



2. Crie uma Classe Jogador com os dados do formul�rio. Encapsule os atributos. 



3. Adicione um novo formul�rio ao projeto (Windows Form) chamado FormMenu igual ao da imagem:



3.1. O bot�o "Sair" termina a aplica��o.

3.2. O bot�o "Gerir jogadores" abre o form criado anteriormente com o seguinte c�digo:

 FormJogadores novo = new FormJogadores();

            novo.Show();

3.3 Coloca o FormMenu como sendo o formul�rio de abertura: abre o Program.cs e altera o nome do form na linha "Application.Run(new FormMenu())".



4. Insere um formul�rio do tipo AboutBox, altera os dados com o nome do programa, o teu nome e uma breve descri��o do que faz o programa e uma imagem apropriada.

4.1 O bot�o sair fecha a janela

4.2 No FormMenu insere o c�digo no bot�o "sobre".



5. Adicione um novo Windows Form (ForrmRanking) semelhante ao da imagem:



5.1 O  bot�o sair fecha a janela.

5.2 A listView contem os nomes dos jogadores da lista Ranking, o n�mero no Ranking � inserido sequencialmente. 



6. Cria uma classe ListaJogadores. A classe tem como atributo uma lista de jogadores com todos os jogadores listaJogadores e uma lista de jogadores Ranking. 

6.1 Insere m�todos que permitam inserir um novo jogador e eliminar um jogador de uma determinada posi��o.

6.2 Cria um m�todo para ordenar a lista recebida pelo n�mero de vit�rias e armazena-la na lista Ranking. C�digo:  rank = todosJogadores.OrderByDescending(x => x.vitorias).ToList();

6.3 Cria um m�todo que localize um jogador (localizaJogador) pela posi��o no ranking, n�o te esque�as que um array come�a em zero e o ranking em 1. Retorne o jogador.

6.4 Reescreve o m�todo localizaJogador que procura na listaJogadores um jogador pelo nome. Retorne o jogador.

6.5 Uma vez que n�o desejamos criar inst�ncias da classe ListaJogadores, ou seja, criar com a palavra new, pois queremos que o Ranking se mantenha, temos que definir a classe assim como os atributos e os metodos como "static". 

6.7 No bot�o sair do FormJogadores chame o m�todo ordenaLista.

8. Crie uma textbox e um bot�o com o texto "Procurar" no design do FormJogadores.  Altere a propriedade Visible para False.

9. Crie uma vari�vel bool Alterar no inicio do c�digo do form inicialize-a a false. Cria uma bool procuraNome e inicialize-a a false.

10. No FormJogadores insere um menuStrip igual ao da figura:





10.1 A op��o novo coloca os campos a vazio ou aos valores por defeito.

10.2 A op��o Consultar por nome mostra uma textbox e um bot�o (escondidos no design). Coloque no c�digo o texto da texbox "Insira o nome a procurar". A bool procuraNome passa a true, chame o m�todo "localizaJogador" com o texto da textbox passado por par�metro. Os campos tomam os valores do respetivo jogador. A textbox e bot�o voltam a ficar invis�veis;

10.3 A op��o Consultar por ranking mostra uma textbox e um bot�o (escondidos no design). Coloque no c�digo o texto da texbox "Insira o n�mero do ranking"  e o texto do bot�o "Procurar". A bool procuraNome passa a false chame o m�todo "localizaJogador" com o texto da textbox passado por par�metro (converta para int). Os campos tomam os valores do respetivo jogador.  A textbox e bot�o voltam a ficar invis�veis;

10.4 A op��o Alterar mostra uma textbox e um bot�o (escondidos no design). Coloque no c�digo o texto da texbox "Insira o nome do jogador a alterar", chame o m�todo "localizaJogador" com o texto da textbox passado por par�metro. Os campos tomam os valores do respetivo jogador. A textbox e bot�o voltam a ficar invis�veis. A vari�vel Alterar passa a true. No bot�o guardar altere o c�digo de modo a identificar se esta a gravar pela primeira vez ou alterar o registo ;

10.5  A op��o Eliminar  mostra uma textbox e um bot�o (escondidos no design). Coloque no c�digo o texto da texbox "Insira o nome do jogador a eliminar", chame o m�todo "localizaJogador" com o texto da textbox passado por par�metro. Os campos tomam os valores do respetivo jogador. A textbox e bot�o voltam a ficar invis�veis. Insira um novo bot�o com o texto eliminar que apenas � vis�vel nesta ocasi�o. crie o c�digo para eliminar o jogador. volte a esconder o bot�o eliminar;

10.6  A op��o Ver ranking abre o FormRanking.

