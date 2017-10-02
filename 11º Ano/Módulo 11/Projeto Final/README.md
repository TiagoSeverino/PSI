# Módulo 11 Projeto 1

A empresa Sousa lda tem duas categorias de empregados, funcionários permanentes e trabalhadores temporários. Além disso, alguns funcionários temporários são vendedores.

Um empregado é caracterizado pelos seguintes atributos:

   O estatuto (permanentes ou temporários).
·       O nome dos empregados.

Um empregado permanente é caracterizado pelos seguintes atributos:

·       O número de dias trabalhados no mês.

<·       O salário mensal fixo (supomos que trabalha 20 dias por mês).

      O número de filhos.

·       O estado civil.

·       O montante do bónus mensal por crianças.

O salário dos empregados permanentes é composto do salário mensal fixo mais o bónus por criança (se o empregado for casado!). Multiplicamos o bónus pelo número de crianças se o empregado tiver vários filhos.

 

Os empregados temporários são caracterizados por:

·       salário por hora.

·       número de horas trabalhadas no mês.

Os vendedores são ainda caracterizados por:

·       volume de vendas (em euros).

·       comissão (percentagem cobrada sobre a venda).

Os empregados temporários são pagos à hora recebendo, ainda, uma comissão em função do volume de vendas, se for vendedor.

 

O pessoal da empresa é representado como uma coleção (lista), o acesso a um elemento faz-se através do nome. Supõe-se que os funcionários têm nomes diferentes.

Na coleção de trabalhadores, queremos fazer o seguinte:

·       Ver os dados do empregado.

·       Contratar um novo empregado em uma das categorias especificadas.

·       Demitir um funcionário.

 

Crie as classes, atributos e métodos para gerir todos os empregados. A classe empregado é abstrata, as classes temporários e permanentes herdam da classe empregado e a classe vendedores herda da classe temporários. Utilize a reescrita de métodos.