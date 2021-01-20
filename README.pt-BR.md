# Use a Cabeça Padrões de Projeto

> Um conjunto de laboratórios para entender e praticar padrões de projeto (em desenvolvimento).

![Code Climate maintainability](https://img.shields.io/codeclimate/maintainability/filimor/head-first-design-patterns)
![GitHub repo size](https://img.shields.io/github/repo-size/filimor/head-first-design-patterns)
![GitHub license](https://img.shields.io/github/license/filimor/head-first-design-patterns)
![GitHub last commit](https://img.shields.io/github/last-commit/filimor/head-first-design-patterns)

*Leia em outros idiomas:* [English](https://github.com/filimor/head-first-design-patterns/blob/master/README.md), [Português (Brasil)](https://github.com/filimor/head-first-design-patterns/blob/master/README.pt-br.md)

## Descrição

Este é um repositório de descrições, diagramas de classe UML e exemplos dos
padrões de projeto, baseado no livro 'Use a Cabeça Padrões de Projeto' mas
adaptado à linguagem C# (.NET 5).

## Índice

* [Padrões Comportamentais](desctiption/BehavioralPatterns.pt-BR.md)
* [Padrões Criacionais](desctiption/CreationalPatterns.pt-BR.md)

# Diagrams de Classe

Os [Diagramas de Classe UML](docs/HeadFirstDesignPatterns.asta) foram feitos com o Astah UML.

# Princípios de projeto

Os padrões de projeto são orientados pelos seguintes princípios:

1. Identifique aspectos do seu aplicativo que variam e separe-os do que
permanece igual (encapsule o que varia).
2. Programe para uma interface, não para uma implementação.
3. Dê prioridade à composição em relação à herança (TEM-UM pode ser melhor do
que É-UM).
4. Busque projetos baixamente acoplados entre objetos que interagem.
5. As classes devem estar abertas para extensão, mas fechadas para modificação

# Padrões de projeto

| Padrão | Descrição |
|-|-|
| **STRATEGY** | Define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. A estratégia deixa o algoritmo variar independentemente dos clientes que o utilizam. |
| **OBSERVER** | Define uma dependência um-para-muitos entre objetos de modo que, quando um objeto muda de estado, todos os seus dependentes são notificados e atualizados automaticamente. |
| **DECORATOR** | Anexa responsabilidades adicionais a um objeto de maneira dinâmica. Os decoradores fornecem uma alternativa flexível para a subclasse para estender a funcionalidade. |

## Feito Com

- [Microsoft Visual Studio 2019 Community Edition](https://visualstudio.microsoft.com/vs/community/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Astah UML Model Version 39](https://astah.net/products/astah-uml/)

## Contribuindo

Se você quer ajudar a traduzir o projeto, incluir outras linguagens ou me avisar
sobre algum erro, fique à vontade! Por favor siga nosso
[código de conduta](https://github.com/filimor/head-first-design-patterns/blob/master/CODE_OF_CONDUCT.pt-BR.md).

## Traduções

* [English](https://github.com/filimor/head-first-design-patterns/blob/master/README.md)
* [Português (Brasil)](https://github.com/filimor/head-first-design-patterns/blob/master/README.pt-br.md)

## Créditos

* [@filimor](https://github.com/filimor/)
* [@bethrobson](https://github.com/bethrobson/Head-First-Design-Patterns)
(Repositório oficial do livro)

## Contato

* [E-mail](mailto:filimor@posteo.net)
* [LinkedIn](https://www.linkedin.com/in/filimor/)
* [Twitter](https://www.twitter.com/filimorbr/)

## Licença

Este projeto é licenciado sob uma licença MIT - veja
[LICENSE.md](https://github.com/filimor/head-first-design-patterns/blob/master/LICENSE "MIT")
para mais detalhes (em inglês).
