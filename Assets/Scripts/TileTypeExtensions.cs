﻿public static class TileTypeExtensions
{
    public static int ToNumber(this TileType tileType)
    {
        switch (tileType)
        {
            case TileType.One:
                return 1;
            case TileType.Two:
                return 2;
            case TileType.Three:
                return 3;
            case TileType.Four:
                return 4;
            case TileType.Five:
                return 5;
            case TileType.Six:
                return 6;
            case TileType.Seven:
                return 7;
            case TileType.Eight:
                return 8;
            default:
                throw new System.Exception("This is not number");
        }
    }
}