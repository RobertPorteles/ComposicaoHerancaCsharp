namespace ComposicaoHerancaCsharp.Entities
{
    public class Endereco
    {
        public Guid? Id{set; get;}
        public string? Logradouro{set; get;}
        public string? Bairro{set; get;}
        public string? Cidade{set; get;}

        public string? Estado{set; get;}

        public string? Cep{set; get;}


    }
}