using UnityEngine;
using System.Collections.Generic;
using MatchTree.Items;

namespace MatchThree.Core
{
    public class CandyGridMap : MonoBehaviour
    {
        private int[,] _gridCells;

        [SerializeField]
        private int _cellRowsAndColumns = 10;

        [SerializeField]
        private List<Candy> _candyTypes = new();

        private void Start()
        {
            _gridCells = new int[_cellRowsAndColumns, _cellRowsAndColumns];
        }
    }
}
