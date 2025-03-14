using System;

class Program {
  public static void Main (string[] args) {
        Console.WriteLine("                   MÉDIA DOS ALUNOS");
        Console.WriteLine("Digite a quantidade de alunos para o calculo da média: ");
        int numeroAlunos = int.Parse(Console.ReadLine());
            int numeroBimestres = 4;
            string[] nomesAlunos = new string[numeroAlunos];
            double[,] notasAlunos = new double[numeroAlunos, numeroBimestres];
            double[] medias = new double[numeroAlunos];

      
            // Preenchendo as notas dos alunos
            for (int i = 0; i < numeroAlunos; i++){
                  Console.WriteLine($"Digite o nome do Aluno {i + 1}:");
                  nomesAlunos[i] = Console.ReadLine();
                  Console.WriteLine($"Aluno {nomesAlunos[i]}");
                
                 for (int j = 0; j < numeroBimestres; j++){
                    Console.Write($"Digite a nota do {j + 1}º bimestre: ");
                    double nota;
                    while (!double.TryParse(Console.ReadLine(), out nota)|| nota < 0 || nota > 10){
                      Console.WriteLine("Por favor, digite uma nota válida entre 0 e 10.");
                      Console.Write($"Digite a nota do {j + 1}º bimestre: ");
                    }
                       notasAlunos[i, j] = nota;
                }
                   Console.WriteLine();
            }

            // Calculando as médias dos alunos
            for (int i = 0; i < numeroAlunos; i++){
                double somaNotas = 0;
                for (int j = 0; j < numeroBimestres; j++){
                    somaNotas += notasAlunos[i, j];
                }
                medias[i] = somaNotas / numeroBimestres;
            }

            // Exibindo as médias dos alunos
            Console.WriteLine("Médias dos alunos:");
            for (int i = 0; i < numeroAlunos; i++)
            {
                Console.WriteLine($"Aluno {nomesAlunos[i]}: Média = {medias[i]:F2}");
            }
        }
    }
  