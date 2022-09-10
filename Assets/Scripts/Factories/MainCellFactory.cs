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

        protected override Tile GetTile(CellAppearance tileType)
        {
            switch (tileType)
            {
                case CellAppearance.Empty:
                    return empty;
                case CellAppearance.Mine:
                    return mine;
                case CellAppearance.One:
                    return one;
                case CellAppearance.Two:
                    return two;
                case CellAppearance.Three:
                    return three;
                case CellAppearance.Four:
                    return four;
                case CellAppearance.Five:
                    return five;
                case CellAppearance.Six:
                    return six;
                case CellAppearance.Seven:
                    return seven;
                case CellAppearance.Eight:
                    return eight;
                case CellAppearance.Unknown:
                    return unknown;
                case CellAppearance.Flag:
                    return flag;
                case CellAppearance.Exploded:
                    return exploded;
                default:
                    throw new Exception("No tile for this type");
            }
        }
    }
}