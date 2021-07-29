using System;

namespace Estrutura_Dados.Criacionais._01___Builder
{
    public class BrickHouseBuilder : IBuilder
    {
        private BrickHouse _brickHouse { get; set; }
        private int _wall;
        private int _door;
        private int _roof;
        private int _window;
        private bool _garage;

        public void BuildGarage()
        {
            var numero = new Random().Next(0, 100);

            _garage = numero % 2 == 0;
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
            return _brickHouse = new BrickHouse(_door, _roof, _wall, _window, _garage);
        }
    }
}
