
namespace TreehouseDefense 
{
    class Map 
    {

        // attributes: width & height
        public readonly int Height;
        public readonly int Width;

        // construcor method
        public Map(int width, int height) 
        {   
            Width = width;
            Height = Height;
        }

        // on map to return: true if point is on the map, false if not
            // (point is of type Point)
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X <= Width 
                  && point.Y >= 0 && point.Y <= Height;
            
        }
    }

}
