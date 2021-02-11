using System;

namespace teste_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int fim = 0;
            int input = 0;
            int multiplicador = 0;
            multiplicador = Int32.Parse(Console.ReadLine());
            inicio = Int32.Parse(Console.ReadLine());
            fim = Int32.Parse(Console.ReadLine());
            int intervalo = fim - inicio;
            if (multiplicador < 0 || multiplicador > 3000){
                if (multiplicador > 3000)
                {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O multiplicador não pode ser maior que 3000");

                }
                else if (multiplicador <0)
                {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O multiplicador não pode ser menor que 0");

                }
            }
            else if (inicio > 3000 || fim > 3000) {
                if (inicio > 3000)
                {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O início do intervalo não pode ser maior que 3000");
                }
                else
                {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O fim do intervalo não pode ser maior que 3000");
                }
            }
            else if (inicio < 0 || fim < 0)
            {
                if(inicio < 0)
                {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O início do intervalo não pode ser menor que 0");
                }
                else {
                    Console.WriteLine("Multiplicando: " + multiplicador);
                    Console.WriteLine("Início do intervalo:" + inicio);
                    Console.WriteLine("Fim do intervalo: " + fim);
                    Console.WriteLine("O fim do intervalo não pode ser menor que 0");
                }
            }
            else if (inicio > fim)
            {
                Console.WriteLine("Multiplicando: " + multiplicador);
                Console.WriteLine("Início do intervalo:" + inicio);
                Console.WriteLine("Fim do intervalo: " + fim);
                Console.WriteLine("O início do intervalo deve ser menor que o seu fim");
            }
            else if (intervalo > 10 )
            {
                Console.WriteLine("Multiplicando: " + multiplicador);
                Console.WriteLine("Início do intervalo:" + inicio);
                Console.WriteLine("Fim do intervalo: " + fim);
                Console.WriteLine("O intervalo entre o início e o fim tem que ser menor ou igual a 10");
            }
            else
            {
                Console.WriteLine("Multiplicando: " + multiplicador);
                Console.WriteLine("Início do intervalo:" + inicio);
                Console.WriteLine("Fim do intervalo: " + fim);
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(multiplicador + " x " + i + " = " + multiplicador * i);

                }

            }
        }
    }
}
