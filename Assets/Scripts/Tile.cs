using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    NONE,
    BLANK,
    ROAD,
    RESOURCE,
    ENEMY,
    TOWER,
    BORDER
}

public class Tile : MonoBehaviour
{
    public TileType tileType;

    public GameObject tileItem;

    //Tile Location 
    private int row;
    private int column;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void SetTileType(TileType _tileType)
    {
        tileType = _tileType;
    }    

    public Vector2 GetLocation()
    {
        return new Vector2(row, column);
    }

    public void SetTileLocation(int _row, int _column)
    {
        row = _row;
        column = _column;
    }
}
