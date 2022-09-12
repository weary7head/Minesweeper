using Kozlo.CellElements;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private int mines = 1;
    [SerializeField, Range(2,16)] private int rows = 5;
    [SerializeField, Range(2, 16)] private int columns = 5;
    [SerializeField] private GameBoard board;
    private Cell[,] cells;

    private void Start()
    {
        GenerateCells();
        GenerateMines();
        board.InitializeBoard(cells);
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
}
