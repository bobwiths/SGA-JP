class AlunoService
{
    private List<Aluno> alunos = new List<Aluno>();
 
 
    public void CadastrarAluno()
    {
        Aluno aluno = new Aluno();
 
        Console.Write("\nDigite o ID do aluno: ");
        aluno.Id = int.Parse(Console.ReadLine()!);
 
        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine()!;
 
        Console.Write("Digite a idade do aluno: ");
        aluno.Idade = int.Parse(Console.ReadLine()!);
 
        Console.Write("Digite o CPF do aluno: ");
        aluno.CPF = Convert.ToDouble(Console.ReadLine());
 
        alunos.Add(aluno);
 
        Console.WriteLine("\nAluno cadastrado com sucesso!");
    }
 
 
    public void ListarAlunos()
    {
        Console.WriteLine("\n===== LISTA DE ALUNOS =====");
 
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }
 
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"\nID: {aluno.Id}");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"CPF: {aluno.CPF}");
        }
    }
 
 
    public void AlterarAluno()
    {
        Console.Write("\nDigite o ID do aluno que deseja alterar: ");
        int idBusca = int.Parse(Console.ReadLine()!);
 
        Aluno alunoEncontrado = null!;
 
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Id == idBusca)
            {
                alunoEncontrado = aluno;
                break;
            }
        }
 
        if (alunoEncontrado == null)
        {
            Console.WriteLine("\nAluno não encontrado.");
            return;
        }
 
        Console.WriteLine("\n===== ALTERAÇÃO CADASTRAL =====");
 
        Console.Write("Novo nome: ");
        alunoEncontrado.Nome = Console.ReadLine()!;
 
        Console.Write("Nova idade: ");
        alunoEncontrado.Idade = int.Parse(Console.ReadLine()!);
 
        Console.Write("Novo CPF: ");
        alunoEncontrado.CPF = Convert.ToDouble(Console.ReadLine());
 
        Console.WriteLine("\nCadastro alterado com sucesso!");
    }
 
 
    public void RemoverAluno()
    {
        Console.Write("\nDigite o ID do aluno que deseja remover: ");
        int idBusca = int.Parse(Console.ReadLine()!);
 
        Aluno alunoEncontrado = null!;
 
        foreach (Aluno aluno in alunos)
        {
            if (aluno.Id == idBusca)
            {
                alunoEncontrado = aluno;
                break;
            }
        }
 
        if (alunoEncontrado == null)
        {
            Console.WriteLine("\nAluno não encontrado.");
            return;
        }
 
        alunos.Remove(alunoEncontrado);
 
        Console.WriteLine("\nAluno removido com sucesso!");
    }
}