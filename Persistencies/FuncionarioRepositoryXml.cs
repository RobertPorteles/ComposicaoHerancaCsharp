using System.Xml.Serialization;
using ComposicaoHerancaCsharp.Entities;
using ComposicaoHerancaCsharp.interfaces;

namespace ComposicaoHerancaCsharp.Persistencies
{
    public class FuncionarioRepositoryXml : IFuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var xml = new XmlSerializer(typeof(Funcionario));

            var streamWriter = new StreamWriter("/home/robertporteles/export.xml");

            xml.Serialize(streamWriter, funcionario);

            streamWriter.Close();
        }
    }
}