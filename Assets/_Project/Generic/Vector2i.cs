namespace MatchThree.Core
{
    [System.Serializable]
    public class Vector2i
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
    
        public Vector2i()
        {
            X = 0;
            Y = 0; 
        }

        public Vector2i(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
