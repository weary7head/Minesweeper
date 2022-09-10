using UnityEngine;

namespace Kozlo.CellElements
{
    public class Cell : MonoBehaviour
    {
        private CellAppearance appearance = CellAppearance.Unknown;
        private CellType type;
        private CellState state = CellState.Unknowned;
    }
}