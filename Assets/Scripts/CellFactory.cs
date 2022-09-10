using UnityEngine;
using UnityEngine.Tilemaps;

namespace Kozlo
{
    public abstract class CellFactory : ScriptableObject
    {
        public Tile Get(CellType tileType)
        {
            return GetTile(tileType);
        }

        protected abstract Tile GetTile(CellType tileType);
    }
}