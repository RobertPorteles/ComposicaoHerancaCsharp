namespace ComposicaoHerancaCsharp.Entities
{
    public class Pessoa
    {
        public Guid? Id{set; get;}
        public string? Name{set; get;}

        public string? Cpf{set; get;}

        public Endereco? Endereco{set; get;}
    }
}