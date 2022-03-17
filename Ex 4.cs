


namespace Exercicio_4
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Declarando Variaveis
            string nomeAluno;
            double notaProva1;
            double notaProva2;
            double notaProva3;
            double pesoNotaProva1 = 2;
            double pesoNotaProva2 = 4;
            double pesoNotaProva3 = 6;
            double mediaponderada;

            //Ler Teclado
            Console.Write("Informe o nome do aluno:");
            nomeAluno = Console.ReadLine();
            Console.Write("Informe a nota da prova 1:");
            notaProva1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota da prova 2:");
            notaProva2 = double.Parse(Console.ReadLine());
            Console.Write("Informe a nota da prova 3:");
            notaProva3 = double.Parse(Console.ReadLine());

            //Exibir media ponderada
           
            mediaponderada = (notaProva1 * pesoNotaProva1 + notaProva2 * pesoNotaProva2 + notaProva3 * pesoNotaProva3) / (pesoNotaProva1 + pesoNotaProva2 + pesoNotaProva3);

            Console.WriteLine($"Aluno: {nomeAluno} " +
                $"\nMedia Ponderada: {mediaponderada}"); 

           
             




        }
    }
}
