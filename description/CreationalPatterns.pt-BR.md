# Padrões de Projeto Criacionais

Em engenharia de software, padrões de projeto criacionais são os que lidam com
mecanismos de criação dos objetos, tentando criá-los de uma maneira adaptável
à situação. A forma básica de criação de um objeto pode resultar em problemas
de design ou adicionar complexidade extra. Os padrões criacionais resolvem
esse problema de certa forma controlando a criação do objeto.

Os padrões de projeto criacionais são compostos de duas ideias dominantes.

* Uma é encapsular o conhecimento sobre que classes concretas o sistema usa.
* A outra é esconder como as instâncias dessas classes concretas são criadas
e combinadas.

## Padrão Decorator

O padrão Decorator habilita a adição ou remoção de funcionalidades do objeto
sem alterar a aparência externa

### Benefícios

* Mais flexibilidade do que a herança estática.
* Evita classes com características de alto nível na hierarquia.
* Simplifica o código porque você escreve uma série de classes, cada uma
objetivando uma parte específica da funcionalidade, ao invés de codificar todos
os comportamentos dentro do objeto.
* Garante a extensibilidade do objeto porque você altera o código com novas
classes.

### Quando Usar

* Você quer adicionar responsabilidades a objetos individuais dinamicamente e de
forma transparente, ou seja, sem afetar outros objetos.
* Você quer adicionar responsabilidades ao objeto que você quer alterar no
futuro.
* Quando a extensão por sub-classes estáticas é impraticável.

> Disponível em:
[https://www.gofpatterns.com/creational/index.php](https://www.gofpatterns.com/creational/index.php) (tradução livre)
