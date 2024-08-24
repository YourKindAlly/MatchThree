using System.Collections.Generic;

namespace MatchThree.Core
{
    [System.Serializable]
    public class Cell
    {
        public bool available;
    }

    [System.Serializable]
    public class Array
    {
        public List<Cell> cells = new();
        public Cell this[int index] => cells[index];
    }

    [System.Serializable]
    public class GridArray
    {
        public List<Array> arrays = new();
        public Cell this[int x, int y] => arrays[x][y];
    }
}
