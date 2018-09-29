namespace TreehouseDefense {

    class Level 
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        // returns true if the player wins, false otherwise:

        public bool Play()
        {
            // level will run until all invaders are neutralized OR invader reaches end of path
                // loop to keep track of how many invaders are remaining:
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0) {

            // Each Tower has opportunity to fire on invaders
                // loop through Towers to fire on invaders
            foreach(Tower tower in Towers) {
                tower.FireOnInvaders(_invaders);
            }

            // Count and move invaders that are still active
            remainingInvaders = 0
            foreach(Invader invader in _invaders){
                if(invader.IsActive) {
                    invader.Move();
                    if (invader.HasScored) {
                        return false;
                    }
                    remainingInvaders++;
                } 
            }
            }
        }
    }
}
