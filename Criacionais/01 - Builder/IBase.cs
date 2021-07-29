namespace Estrutura_Dados.Criacionais._01___Builder
{
    public interface IBase
    {
        void BuildWalls(int walls);
        void BuildDoors(int doors);
        void BuildWindows(int windows);
        void BuildRoof(int roof);
        object GetResult();
    }
}
