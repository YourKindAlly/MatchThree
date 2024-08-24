using MatchThree.Items;
using MatchThree.Core;

namespace MatchThree.Grid
{
    public class CandyCell
    {
        private float _cellSize;
        private Vector2i _cellPositionInGrid;
        private Candy _candyHeld;

        public CandyCell(float cellSize, Vector2i cellPositionInGrid, Candy candyHeld)
        {
            _cellSize = cellSize;
            _cellPositionInGrid = cellPositionInGrid;
            _candyHeld = candyHeld;
        }
    }
}
