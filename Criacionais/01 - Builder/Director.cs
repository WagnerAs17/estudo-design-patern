namespace Estrutura_Dados.Criacionais._01___Builder
{
    public class Director
    {
        public Director()
        {
        }

        public object MakeWoodHouse(IBase builder)
        {
            builder.BuildWalls(4);
            builder.BuildRoof(1);
            builder.BuildWindows(2);
            builder.BuildDoors(1);

            return builder.GetResult();
        }

        public object MakeBrickHouse(IBuilder builder)
        {
            builder.BuildWalls(4);
            builder.BuildRoof(1);
            builder.BuildWindows(3);
            builder.BuildDoors(2);
            builder.BuildGarage();

            return builder.GetResult();
        }

        public object MakeBrickHouse2(IBuilder builder)
        {
            builder.BuildWalls(20);
            builder.BuildRoof(12);
            builder.BuildWindows(233);
            builder.BuildDoors(343434);
            builder.BuildGarage();

            return builder.GetResult();
        }

    }
}
