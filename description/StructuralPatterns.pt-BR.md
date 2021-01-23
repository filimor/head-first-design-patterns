# Padrões de Projeto Estruturais

Os Padrões de Projeto Estruturais são padrões de projeto que facilitam o design
identificando uma maneira simples de realizar relacionamentos entre entidades.
Padrões estruturais servem para vincular funções existentes.

## Padrão Decorator

O padrão Decorator habilita a adição ou remoção de funcionalidades do objeto
sem alterar a aparência externa ou função do objeto. Ele altera a funcionalidade
do objeto de uma forma que seja transparente aos seus clientes usando uma
instância de uma subclasse da classe original que delega operações ao objeto
original. O Padrão Decorator incluir responsabilidades adicionais a um objeto
dinamicamente para prover uma alternativa flexível para alterar funcionalidades
do objeto sem usar herança estática.

<img src="decorator.png" width=400>

### Benefícios do Padrão Decorator

* Mais flexibilidade do que a herança estática.
* Evita classes com características de alto nível na hierarquia.
* Simplifica o código porque você escreve uma série de classes, cada uma
objetivando uma parte específica da funcionalidade, ao invés de codificar todos
os comportamentos dentro do objeto.
* Garante a extensibilidade do objeto porque você altera o código com novas
classes.

### Quando Usar o Padrão Decorator

* Você quer adicionar responsabilidades a objetos individuais dinamicamente e de
forma transparente, ou seja, sem afetar outros objetos.
* Você quer adicionar responsabilidades ao objeto que você quer alterar no
futuro.
* Quando a extensão por sub-classes estáticas é impraticável.

> Disponível em:
[https://www.gofpatterns.com/structural-patterns/index.php](https://www.gofpatterns.com/structural-patterns/index.php) (tradução livre)
