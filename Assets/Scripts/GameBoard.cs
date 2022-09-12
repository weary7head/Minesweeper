using Kozlo.CellElements;
using Kozlo.Factory;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private CellFactory cellFactory;

    public void InitializeBoard(Cell[,] cells)
    {
        int height = cells.GetLength(0);
        int width = cells.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Cell cell = cells[i, j];
                tilemap.SetTile(cell.Position, cellFactory.Get(cell.Appearance));
            }
        }
    }
}