using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using ComposicaoHerancaCsharp.Entities;
using ComposicaoHerancaCsharp.interfaces;


namespace ComposicaoHerancaCsharp.Persistencies
{

    public class FuncionarioRepositoryJson : IFuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            
var json = JsonSerializer.Serialize(
    funcionario,
    new JsonSerializerOptions { WriteIndented = true }
);

File.WriteAllText("/home/robertporteles/export.json", json);
        }
    }}
