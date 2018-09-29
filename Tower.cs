
namespace TreehouseDefense 
{
    class Tower 
    {
        private const int _range = 1;
        private const int _power = 1;

        private const double _accuracy = .75;


        // initialize a random number, accessible by all decendents of Tower class
        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        // constructor
        public Tower(MapLocation location)
        {
            // validate location (same as MapLocation class)

            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            // for (int i = 0; i < indavers.Length; i++) {
            //     // do stuff w/invader


            // }

            foreach(Invader invader in invaders)
            {
                // do stuff w/invader
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range)) {
                    
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot and hit invader!")
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized!")
                        }
                    
                    } 
                    else 
                    {
                        Console.WriteLine("Shot and missed invader!")

                    }
                    break;
                }

            }
        }


    }

}
