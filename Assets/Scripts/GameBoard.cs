using Kozlo.CellElements;
using Kozlo.Factory;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private CellFactory cellFactory;
    private Cell[,] cells;

    public void InitializeBoard(int rows, int columns, int minesCount)
    {
        cells = new Cell[rows, columns];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Cell cell = cells[i, j];
                tilemap.SetTile(cell.Position, cellFactory.Get(cell.Appearance));
            }
        }
    }

    private void GenerateCells()
    {
        cells = new Cell[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Cell cell = new Cell(CellAppearance.Unknown, new Vector3Int(i, j), CellType.Empty, CellState.Unknowned);
                cells[i, j] = cell;
            }
        }
    }

    private void GenerateMines()
    {
        for (int i = 0; i < mines; i++)
        {
            cells[Random.Range(0, rows), Random.Range(0, columns)].ChangeTypeToMine();
        }
    }

    private int GetMinesCountAroundCell(int i, int j)
    {
        int mines = 0;
        for (int x = -1; x <= 1; x++)
        {
            for (int y = -1; y <= 1; y++)
            {
                if (x + i >= 0 && x + i < cells.GetLength(0) && y + j >= 0 && y + j < cells.GetLength(1))
                {
                    if (cells[x + i, y + j].Type == CellType.Mine)
                    {
                        mines++;
                    }
                }
            }
        }
        return mines;
    }
}