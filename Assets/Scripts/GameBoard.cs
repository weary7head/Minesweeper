using Kozlo.CellElements;
using Kozlo.Factory;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private CellFactory cellFactory;
    private Cell[,] cells;
    private MinesweeperSettings minesweeperSettings;

    public void InitializeBoard(MinesweeperSettings settings)
    {
        cells = new Cell[settings.Rows, settings.Columns];
        minesweeperSettings = settings;
        GenerateCells();
        GenerateMines();
        GenerateNumberCells();
        SetCells();
    }

    private void SetCells()
    {
        for (int i = 0; i < minesweeperSettings.Rows; i++)
        {
            for (int j = 0; j < minesweeperSettings.Columns; j++)
            {
                Cell cell = cells[i, j];
                tilemap.SetTile(cell.Position, cellFactory.Get(cell.Appearance));
            }
        }
    }

    private void GenerateCells()
    {
        for (int i = 0; i < minesweeperSettings.Rows; i++)
        {
            for (int j = 0; j < minesweeperSettings.Columns; j++)
            {
                Cell cell = new Cell(CellAppearance.Unknown, new Vector3Int(i, j), CellType.Empty, CellState.Unknowned);
                cells[i, j] = cell;
            }
        }
    }

    private void GenerateMines()
    {
        for (int i = 0; i < minesweeperSettings.Mines; i++)
        {
            cells[Random.Range(0, minesweeperSettings.Rows), Random.Range(0, minesweeperSettings.Columns)].ChangeTypeToMine();
        }
    }

    private void GenerateNumberCells()
    {
        foreach (var cell in cells)
        {
            if (cell.Type != CellType.Mine)
            {
                int minesCount = GetMinesCountAroundCell(cell.Position.x, cell.Position.y);
                cell.ChangeTypeToNumber(minesCount);
            }
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