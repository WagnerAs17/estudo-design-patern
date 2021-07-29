namespace Estrutura_Dados.Criacionais._01___Builder
{
    public class WoodHouse
    {
        public int Door { get; private set; }
        public int Roof { get; private set; }
        public int Wall { get; private set; }
        public int Window { get; private set; }

        public WoodHouse(int door, int roof, int wall, int window)
        {
            Door = door;
            Roof = roof;
            Wall = wall;
            Window = window;
        }

        public override string ToString()
        {
            return $"Wood House\n Door: {Door} - Roof: {Roof} - Wall: {Wall} - Window: {Window}";
        }
    }
}
