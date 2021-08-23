namespace Constructors
{
    public class Building
    {
        private int _floor;
        private int _size;

        public Building(int floor, int size)
        {
          _floor = floor;
          _size = size;
        }

        public Building(int floor)
        {
          _floor = floor;
        }

        public int GetSize()
        {
          return _floor * 3;
        }

        public int GetFloorCount()
        {
          return _floor;
        }

        public int GetFloorMaxSize()
        {
          return _size / _floor;
        }
    }
}