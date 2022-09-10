using Kozlo.Factory;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private CellFactory cellFactory;
}