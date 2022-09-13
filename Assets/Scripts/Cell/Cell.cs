using UnityEngine;

namespace Kozlo.CellElements
{
    public class Cell
    {
        public CellAppearance Appearance { get; private set; }
        public Vector3Int Position { get; private set; }
        public CellType Type { get; private set; }
        public CellState State { get; private set; }

        public Cell(CellAppearance appearance, Vector3Int position, CellType type, CellState state)
        {
            Appearance = appearance;
            Position = position;
            Type = type;
            State = state;
        }

        public void ChangeTypeToMine()
        {
            Type = CellType.Mine;
            Appearance = CellAppearance.Mine;
        }

        public void ChangeTypeToNumber(int minesCount)
        {
            switch (minesCount)
            {
                case 1:
                    Type = CellType.One;
                    break;
                case 2:
                    Type = CellType.Two;
                    break;
                case 3:
                    Type = CellType.Three;
                    break;
                case 4:
                    Type = CellType.Four;
                    break;
                case 5:
                    Type = CellType.Five;
                    break;
                case 6:
                    Type = CellType.Six;
                    break;
                case 7:
                    Type = CellType.Seven;
                    break;
                case 8:
                    Type = CellType.Eight;
                    break;
                default:
                    Type = CellType.Empty;
                    break;
            }
        }
    }
}