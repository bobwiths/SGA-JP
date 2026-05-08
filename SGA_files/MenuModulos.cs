using System.Dynamic;

public class MenuModulos
{
    // CadastroAluno cadastroAluno = new CadastroAluno();
    // ListagemAlunos listagemAlunos = new ListagemAlunos();
    // AlteracaoCadastroAluno alteracaoCadastroAluno = new AlteracaoCadastroAluno();
    // ExclusaoAluno exclusaoAluno = new ExclusaoAluno();
    AlunoService alunoService = new AlunoService();
    public void ModulosSistema()
    {
        Console.Clear();
        int escolhaModulo;
        do
        {
            Console.WriteLine("--- Sistema de Gestao de Alunos - SGA ---");
            Console.WriteLine("\nDigite: \n\n1 - Cadastro de novos alunos \n2 - Listagem dos alunos cadastrados \n3 - Alteração cadastral dos alunos \n4 - Exclusão de alunos \n0 - Sair do Sistema");
            escolhaModulo = Convert.ToInt32(Console.ReadLine());
            quebraLinha();
            switch (escolhaModulo)
            {
                case 1:
                quebraLinha();
                alunoService.CadastrarAluno();
                quebraLinha();
                break;

                case 2:
                quebraLinha();
                alunoService.ListarAlunos();
                quebraLinha();
                break;

                case 3:
                quebraLinha();
                alunoService.AlterarAluno();
                quebraLinha();
                break;

                case 4:
                quebraLinha();
                alunoService.RemoverAluno();
                quebraLinha();
                break;
            }
            
            
        }while(escolhaModulo != 0);
    }
    public void quebraLinha(){
        Console.WriteLine(" ");
    }
}

