class Aluno
{
    //string.Empty, segundo a documentação do C# é para não ficar com o erro de nulo com o sublinhado amarelo
    public string Nome{get; set;} = string.Empty;
    public int Idade{get; set;}
    public double CPF{get; set;}
    public string Endereco{get; set;} = string.Empty;
}