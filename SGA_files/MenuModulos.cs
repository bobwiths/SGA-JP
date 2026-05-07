using System.Dynamic;

public class MenuModulos
{
    CadastroAluno cadastroAluno = new CadastroAluno();
    ListagemAlunos listagemAlunos = new ListagemAlunos();
    AlteracaoCadastroAluno alteracaoCadastroAluno = new AlteracaoCadastroAluno();
    ExclusaoAluno exclusaoAluno = new ExclusaoAluno();
    public void ModulosSistema()
    {
        Console.Clear();
        int escolhaModulo;
        do
        {
            Console.WriteLine("--- Sistema de Gestao de Alunos - SGA ---");
            Console.WriteLine("\nDigite: \n1 - Cadastro de novos alunos \n2 - Listagem dos alunos cadastrados \n3 - Alteração cadastral dos alunos \n4 - Exclusão de alunos \n0 - Sair do Sistema");
            escolhaModulo = Convert.ToInt32(Console.ReadLine());
            quebraLinha();
            switch (escolhaModulo)
            {
                case 1:
                quebraLinha();
                cadastroAluno.CadastrandoNovoAluno();
                quebraLinha();
                break;

                case 2:
                quebraLinha();
                listagemAlunos.ListandoAlunos();
                quebraLinha();
                break;

                case 3:
                quebraLinha();
                alteracaoCadastroAluno.AlterandoCadastroAluno();
                quebraLinha();
                break;

                case 4:
                quebraLinha();
                exclusaoAluno.ExcluindoAluno();
                quebraLinha();
                break;
            }
            
            
        }while(escolhaModulo != 0);
    }
    public void quebraLinha(){
        Console.WriteLine(" ");
    }
}

