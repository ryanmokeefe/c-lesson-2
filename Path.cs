
namespace TreehouseDefense 
{
    class Path 
    {
        // _path differentiates from instance vars and method vars
            // _ only for private fields
        private readonly MapLocation[] _path;

        public int Length => _path.Length;


            // this passes in a path
        public Path(MapLocation[] path) 
        {
            _path = path;
            // return location
            public MapLocation GetLocation(int pathStep)
            {
                return (pathStep < _path.length) ? _path[pathStep] : null;
            }
        }
        
    }

}
