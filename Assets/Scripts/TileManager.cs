using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{

    public GameObject[,] grid;

    public Transform gridStartPosition;

    private float tileSize = 1.0f;

    public GameObject blankTilePrefab;

    private int GridRowSize;
    private int GridColumnSize;


    // Start is called before the first frame update
    void Start()
    { 
        GenerateBlankBoard(32, 32);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateBlankBoard(int rows, int columns)
    {
        GridRowSize = rows;
        GridColumnSize = columns;

        grid = new GameObject[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                float posY = (gridStartPosition.position.z) - row * tileSize;
                float posX = (gridStartPosition.position.x) + column * tileSize;

                grid[row, column] = SpawnBlankTile(row, column, posX, posY);
            }
        }
    }

    private GameObject SpawnBlankTile(int row, int column, float posX, float posY)
    {
        GameObject blankTile = Instantiate(blankTilePrefab, new Vector3(posX, 0.0f, posY), Quaternion.identity);

        Tile blankT = blankTile.GetComponent<Tile>();

        blankT.SetTileLocation(row, column);
        blankT.SetTileType(TileType.BLANK);
        blankTile.transform.parent = gameObject.transform;
        return blankTile;
    }
}
