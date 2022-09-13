using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private int mines = 1;
    [SerializeField, Range(2,16)] private int rows = 5;
    [SerializeField, Range(2, 16)] private int columns = 5;
    [SerializeField] private GameBoard board;

    private void Start()
    {
        board.InitializeBoard(cells);
    }
}
