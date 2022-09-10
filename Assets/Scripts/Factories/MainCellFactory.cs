using Kozlo.CellElements;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Kozlo.Factory
{
    [CreateAssetMenu(fileName = "MainCellFactory", menuName = "ScriptableObjects/MainCellFactory")]
    public class MainCellFactory : CellFactory
    {
        [SerializeField] private Tile empty;
        [SerializeField] private Tile mine;
        [SerializeField] private Tile unknown;
        [SerializeField] private Tile flag;
        [SerializeField] private Tile exploded;
        [SerializeField] private Tile one;
        [SerializeField] private Tile two;
        [SerializeField] private Tile three;
        [SerializeField] private Tile four;
        [SerializeField] private Tile five;
        [SerializeField] private Tile six;
        [SerializeField] private Tile seven;
        [SerializeField] private Tile eight;

        protected override Tile GetTile(CellType tileType)
        {
            switch (tileType)
            {
                case CellType.Empty:
                    return empty;
                case CellType.Mine:
                    return mine;
                case CellType.One:
                    return one;
                case CellType.Two:
                    return two;
                case CellType.Three:
                    return three;
                case CellType.Four:
                    return four;
                case CellType.Five:
                    return five;
                case CellType.Six:
                    return six;
                case CellType.Seven:
                    return seven;
                case CellType.Eight:
                    return eight;
                case CellType.Unknown:
                    return unknown;
                case CellType.Flag:
                    return flag;
                case CellType.Exploded:
                    return exploded;
                default:
                    throw new Exception("No tile for this type");
            }
        }
    }
}