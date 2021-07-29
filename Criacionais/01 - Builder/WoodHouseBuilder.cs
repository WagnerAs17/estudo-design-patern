namespace Estrutura_Dados.Criacionais._01___Builder
{
    public class WoodHouseBuilder : IBase
    {
        private WoodHouse _woodHouse { get; set; }
        private int _wall;
        private int _door;
        private int _roof;
        private int _window;

        public WoodHouseBuilder()
        {  
        }

        public void BuildDoors(int door)
        {
            _door = door;
        }

        public void BuildRoof(int roof)
        {
            _roof = roof;
        }

        public void BuildWalls(int wall)
        {
            _wall = wall;
        }

        public void BuildWindows(int window)
        {
            _window = window;
        }

        public object GetResult()
        {
            return _woodHouse = new WoodHouse(_door, _roof, _wall, _window);
        }
    }
}
