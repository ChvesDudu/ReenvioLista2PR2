using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2Lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercicio1

            int n_de_laranja = int.Parse(Console.ReadLine());

            double preco_unitario;

            if (n_de_laranja < 0)
            {
                preco_unitario = 0.35;
            }
            else
            {
                preco_unitario = 0.28;
            }

            double todo_valor = n_de_laranja * preco_unitario;

            Console.WriteLine("Valor da compra R$: ", todo_valor);
            Console.ReadLine();


            //Exercicio2

            Console.WriteLine("Digite sua data de nascimento");

            int ano_de_nascimento = int.Parse(Console.ReadLine());

            int ano_atual = DateTime.Now.Year;

            int idade = ano_atual - ano_de_nascimento;

            if (idade >= 16)
            {
                Console.WriteLine("Você poderá votar na proxima eleição que tiver");
            }
            else
            {
                Console.WriteLine("Você não poderá votar na proxima eleição que tiver");
            }

            Console.WriteLine();
            Console.ReadLine();


            //Exercicio3


            Console.WriteLine("Digite o primeiro lado do trinagulo: ");

            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triangulo: ");

            double lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triangulo: ");

            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("O triangulo e equilatero");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("O triangulo e isoceles");
            }
            else
            {
                Console.WriteLine("O triangulo e escaleno");
            }

            Console.WriteLine();
            Console.ReadLine();


            //Exercicio4

            float a, b, c, delta, r1, r2;

            Console.WriteLine("Entre com o valor do coeficiente A: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do coeficiente B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do coeficiente C: ");
            c = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - 4 * (a * c);
                if (delta < 0)
                {
                    Console.WriteLine("A equação não possui raízes reais!");
                }
                else
                {
                    r1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("A raíz R1 é igual a " + r1);

                    if (delta > 0f)
                    {
                        r2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("A raíz R2 é igual a " + r2);
                    }
                }
            }


            //Exercicio5

            float numero;

            Console.WriteLine("Entre com um valor qualquer: ");
            numero = float.Parse(Console.ReadLine());

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Console.WriteLine("O número {0} é divisível por 3 e por 5.", numero);
            }
            else
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine("O número {0} é divisível apenas por 3.", numero);
                }
                else
                {
                    if (numero % 5 == 0)
                    {
                        Console.WriteLine("O número {0} é divisível apenas por 5.", numero);
                    }
                    else
                    {
                        Console.WriteLine("O númeor {0} não é divisível por 3.", numero);
                    }
                }
            }

            //Exercicio6


            Console.WriteLine("Digite o primeiro ângulo do triangulo: ");
            int angulo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo ângulo do triangulo: ");
            int angulo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro ângulo do triangulo: ");
            int angulo3 = int.Parse(Console.ReadLine());

            int soma_dos_angulos = angulo1 + angulo2 + angulo3;

            if (soma_dos_angulos == 180)
            {
                if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
                {
                    Console.WriteLine("O triangulo e retangulo");
                }
                else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
                {
                    Console.WriteLine("O triangulo e Obtusângulo");
                }
                else if (angulo1 < 90 || angulo2 < 90 || angulo3 < 90)
                {
                    Console.WriteLine("O triangulo e Acutângulo");
                }
                else
                {
                    Console.WriteLine("As somas dos angulos não formam um triangulo");
                }
            }


            //Exercicio7


            int v1, v2, v3;

            Console.WriteLine("Digite três valores inteiros:");
            string[] input = Console.ReadLine().Split(' ');

            ///Converte de string para int

            v1 = int.Parse(input[0]);
            v2 = int.Parse(input[1]);
            v3 = int.Parse(input[2]);

            ///Encontrar o valor menor 

            int menor = v1;
            if (v2 < menor) menor = v2;
            if (v3 < menor) menor = v3;

            ///Encontrar o valor maior

            int maior = v1;
            if (v2 > maior) maior = v2;
            if (v3 > maior) maior = v3;

            ///Encontrar o valor meio

            int meio = v1 + v2 + v3 - menor - maior;

            Console.WriteLine("Os valore em ordem são: {menor}, {meio}, {maior}");


            //Exercicio8

            int ano;

            //Coletar a informação (ano)
            Console.WriteLine("Entre com o ano a ser testado: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0)
            {
                Console.WriteLine("O ano {0} é bissexto!", ano);
            }
            else
            {
                if (ano % 4 == 0 && ano % 100 != 0)
                    Console.WriteLine("O ano {0} é bissexto!", ano);
                else
                {
                    Console.WriteLine("O ano {0} não é bissexto!", ano);
                }
            }
            Console.ReadKey();

            //Exercicio9

            double numero1, numero2, resultado;
            char operação;

            Console.WriteLine("Digite dois numeros reais separados");
            //string[] input = Console.ReadLine().Split(' ');

            ///Converte string para double
            numero1 = int.Parse(input[0]);
            numero2 = int.Parse(input[1]);

            Console.WriteLine("Digite a operação a ser realizada ( +,-, * ou /");
            operação = char.Parse(Console.ReadLine());

            switch (operação)
            {
                case '+':
                    resultado = numero1 + numero2;
                    Console.WriteLine("O resultado e {resultado}");
                    break;

                case '-':
                    resultado = numero1 - numero2;
                    Console.WriteLine("O resultado e {resultado}");
                    break;

                case '*':
                    resultado = numero1 * numero2;
                    Console.WriteLine("O resultado e {resultado}");
                    break;

                case '/':
                    resultado = numero1 / numero2;
                    Console.WriteLine("O resultado e {resultado}");
                    break;

                default:
                    Console.WriteLine("Operação não valida");
                    break;
            }

            //Exercicio10

            //Na linguagem c# e possivel fazer isso com a classe RANDON, para gerar numeros inteiros aleatorios usamos o "Next()". Ja para acharmos
            //um numeros real usamos o "NextDouble"().

            //Exemplo:

            ///Gerar um numero inteiro entre 1 e 100
            Random randomint = new Random();
            int numeroint = randomint.Next();

            ///Gerar um numero realentre 0,0 e 1,0
            Random randomDoumble = new Random();
            double numeroDoumble = randomDoumble.NextDouble();

        }
    }
}