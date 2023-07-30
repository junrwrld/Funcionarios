using funcionario2;
using System;
using System.Globalization;

namespace funcionarios
{
    public class _funcionarios
    {
        static void Main(string[] args)
        {
            Funcionario dados = new Funcionario();

            Console.WriteLine("Digite seu dados:");
            Console.Write("Nome:");
            dados.Nome = Console.ReadLine();
            Console.Write("Salário Bruto:");
            dados.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + dados);
            Console.WriteLine("");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AumentarSalario(porcentagem);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + dados);


        }
    }
}