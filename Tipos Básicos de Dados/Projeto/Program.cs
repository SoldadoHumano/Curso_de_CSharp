using System;

namespace Projeto {
    internal class Program {
        static void Main(string[] args) {

            /*
            Restrições para nomes de variáveis:
            - Não pode começar com dígito: usar uma letra ou _
            - Não usar acentos ou til
            - Não pode haver espaços em branco
            - Sugestão: usar nomes que tenham um significado no código

            Errado:                         Correto:
             int 5minutos;                   int _5minutos;
             int salário;                    int salario;
             int salario do funcionario;     int salarioDoFuncionario;

            Convenções:
            - Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)
            - Pascal Case: LastName (namespaces, classes, properties, e métodos)
            - Padrão: _lastName (atributos "internos" da classe)

            Imprimir saída padrão (console):
            - Comandos:
             - Console.WriteLine(); *Com quebra de linha*
             - Console.Write(); *Sem quebra de linha*

            variavel.ToString("F2") *Limita output para 2 casas decimais (ele arredonda os números)*
            */

            sbyte a = 100;
            byte b = 254; // OverFlow é quando um cálculo ultrapassa o limite da variável.
            int c = 1000;
            int d = 2147483647;
            long e = 2147483648L;
            float g = 4.5f;
            double h = 4.5;
            double saldo = 10.35784;

            bool f = false;
            char genero = 'F';
            char letra = '\u0041'; // Caracter unicode
            string nome = "Catharina"; // Uma vez criado uma string não há como alterar | Imutável
            object obj = "Catharina 2"; // Object aceita qualquer coisa sendo letras ou números

            int n1 = int.MinValue; // int.MinValue pega o menor valor possível da variável
            int n2 = int.MaxValue; // int.MaxValue pega o maior valor possível da variável

            b++; // Adiciona +1 (254 + 1 = 255) a variável b

            Console.WriteLine("Valores das variáveis:");
            Console.WriteLine();
            Console.WriteLine("Sbyte: " + a);
            Console.WriteLine("Byte: " + b);
            Console.WriteLine("Int: " + c);
            Console.WriteLine("Valor máximo int: " + d);
            Console.WriteLine("Valor máximo long: " + e);
            Console.WriteLine("Float: " + g);
            Console.WriteLine("Double: " + h);
            Console.WriteLine("Double com controle de casas: " + saldo.ToString("F2"));
            Console.WriteLine("Boolean: " + f);
            Console.WriteLine("Char: " + genero);
            Console.WriteLine("Char com caracter unicode: " + letra);
            Console.WriteLine("String: " + nome);
            Console.WriteLine("Object: " + obj);
            Console.WriteLine();
            Console.WriteLine("Min value int: " + n1);
            Console.WriteLine("Max value int: " + n2);
        }
    }
}