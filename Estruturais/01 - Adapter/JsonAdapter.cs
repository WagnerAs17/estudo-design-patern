using Newtonsoft.Json;
using System.Xml;

namespace Estrutura_Dados.Estruturais
{
    public class JsonAdapter : IClient
    {
        public JsonAdapter(Json json)
        {
            Json = json;
        }

        public Json Json { get; set; }
        public string Criar(object data)
        {
            var xml = (string)data;

            var doc = new XmlDocument();

            doc.LoadXml(xml);

            var json = JsonConvert.SerializeXmlNode(doc);

            return Json.Criar(json);
        }
    }
}
