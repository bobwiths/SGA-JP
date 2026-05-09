using System.Dynamic;

public class MenuModulos
{
    // Criando o "chamado" dos objetos para utilizar na listagem do switch
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
            //Pensei em fazer um WriteLine para cada módulo, porém menos linhas é melhor?
            // Havia pensado em criar variáveis para que a manutenção futura do código seja mais fácil, tipo chama o WriteLine(codigo1) e ele é uma string codigo1 = "1 - Cadastro de novos alunos"
            // Porém decidi pelo "alívio de peso" e deixar tudo em uma linha
            Console.WriteLine("--- Sistema de Gestao de Alunos - SGA ---");
            Console.WriteLine("\nDigite: \n\n1 - Cadastro de novos alunos \n2 - Listagem dos alunos cadastrados \n3 - Alteração cadastral dos alunos \n4 - Exclusão de alunos \n0 - Sair do Sistema");
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
    // Não é possível que eu tenha que fazer isso sempre pra quebrar a linha antes e depois. Não achei um comando mais fácil que fazer isso (ainda).
    public void quebraLinha(){
        Console.WriteLine(" ");
    }
}

