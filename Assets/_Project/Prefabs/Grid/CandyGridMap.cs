using UnityEngine;
using MatchThree.Items;
using MatchThree.Core;
using System;

namespace MatchThree.Grid
{
    public class CandyGridMap : MonoBehaviour
    {
        [SerializeField] private Vector2i _gridCellArea;

        [SerializeField] private float _cellSizeInPixels;

        [SerializeField] private Vector2 _startCellPosition;

        [SerializeField] private Empty _emptyCellPrefab;
        [SerializeField] private Candy[] _candyTypes;

        [SerializeField] private TextAsset _gridTemplate;

        private int[,] _gridMap;

        private int _cellQuantity;
        private GridCell[] _cells;

        private void Start()
        {
            TranslateFileToGrid();
        }

        private void ResetMap()
        {
            _cellQuantity = 0;
            _gridMap = new int[_gridCellArea.X, _gridCellArea.Y];
        }

        private void TranslateFileToGrid()
        {
            ResetMap();

            string[] rows = _gridTemplate.text.Split(Environment.NewLine);

            for (int i = 0; i < _gridCellArea.X; i++) 
            {
                for (int j = 0; j < _gridCellArea.Y; j++)
                {
                    string[] items = rows[i].Split(" ");

                    try
                    {
                        int value = int.Parse(items[j]);

                        value = value < 0 ? 0 : value;
                        value = value > 1 ? 1 : value;

                        _gridMap[i, j] = value;
                    }
                    catch (ArgumentException)
                    {
                        Debug.LogError($"There was an error to read [{i}, {j}] while creating the grid template.");
                        _gridMap[i, j] = 0;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Debug.LogError($"The index has gone out of bounds of the array while creating the grid map.");
                    }
                }
            }

            foreach (int item in _gridMap)
            {
                if (item == 1) _cellQuantity++;
            }
        }

        private void InstantiateCells()
        {
            for (int i = 0; i < _gridCellArea.X; i++)
            {
                for (int j = 0; j < _gridCellArea.Y; j++)
                {
                    if (_gridMap[i, j] == 0) continue;

                    Instantiate<Empty>(_emptyCellPrefab, new Vector3(i * _cellSizeInPixels, j * _cellSizeInPixels, 0), Quaternion.identity);

                    _emptyCellPrefab.gridPosition = new Vector2i(i, j);
                }
            }
        }

        private void SetUpInitialBoard()
        {
            
        }
    }
}
