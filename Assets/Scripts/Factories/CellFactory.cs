using Kozlo.CellElements;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Kozlo.Factory
{
    public abstract class CellFactory : ScriptableObject
    {
        public Tile Get(CellAppearance tileType)
        {
            return GetTile(tileType);
        }

        protected abstract Tile GetTile(CellAppearance tileType);
    }
}