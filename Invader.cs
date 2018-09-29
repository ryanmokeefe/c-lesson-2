
namespace TreehouseDefense 
{
    class Invader 
    {
        // make fields private, and accessor methods public
        // private MapLocation Location;
        
        // // getter accessor METHOD
        //     public MapLocation GetLocation()
        //     {
        //         return _location;
        //     }

        //     // setter accessor METHOD // use void when not returning data
        //     public void SetLocation(MapLocation value)
        //     {
        //         _location = value;
        //     }

        // // using PROPERTIES (same as above)
        //     public MapLocation Location
        //     {
        //         get 
        //         {
        //             return _location    
        //         }
        //         // private set {} - only other classes of invader class can access:
        //          set 
        //         {
        //             _location = value
        //         }
        //     }


            //store instance of path
            private readonly Path _path;
            // initialize invader start point
            private int _pathStep = 0;
            
            // same as above: ( AUTO PROPERTY ) (would delete the main entry field so it doesn't have a backing field)
            public MapLocation Location => _path.GetLocationAt(_pathStep);
            
            // method to move the invader
            public void Move() => _pathStep += 1;

            // HEALTH:

            public int Health { get; private set; } = 2;
            
            public void DecreaseHealth(int factor)
            {
                Health -= factor;
            }

            // true if the invader reaches end of path
            public bool HasScored { get { return _pathStep >= _path.Length; } }

            public bool IsNeutralized => return Health <= 0; 

            public bool IsActive => !(IsNeutralized || HasScored);

            public Invader(Path path)
            {
                _path = path;
            }


    }

}
