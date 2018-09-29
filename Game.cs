
namespace TreehouseDefense 
{
    class Game 
    {
        public void Main(8, 5)
        {
            // create Type(Tower) obj = new Tower obj(instance)
            Tower tower = new Tower();
            Map map = new Map();
            MapLocation x = new MapLocation(4, 2);

            map.OnMap(new MapLocation(0, 0));
            
            Console.WriteLine(x.DistanceTo(5, 5));


            // instantiate a new mapLocation, with catch
            try 
            {
                // create path for player to move down
                Path path = new Path( 
                    new [] {
                        new MapLocation(0, 2, map);
                        new MapLocation(1, 2, map);
                        new MapLocation(2, 2, map);
                        new MapLocation(3, 2, map);
                        new MapLocation(4, 2, map);
                        new MapLocation(5, 2, map);
                        new MapLocation(6, 2, map);
                        new MapLocation(7, 2, map);
                        new MapLocation(8, 2, map);
                    }
                );

                Invader[] invaders = {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers = {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map)),

                };

                Level level = new Level(invaders) 
                {
                    Towers = towers;
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));

            }

            // list exceptions most specific - most general
            catch(OutOfBoundsException.ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException.ex) 
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            // ex refers to the exception being passed in
            catch(Exception ex) 
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    
    }


}
