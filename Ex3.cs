


namespace Exercicio_3
{

    public class Program
    {
        static void Main(string[] args)
        {
            //declarando variaveis
            string nome;
            double salario;
            double vendas;
            double salarioComComissao;

            //ler teclado
            Console.WriteLine("Informe o nome do vendedor");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o salario fixo do vendedor");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o total em vendas do(a) {nome} no mês");
            vendas = double.Parse(Console.ReadLine());

            //exibir os dados
            salarioComComissao = salario + (0.2 * vendas);

            Console.WriteLine($"Vendedor: {nome}" +
                $"\nSalario: {salario}" +
                $"\nSalario Final: {salarioComComissao}");

        }
    }
}
