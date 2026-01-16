using ComposicaoHerancaCsharp.Entities;

namespace ComposicaoHerancaCsharp.interfaces
{
    public interface IFuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario);
    } 
}