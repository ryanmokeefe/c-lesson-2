namespace TreehouseDefense 
{
    // subclass
    class MapLocation : Point
    {
        // call the MapLocation class(params) : Point class(params) constructor
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                // throw an exception
                throw new OutOfBoundsException(x + " , " + y + " is not on the map");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }

    }

}
