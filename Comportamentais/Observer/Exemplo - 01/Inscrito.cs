namespace Estrutura_Dados.Comportamentais.Observer.Exemplo___01
{
    public class Inscrito
    {
        public string Nome { get; set; }

        public Inscrito(string nome)
        {
            Nome = nome;
        }
        public override string ToString()
        {
            return $"Inscrito: {Nome}";
        }

        public override bool Equals(object obj)
        {
            var inscrito = (Inscrito)obj;

            return inscrito.Nome.Equals(Nome);
        }
    }
}
