namespace ComposicaoHerancaCsharp.Entities
{
    
    public class Funcionario : Pessoa
    {
        public string? Matricula{set; get;}
        public DateTime? DataAdmicao{set; get;}

        public Decimal? Salario{set; get;}
    }
}