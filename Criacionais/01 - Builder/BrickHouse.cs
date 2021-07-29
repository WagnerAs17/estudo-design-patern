namespace Estrutura_Dados.Criacionais._01___Builder
{
    public class BrickHouse
    {
        public int Door { get; private set; }
        public int Roof { get; private set; }
        public int Wall { get; private set; }
        public int Window { get; private set; }
        public bool Garage { get; private set; }

        public BrickHouse(int door, int roof, int wall, int window, bool garage, int teste, int teste2)
        {
            Door = door;
            Roof = roof;
            Wall = wall;
            Window = window;
            Garage = garage;
        }

        public override string ToString()
        {
            var hasGarage = Garage ? "Yes" : "No";

            return $"Brick House\n " +
                $"Door: {Door} - Roof: {Roof} - " +
                $"Wall: {Wall} - Window: {Window} - Has garage ? {hasGarage}";
        }
    }
}
