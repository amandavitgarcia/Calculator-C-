# Calculator-CSharp-
Creating a calculator using C#.
This calculator has the operations: addition, subtraction, multiplication, division, power and remainder of division.


using System;

namespace Calculator 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
           
            Console.WriteLine("Qual operação será realizada?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Resto da Divisão");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("");
            short respUsuario = short.Parse(Console.ReadLine());

            switch(respUsuario) {
                case 0: Sair(); break; 
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potencia(); break;
                case 6: RestoDivisao(); break;
            }
        }

        static void Soma() {
           Console.Clear();     
            
           Console.WriteLine("Soma");

           Console.Clear(); 

           Console.WriteLine("Primeiro valor: ");
           float a1 = float.Parse(Console.ReadLine()); 

           Console.WriteLine("Segundo valor: ");
           float a2 = float.Parse(Console.ReadLine());

           Console.WriteLine(""); 

           float resultadoA = a1 + a2; 

           Console.WriteLine("O resultado da soma é " + resultadoA); 

           Thread.Sleep(4000);

           Menu();


           Console.WriteLine("O resultado da soma é " + resultado);

           Console.WriteLine($"O resultado da soma é {resultado}"); 
           Console.WriteLine($"O resultado da soma é {v1 + v2}"); 

           Console.WriteLine("O resultado da soma é " + (v1 + v2)); 
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

            double resultadoDouble = Math.Pow(e1, e2);

            string resultadoString = Convert.ToString(resultadoDouble);

            float resultadoFloat = float.Parse(resultadoString);

            Console.WriteLine("O resultado da potência é " + resultadoFloat);

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

           Thread.Sleep(4000);

            Menu();
        }

        static void Sair(){
            Console.WriteLine("Calculadora finalizada");

           Thread.Sleep(4000);
            System.Environment.Exit(0);
        }
    }
}

