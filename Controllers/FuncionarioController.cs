using System.ComponentModel.Design.Serialization;
using ComposicaoHerancaCsharp.Entities;
using ComposicaoHerancaCsharp.Persistencies;

namespace ComposicaoHerancaCsharp.Controllers
{
    public class FuncionarioController
    
    {
        FuncionarioRepositoryJson json = new FuncionarioRepositoryJson();
        FuncionarioRepositoryXml xml = new FuncionarioRepositoryXml();

        public void CadastrarFuncionario()
        {
            Console.WriteLine("CADASTRANDO FUNCIONARIO\n");

            var funcionario = new Funcionario();
            
            funcionario.Id = Guid.NewGuid();

            Console.WriteLine("\nCADASTRANDO CPF:\n");
            funcionario.Cpf = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Nome:\n");
            funcionario.Name = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Matricula:\n");
            funcionario.Matricula = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Salario:\n");
            funcionario.Salario =decimal.Parse(Console.ReadLine());

            funcionario.DataAdmicao = DateTime.Now;

            Console.WriteLine("\n___CADASTRANDO ENDERECO___\n");

            funcionario.Endereco = new Endereco();

            funcionario.Endereco.Id = Guid.NewGuid();

            Console.WriteLine("\nCADASTRANDO Logradouro:\n");
            funcionario.Endereco.Logradouro = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Bairro:\n");
            funcionario.Endereco.Bairro = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Cidade :\n");
            funcionario.Endereco.Cidade = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Estado:\n");
            funcionario.Endereco.Estado = Console.ReadLine();

            Console.WriteLine("\nCADASTRANDO Cep:\n");
            funcionario.Endereco.Cep = Console.ReadLine();


            json.ExportarDados(funcionario);
            xml.ExportarDados(funcionario);
        }
    }
}