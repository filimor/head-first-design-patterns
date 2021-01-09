# Padrões Comportamentais

## Padrão Strategy

O objetivo do Padrão Strategy é definir uma família de algoritmos, encapsular
cada algoritmo e torná-los intercambiáveis. O Padrão Strategy permite que o
algoritmo varie independentemente dos clientes que o usam. Além disso, o padrão
define um grupo de classes que representam um conjunto de comportamentos
possíveis. Os comportamentos podem então ser usados em uma aplicação para
alterar suas funcionalidades.

### Benefícios

* Uma alternativa à herança de classe;
* Define cada comportamento em sua própria classe, o que elimina declarações
condicionais;
* Mais fácil de extender um modelo para incorporar novos comportamentos sem
alterar o código da aplicação.

### Quando Usar

* Muitas classes relacionadas diferem entre si apenas em seus comportamentos;
* Você precisa de diferentes variações de um algoritmo;
* Um algoritmo usa dados desconhecidos pelos clientes.

Disponível em:
[https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php](https://www.gofpatterns.com/behavioral/patterns/strategy-pattern.php)