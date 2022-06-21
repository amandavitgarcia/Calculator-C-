using System;

namespace Calculator 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //chamando o menu
            Menu();
        }

        //Menu com as opções de operações 
        static void Menu(){
            Console.Clear();
           
            //Mostrando as opções do menu
            Console.WriteLine("Qual operação será realizada?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Resto da Divisão");
            Console.WriteLine("0 - Sair");

            //P/ pular uma linha
            Console.WriteLine("");
            //Pegando a escolha do usuário
            short respUsuario = short.Parse(Console.ReadLine());
            
            //Chamando os métodos usando a condicional switch
            switch(respUsuario) {
                case 0: Sair(); break; //esse comando é usado p/ sair/ ENVIRONMENT é o ambiente que o programa está/ o EXIT exige sempre um parametro de saída/  0 representa que saiu com sucesso. 
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potencia(); break;
                case 6: RestoDivisao(); break;

            }
        }

        //Separando o código por operação para ficar mais legível
        static void Soma() {
           Console.Clear();     
            
           Console.WriteLine("Soma");

           Console.Clear(); //Inicia sempre com o terminal limpo 

           Console.WriteLine("Primeiro valor: ");
           float a1 = float.Parse(Console.ReadLine()); //conversão e o read é pra ler 

           Console.WriteLine("Segundo valor: ");
           float a2 = float.Parse(Console.ReadLine());

           Console.WriteLine(""); //deixa uma linha em branco

           float resultadoA = a1 + a2; //a soma

           Console.WriteLine("O resultado da soma é " + resultadoA); //1ª forma de mostrar o resultado

           //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

           Menu();

            /*Outras formas de mostrar o resultado
           Console.WriteLine("O resultado da soma é " + resultado); //concatenando simples.

           Console.WriteLine($"O resultado da soma é {resultado}"); //quando usamos um $ na frente de qualquer string, é possível fazer um interpolação de string, e ai entre chaves podemos colocar a variavel.

           Console.WriteLine($"O resultado da soma é {v1 + v2}"); //interpolação direta

           Console.WriteLine("O resultado da soma é " + (v1 + v2)); //concatenação direta. É neceesário o uso de parenteses para fazer a operação, caso contrario ele junta as strings.
           */
        }

        static void Subtracao(){
           Console.Clear();

           Console.WriteLine("Subtração");

           Console.WriteLine("Primeiro valor: ");
           float b1 = float.Parse(Console.ReadLine()); 

           Console.WriteLine("Segundo valor: ");
           float b2 = float.Parse(Console.ReadLine());

           Console.WriteLine("");

           float resultadoB = b1-b2;

           Console.WriteLine($"O resultado da subtração é {resultadoB}");

           //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

           Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Multiplicação");

            Console.WriteLine("Primeiro valor: ");
            float c1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Segundo valor: ");
            float c2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoC = c1 * c2;

            Console.WriteLine($"O resultado da multiplicação é {c1 * c2}");

            //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

            Menu();
        }

        static void Divisao(){
            Console.Clear();

            Console.WriteLine("Divisão");

            Console.WriteLine("Primeiro Valor: ");
            float d1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float d2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoD = d1 / d2;

            Console.WriteLine("O resultado da divisão é " + (d1 / d2));

            //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

            Menu();
        }

        static void Potencia(){
            Console.Clear();

            Console.WriteLine("Potência");

            Console.WriteLine("Primeiro Valor: ");
            float e1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float e2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            //Convert..ToString() - Faz o parse pra string
            double resultadoDouble = Math.Pow(e1, e2);

            string resultadoString = Convert.ToString(resultadoDouble);

            float resultadoFloat = float.Parse(resultadoString);

            Console.WriteLine("O resultado da potência é " + resultadoFloat);

            //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

            Menu();
        }

        static void RestoDivisao(){
            Console.Clear();

            Console.WriteLine("Resto");

            Console.WriteLine("Primeiro Valor: ");
            float f1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float f2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultadoF = f1 % f2;

            Console.WriteLine($"O resto da divisão é {resultadoF}");

            //Determinando tempo para mostrar a resposta da operação 
           Thread.Sleep(4000);

            Menu();
        }

        //Função que mostra uma mensagem quando o usuário sai do programa
        static void Sair(){
            Console.WriteLine("Calculadora finalizada");

           Thread.Sleep(4000);
            System.Environment.Exit(0);
        }
    }
}

