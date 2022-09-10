using Kozlo.CellElements;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Kozlo.Factory
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