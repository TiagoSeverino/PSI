# Módulo 10 Projeto 1


Escreve um	programa	em	c# Windows Forms que	resolva	o	seguinte	problema: 

Pretende-se	uma	pequena	aplicação	que	efetue	a	gestão	da	informação	relacionada	com	jogadores	de	ténis.

Os	dados	a	considerar	têm	em	conta	que,	para	o	ranking dos	jogadores,	são	contabilizados	dez	jogos	realizados	anualmente.	Para	que	seja	possível	manipular	a informação,	é	necessário	que	os	dados	de	cada	jogador	sejam	guardados	numa lista designado	Ranking.	Tendo	por	base	esta	informação,	e	as	imagens	indicadas, constrói	um	programa	que efetue	a	gestão	dos	jogadores	de	ténis.

1. Crie um formulário (FormJogadores) semelhante	ao apresentado	na	figura.





1.1. O	botão	“Guardar”	permite	registar	na	tabela	um	novo	jogador 

1.2. soma das vitórias e das derrotas tem que ser igual 10. Quando insere as vitórias o número de derrotas deve ser automaticamente alterado e vice-versa.

1.3. O botão	“Sair”	permite	fechar	a	janela. (this.Close())



2. Crie uma Classe Jogador com os dados do formulário. Encapsule os atributos. 



3. Adicione um novo formulário ao projeto (Windows Form) chamado FormMenu igual ao da imagem:



3.1. O botão "Sair" termina a aplicação.

3.2. O botão "Gerir jogadores" abre o form criado anteriormente com o seguinte código:

 FormJogadores novo = new FormJogadores();

            novo.Show();

3.3 Coloca o FormMenu como sendo o formulário de abertura: abre o Program.cs e altera o nome do form na linha "Application.Run(new FormMenu())".



4. Insere um formulário do tipo AboutBox, altera os dados com o nome do programa, o teu nome e uma breve descrição do que faz o programa e uma imagem apropriada.

4.1 O botão sair fecha a janela

4.2 No FormMenu insere o código no botão "sobre".



5. Adicione um novo Windows Form (ForrmRanking) semelhante ao da imagem:



5.1 O  botão sair fecha a janela.

5.2 A listView contem os nomes dos jogadores da lista Ranking, o número no Ranking é inserido sequencialmente. 



6. Cria uma classe ListaJogadores. A classe tem como atributo uma lista de jogadores com todos os jogadores listaJogadores e uma lista de jogadores Ranking. 

6.1 Insere métodos que permitam inserir um novo jogador e eliminar um jogador de uma determinada posição.

6.2 Cria um método para ordenar a lista recebida pelo número de vitórias e armazena-la na lista Ranking. Código:  rank = todosJogadores.OrderByDescending(x => x.vitorias).ToList();

6.3 Cria um método que localize um jogador (localizaJogador) pela posição no ranking, não te esqueças que um array começa em zero e o ranking em 1. Retorne o jogador.

6.4 Reescreve o método localizaJogador que procura na listaJogadores um jogador pelo nome. Retorne o jogador.

6.5 Uma vez que não desejamos criar instâncias da classe ListaJogadores, ou seja, criar com a palavra new, pois queremos que o Ranking se mantenha, temos que definir a classe assim como os atributos e os metodos como "static". 

6.7 No botão sair do FormJogadores chame o método ordenaLista.

8. Crie uma textbox e um botão com o texto "Procurar" no design do FormJogadores.  Altere a propriedade Visible para False.

9. Crie uma variável bool Alterar no inicio do código do form inicialize-a a false. Cria uma bool procuraNome e inicialize-a a false.

10. No FormJogadores insere um menuStrip igual ao da figura:





10.1 A opção novo coloca os campos a vazio ou aos valores por defeito.

10.2 A opção Consultar por nome mostra uma textbox e um botão (escondidos no design). Coloque no código o texto da texbox "Insira o nome a procurar". A bool procuraNome passa a true, chame o método "localizaJogador" com o texto da textbox passado por parâmetro. Os campos tomam os valores do respetivo jogador. A textbox e botão voltam a ficar invisíveis;

10.3 A opção Consultar por ranking mostra uma textbox e um botão (escondidos no design). Coloque no código o texto da texbox "Insira o número do ranking"  e o texto do botão "Procurar". A bool procuraNome passa a false chame o método "localizaJogador" com o texto da textbox passado por parâmetro (converta para int). Os campos tomam os valores do respetivo jogador.  A textbox e botão voltam a ficar invisíveis;

10.4 A opção Alterar mostra uma textbox e um botão (escondidos no design). Coloque no código o texto da texbox "Insira o nome do jogador a alterar", chame o método "localizaJogador" com o texto da textbox passado por parâmetro. Os campos tomam os valores do respetivo jogador. A textbox e botão voltam a ficar invisíveis. A variável Alterar passa a true. No botão guardar altere o código de modo a identificar se esta a gravar pela primeira vez ou alterar o registo ;

10.5  A opção Eliminar  mostra uma textbox e um botão (escondidos no design). Coloque no código o texto da texbox "Insira o nome do jogador a eliminar", chame o método "localizaJogador" com o texto da textbox passado por parâmetro. Os campos tomam os valores do respetivo jogador. A textbox e botão voltam a ficar invisíveis. Insira um novo botão com o texto eliminar que apenas é visível nesta ocasião. crie o código para eliminar o jogador. volte a esconder o botão eliminar;

10.6  A opção Ver ranking abre o FormRanking.

