# M�dulo 11 Projeto 1

A empresa Sousa lda tem duas categorias de empregados, funcion�rios permanentes e trabalhadores tempor�rios. Al�m disso, alguns funcion�rios tempor�rios s�o vendedores.

Um empregado � caracterizado pelos seguintes atributos:

   O estatuto (permanentes ou tempor�rios).
�       O nome dos empregados.

Um empregado permanente � caracterizado pelos seguintes atributos:

�       O n�mero de dias trabalhados no m�s.

<�       O sal�rio mensal fixo (supomos que trabalha 20 dias por m�s).

      O n�mero de filhos.

�       O estado civil.

�       O montante do b�nus mensal por crian�as.

O sal�rio dos empregados permanentes � composto do sal�rio mensal fixo mais o b�nus por crian�a (se o empregado for casado!). Multiplicamos o b�nus pelo n�mero de crian�as se o empregado tiver v�rios filhos.

 

Os empregados tempor�rios s�o caracterizados por:

�       sal�rio por hora.

�       n�mero de horas trabalhadas no m�s.

Os vendedores s�o ainda caracterizados por:

�       volume de vendas (em euros).

�       comiss�o (percentagem cobrada sobre a venda).

Os empregados tempor�rios s�o pagos � hora recebendo, ainda, uma comiss�o em fun��o do volume de vendas, se for vendedor.

 

O pessoal da empresa � representado como uma cole��o (lista), o acesso a um elemento faz-se atrav�s do nome. Sup�e-se que os funcion�rios t�m nomes diferentes.

Na cole��o de trabalhadores, queremos fazer o seguinte:

�       Ver os dados do empregado.

�       Contratar um novo empregado em uma das categorias especificadas.

�       Demitir um funcion�rio.

 

Crie as classes, atributos e m�todos para gerir todos os empregados. A classe empregado � abstrata, as classes tempor�rios e permanentes herdam da classe empregado e a classe vendedores herda da classe tempor�rios. Utilize a reescrita de m�todos.