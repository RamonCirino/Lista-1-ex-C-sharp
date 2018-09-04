using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\t Pressione a tecla enter para começar... \n \n");
            Console.ReadKey();
            // 1. Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:

            // a) Use uma única instrução Console.Write;
            Console.Write("\t Exercício 1 \n \n");
            Console.ReadKey();

            Console.WriteLine("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40 \n");
            Console.ReadKey();

            // b) Use quatro instruções Console.Write;
            Console.WriteLine(" 1\t 2\t 3\t 4\t 5\t 6\t 7\t 8\t 9\t 10");
            Console.WriteLine(" 11\t 12\t 13\t 14\t 15\t 16\t 17\t 18\t 19\t 20");
            Console.WriteLine(" 21\t 22\t 23\t 24\t 25\t 26\t 27\t 28\t 29\t 30");
            Console.WriteLine(" 31\t 32\t 33\t 34\t 35\t 36\t 37\t 38\t 39\t 40 \n");
            Console.ReadKey();

            // 2. O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para x = 2 e y = 3.
            Console.Write("\t Exercício 2 \n \n");
            Console.ReadKey();

            int x = 2;
            int y = 3;

            // Letra a) Imprime no prompt de comando o valor da variável x, ou seja, 2.

            Console.WriteLine("x = " + x);
            Console.ReadKey();

            // Letra b) Imprime no prompt de comando o valor da variável x + x, ou seja, 4.

            Console.WriteLine("O valor de x + x é " + (x + x));
            Console.ReadKey();

            // Letra c) Não aparece nenhum valor associada a variável x.

            Console.WriteLine("x = ");
            Console.ReadKey();

            // Letra d) Imprime a igualdade entre as somas x e y.

            Console.WriteLine((x + y) + " = " + (y + x));
            Console.ReadKey();

            // 3. O que o código a seguir imprime? R.: Aparecem a quantidade de asteriscos colocados ante da barra. 

            Console.Write("\t Exercício 3 \n \n");
            Console.ReadKey();


            Console.WriteLine("\n*\n**\n***\n****\n*****");
            Console.ReadKey();

            // 4. O que o código a seguir imprime? R.: Aparece a quantidade de asteriscos declaradas entre as aspas duplas.
            Console.Write("\t Exercício 4 \n \n");
            Console.ReadKey();

            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");
            Console.ReadKey();

            // 5. Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um estudante. Em seguida,
            // formate e imprima os dados lidos da seguinte forma: 99999 - nome sobrenome, onde, o número de matrícula e 
            // nome deverão ter cores de fonte diferentes à sua escolha. Dica: peaquise pela propriedade console.ForegroundColor

            Console.Write("\t Exercício 5 \n \n");
            Console.ReadKey();

            string info1, info2, info3;

            Console.WriteLine("Digite o seu RA e pressione a tecla enter: \n");
            info1 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Digite o seu Primeiro nome e pressione a tecla enter: \n");
            info2 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Digite o seu sobrenome e pressione a tecla enter: \n");
            info3 = Console.ReadLine();

            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\t" + info1);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\t" + info2);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\t" + info3);
            Console.ReadKey();

            Console.WriteLine("\n \n");

            // 6. Escreva um programa que solicite do usuário dois número, e imprima o resultado da soma, subtração, multipoicação e divisão.

            Console.Write("\t Exercício 6 \n \n");
            Console.ReadKey();

            string temp;

            double num1, num2;

            Console.WriteLine("Digite um valor e aperte a tecla enter: \n");

            Console.WriteLine("\n");

            temp = Console.ReadLine();
            num1 = int.Parse(temp);

            Console.WriteLine("Agora digite outro valor e aperte a tecla enter: \n");

            Console.WriteLine("\n");

            temp = Console.ReadLine();
            num2 = int.Parse(temp);

            double resultado;

            resultado = (num1 + num2);
            Console.WriteLine("A soma entre os valores digitados é igual a:.......... " + resultado);

            resultado = (num1 - num2);
            Console.WriteLine("A subtração entre os valores digitados é igual a:..... " + resultado);

            resultado = (num1 * num2);
            Console.WriteLine("O produto entre os valores digitados é igual a:....... " + resultado);

            resultado = (num1 / num2);
            Console.WriteLine("A divisão entre os valores digitados é igual a:....... " + resultado);

            Console.ReadKey();

            Console.WriteLine("\n");

            // 7.Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área.
            // Para isso, utilize as fórmulas: diâmetro = 2r; circunferência = 2Pir, área = Pir².

            Console.Write("\t Exercício 7 \n \n");
            Console.ReadKey();

            double r;
            string str;

            Console.WriteLine("Digite a medida de um raio de um círculo qualquer e pressione a tecla enter: \n");

            Console.WriteLine("\n");

            str = Console.ReadLine();
            r = int.Parse(str);

            double result;
            result = (2 * r);

            Console.WriteLine("Com o valor do raio fornecido o diâmetro do circulo medirá:..." + result);

            double Pi;
            Pi = 3.14;
            result = (2 * Pi * r);

            Console.WriteLine("O valor do comprimento da circunferência será:................" + result);

            result = (Pi * r * r);

            Console.WriteLine("O valor da área do circulo será:.............................." + result);

            Console.ReadKey();

            Console.WriteLine("\n");

            // 8. Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltipli do segundo.
            // Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo, se o usuário digitar 2 e 4, o primeiro
            // número não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.

            Console.Write("\t Exercício 8 \n \n");
            Console.ReadKey();

            string in1, in2;
            int m1, m2;

            Console.WriteLine("Digite o valor de um número inteiro: \n");

            in1 = Console.ReadLine();
            m1 = int.Parse(in1);

            Console.WriteLine("Digite o valor de outro número inteiro: \n");

            in2 = Console.ReadLine();
            m2 = int.Parse(in2);

            int quociente;
            int resto;

            quociente = (m1 / m2);
            resto = (m1 % m2);

            if (resto == 0)
            {
                Console.WriteLine("O primeiro valor digitado é um múltiplo do segundo. \n");
            }
            else
            {
                Console.WriteLine("O primeiro valor digitado não é um múltiplo do segundo. \n");
            }

            Console.ReadKey();

            Console.WriteLine("\n");

            // 9. Escreva um programa que receba como entrada um número de 5 digitos, separe o número em digitos individuais e imprima separados por 3 espaços cada um.
            // Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4 2 3 3 9. Dica: utilize as operações de divisão e módulo para extrair cada dígito do número.

            Console.Write("\t Exercício 9 \n \n");
            Console.ReadKey();

            string ent;
            int num;

            Console.WriteLine("Digite um número de 5 dígitos: \n");

            ent = Console.ReadLine();
            num = int.Parse(ent);

            int quociente1, resto1;

            quociente1 = (num / 10000);
            resto1 = (num % 10000);

            int quociente2, resto2;

            quociente2 = (resto1 / 1000);
            resto2 = (resto1 % 1000);

            int quociente3, resto3;

            quociente3 = (resto2 / 100);
            resto3 = (resto2 % 100);

            int quociente4, resto4;

            quociente4 = (resto3 / 10);
            resto4 = (resto3 % 10);

            Console.Write("\t" + quociente1);
            Console.Write("\t" + quociente2);
            Console.Write("\t" + quociente3);
            Console.Write("\t" + quociente4);
            Console.Write("\t" + resto4);

            Console.ReadLine();

            Console.WriteLine("\n");

            // 10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10 e imprima os valores em forma de tabela.

            Console.Write("\t Exercício 10 \n \n");
            Console.ReadKey();

            double a2, a3;

            a2 = Math.Pow(0, 2);
            a3 = Math.Pow(0, 3);

            double b2, b3;

            b2 = Math.Pow(1, 2);
            b3 = Math.Pow(1, 3);

            double c2, c3;

            c2 = Math.Pow(2, 2);
            c3 = Math.Pow(2, 3);

            double d2, d3;

            d2 = Math.Pow(3, 2);
            d3 = Math.Pow(3, 3);

            double e2, e3;

            e2 = Math.Pow(4, 2);
            e3 = Math.Pow(4, 3);

            double f2, f3;

            f2 = Math.Pow(5, 2);
            f3 = Math.Pow(5, 3);

            double g2, g3;

            g2 = Math.Pow(6, 2);
            g3 = Math.Pow(6, 3);

            double h2, h3;

            h2 = Math.Pow(7, 2);
            h3 = Math.Pow(7, 3);

            double i2, i3;

            i2 = Math.Pow(8, 2);
            i3 = Math.Pow(8, 3);

            double j2, j3;

            j2 = Math.Pow(9, 2);
            j3 = Math.Pow(9, 3);

            double k2, k3;

            k2 = Math.Pow(10, 2);
            k3 = Math.Pow(10, 3);

            Console.WriteLine("\t Número \t Quadrado \t     Cubo");
            Console.Write("\t 0 \t \t \t" + a2);
            Console.Write("\t \t" + a3);

            Console.Write("\t \t \t \t \t 1 \t \t \t" + b2);
            Console.Write("\t \t" + b3);

            Console.Write("\t \t \t \t \t 2 \t \t \t" + c2);
            Console.Write("\t \t" + c3);

            Console.Write("\t \t \t \t \t 3 \t \t \t" + d2);
            Console.Write("\t \t" + d3);

            Console.Write("\t \t \t \t \t 4 \t \t \t" + e2);
            Console.Write("\t \t" + e3);

            Console.Write("\t \t \t \t \t 5 \t \t \t" + f2);
            Console.Write("\t \t" + f3);

            Console.Write("\t \t \t \t \t 6 \t \t \t" + g2);
            Console.Write("\t \t" + g3);

            Console.Write("\t \t \t \t \t 7 \t \t \t" + h2);
            Console.Write("\t \t" + h3);

            Console.Write("\t \t \t \t \t 8 \t \t \t" + i2);
            Console.Write("\t \t" + i3);

            Console.Write("\t \t \t \t \t 9 \t \t \t" + j2);
            Console.Write("\t \t" + j3);

            Console.Write("\t \t \t \t \t 10 \t \t \t" + k2);
            Console.Write("\t \t" + k3);

            Console.Write("\n \n \n");
            Console.Write("\t   Obrigado por testar o software! \n \n \t...Pressione a tecla enter para sair... \n \n");
            Console.ReadKey();
        }
    }
}