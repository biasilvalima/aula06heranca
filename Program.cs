using System;

namespace aula06heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            CPF cpf = new CPF();
            cpf.nome = "Beatriz";
            System.Console.WriteLine(cpf.Saudar());
        }
    }
}
