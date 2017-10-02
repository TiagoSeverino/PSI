# M�dulo 10 Projeto 2

Pretende desenvolver-se um	programa	que	permita	efectuar	a	gest�o	da	requisi��o	de	projetores	de	v�deo	utilizados	pelos	professores	nas	salas	de	aulas.



O	programa deve	permitir	efetuar	as	seguintes	opera��es: 

1. Gerir	os	projetores	de	v�deo	existentes	na	escola; 

2. Gerir	os	dados	dos professores; 

3. Requisitar	projetores atrav�s	de	uma	lista	de	projetores	dispon�veis para	determinado	dia/hora; 

4. Listar	as	requisi��es	de	um	determinado	dia. 



Para	ser	poss�vel	efetuar	esta gest�o	�	necess�rio	implementar	as seguintes classes:

PROFESSORES(NrProfessor,	Nome,	Contacto,	GrupoDisciplinar ) 

PROJETORES(CodProjetor,	marca,	modelo,	funcional )

REQUISI��ES(NrRequisicao,	Nrprofessor, CodProjetor,	dia,	tempo	letivo ) 



Outras	considera��es: 

� O	interface	fica	ao	crit�rio	do	aluno;

 � O	programa	deve	disponibilizar menus	e	barra	de	ferramentas que	permitam efetuar	as	tarefas	anteriormente	enunciadas.

 Sugere-se	os	seguintes	menus:	�Ficheiro�	(onde	deve	constar	pelo	menos	o	item �Sair�);	�Gest�o�	(onde	podem	constar	os	itens	�Gerir	professores�,	�Gerir projetores�	e	�Registar	requisi��es�);	e	�Consultas�	(onde	podem	constar	os	itens	�Consultar	professores�,	�Consultar	projetores�	e	�Consultar	requisi��es�; 

� Deve,	ainda,	ser	criado um	menu	�Ajuda�	que	contenha	pelo	menos	o	item	�Acerca�	que	permita	abrir	um	formul�rio	que	descreva	sinteticamente	o	programa	e apresente	os	dados	do	autor	da	aplica��o;