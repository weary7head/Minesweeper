public struct MinesweeperSettings
{
    public int Rows { get; private set; }
    public int Columns { get; private set; }
    public int Mines { get; private set; }

    public MinesweeperSettings(int rows, int colums, int mines)
    {
        Rows = rows;
        Columns = colums;
        Mines = mines;
    }
}
