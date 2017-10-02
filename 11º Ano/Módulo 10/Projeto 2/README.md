# Módulo 10 Projeto 2

Pretende desenvolver-se um	programa	que	permita	efectuar	a	gestão	da	requisição	de	projetores	de	vídeo	utilizados	pelos	professores	nas	salas	de	aulas.



O	programa deve	permitir	efetuar	as	seguintes	operações: 

1. Gerir	os	projetores	de	vídeo	existentes	na	escola; 

2. Gerir	os	dados	dos professores; 

3. Requisitar	projetores através	de	uma	lista	de	projetores	disponíveis para	determinado	dia/hora; 

4. Listar	as	requisições	de	um	determinado	dia. 



Para	ser	possível	efetuar	esta gestão	é	necessário	implementar	as seguintes classes:

PROFESSORES(NrProfessor,	Nome,	Contacto,	GrupoDisciplinar ) 

PROJETORES(CodProjetor,	marca,	modelo,	funcional )

REQUISIÇÕES(NrRequisicao,	Nrprofessor, CodProjetor,	dia,	tempo	letivo ) 



Outras	considerações: 

• O	interface	fica	ao	critério	do	aluno;

 • O	programa	deve	disponibilizar menus	e	barra	de	ferramentas que	permitam efetuar	as	tarefas	anteriormente	enunciadas.

 Sugere-se	os	seguintes	menus:	“Ficheiro”	(onde	deve	constar	pelo	menos	o	item “Sair”);	“Gestão”	(onde	podem	constar	os	itens	“Gerir	professores”,	“Gerir projetores”	e	“Registar	requisições”);	e	“Consultas“	(onde	podem	constar	os	itens	“Consultar	professores”,	“Consultar	projetores”	e	“Consultar	requisições”; 

• Deve,	ainda,	ser	criado um	menu	“Ajuda”	que	contenha	pelo	menos	o	item	“Acerca”	que	permita	abrir	um	formulário	que	descreva	sinteticamente	o	programa	e apresente	os	dados	do	autor	da	aplicação;