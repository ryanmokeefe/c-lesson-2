namespace TreehouseDefense 
{
    // creating a new custom Exception
    class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException() 
        {
            
        }
        public TreehouseDefenseException(string message) : base(message)
    {
        
    }
    }
    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
