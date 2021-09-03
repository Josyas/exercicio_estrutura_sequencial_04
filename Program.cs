using System;
using System.Globalization;
namespace exercicio_estrutura_sequencial_04 {
    class Program {
        static void Main(string[] args) {


            double soma;

            Console.WriteLine("Total de funcionário: ");
            int totfunc = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor por hora: $");
            double valorhr = double.Parse(Console.ReadLine());
            Console.WriteLine("Total de horas trabalhadas: ");
            double tothoras = double.Parse(Console.ReadLine());

            soma = valorhr * tothoras;


            
            Console.WriteLine($"O total de funcionário é de {totfunc}");
            Console.WriteLine($"Valor por horas recebido {valorhr.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Total de horas trabalhado {tothoras.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Total a receber {soma}");
        }
    }
}
