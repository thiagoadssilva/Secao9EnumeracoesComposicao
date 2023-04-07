# Enumerações e composição

## enumerações

As enumerações, ou enums, são um tipo de dados no C# que permitem definir um conjunto de valores constantes nomeados. Eles são úteis quando se deseja trabalhar com um conjunto fixo de valores, como dias da semana, estados civis ou tipos de operação.
Aqui está um exemplo de como declarar e usar uma enumeração no C#:

    enum DiasDaSemana {
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
    }

    class Program {
    static void Main(string[] args) {
        DiasDaSemana hoje = DiasDaSemana.Sexta;
        Console.WriteLine("Hoje é " + hoje);
    }
    }

As enumerações, ou enums, são um tipo de dados no C# que permitem definir um conjunto de valores constantes nomeados. Eles são úteis quando se deseja trabalhar com um conjunto fixo de valores, como dias da semana, estados civis ou tipos de operação.
Aqui está um exemplo de como declarar e usar uma enumeração no C#:
arduino Copy code

    enum DiasDaSemana {
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
    }

    class Program {
    static void Main(string[] args) {
        DiasDaSemana hoje = DiasDaSemana.Sexta;
        Console.WriteLine("Hoje é " + hoje);
    }
    }


    A saída seria:
    Hoje é Sexta

Observe que os valores constantes nomeados na enumeração são considerados membros da enumeração e podem ser acessados usando a sintaxe EnumName.MemberName. Além disso, os valores padrão associados aos membros da enumeração são inteiros consecutivos começando em 0, a menos que sejam especificados de outra forma.
Por exemplo, se definirmos enum DiasDaSemana { Segunda = 1, Terca, Quarta, Quinta, Sexta, Sabado, Domingo }, a primeira constante terá um valor de 1 e as seguintes terão valores de 2, 3, 4, 5, 6 e 7, respectivamente.

## Composição 

Composição é um princípio de programação orientada a objetos que permite que um objeto contenha outros objetos como seus membros. É uma forma de estabelecer relacionamentos entre objetos, em que um objeto é composto por outros objetos menores que realizam tarefas específicas.
Em C#, a composição pode ser realizada usando classes e objetos. Por exemplo, considere a classe Carro, que pode ter um motor, rodas, transmissão, etc. Em vez de herdar as características do motor, rodas e transmissão, a classe Carro pode conter esses objetos como membros.

    class Motor {
        // propriedades e métodos do motor
    }

    class Roda {
        // propriedades e métodos da roda
    }

    class Transmissao {
        // propriedades e métodos da transmissao
    }

    class Carro {
        private Motor motor;
        private Roda[] rodas;
        private Transmissao transmissao;
        
        public Carro() {
            this.motor = new Motor();
            this.rodas = new Roda[4];
            for (int i = 0; i < 4; i++) {
                this.rodas[i] = new Roda();
            }
            this.transmissao = new Transmissao();
        }
        
        // outros métodos do carro
    }

Neste exemplo, a classe Carro contém um objeto Motor, um array de objetos Roda e um objeto Transmissao. Esses objetos são criados no construtor da classe Carro.
A composição é útil porque permite que os objetos sejam modificados independentemente um do outro. Por exemplo, se um novo tipo de roda for desenvolvido, a classe Carro pode ser atualizada para usar esse novo tipo sem afetar o resto do código.
Além disso, a composição permite que objetos complexos sejam construídos a partir de objetos menores que realizam tarefas simples. Isso torna o código mais modular e mais fácil de entender e manter.

## Diagrama de classe

Diagrama de classe é uma ferramenta de modelagem usada para visualizar e descrever a estrutura e as relações entre as classes de um sistema. Ele é amplamente utilizado na engenharia de software para representar a estrutura de um sistema orientado a objetos.
O diagrama de classe é composto por caixas retangulares que representam as classes e linhas que conectam as classes, representando as relações entre elas. Existem diferentes tipos de relações, como herança, associação, agregação e composição, que podem ser representadas por diferentes tipos de linhas.
Além disso, o diagrama de classe pode incluir atributos e métodos das classes, bem como as visibilidades dos mesmos. Ele também pode conter outras informações, como multiplicidade e estereótipos.
O diagrama de classe é uma ferramenta muito útil para entender e documentar a estrutura de um sistema orientado a objetos, além de facilitar a comunicação entre os membros da equipe de desenvolvimento de software.

