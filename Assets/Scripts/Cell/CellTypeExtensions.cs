using System;

namespace Kozlo.CellElements
{
    public static class CellTypeExtensions
    {
        public static int ToNumber(this CellType tileType)
        {
            switch (tileType)
            {
                case CellType.One:
                    return 1;
                case CellType.Two:
                    return 2;
                case CellType.Three:
                    return 3;
                case CellType.Four:
                    return 4;
                case CellType.Five:
                    return 5;
                case CellType.Six:
                    return 6;
                case CellType.Seven:
                    return 7;
                case CellType.Eight:
                    return 8;
                default:
                    throw new Exception("This is not number");
            }
        }

        public static bool IsNumber(this CellType tileType)
        {
            switch (tileType)
            {
                case CellType.One:
                    return true;
                case CellType.Two:
                    return true;
                case CellType.Three:
                    return true;
                case CellType.Four:
                    return true;
                case CellType.Five:
                    return true;
                case CellType.Six:
                    return true;
                case CellType.Seven:
                    return true;
                case CellType.Eight:
                    return true;
                default:
                    return false;
            }
        }
    }
}