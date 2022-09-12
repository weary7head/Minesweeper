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
        }
    }
}