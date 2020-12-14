using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    References references;

    private int mapHeight = 10;
    private int mapWidth = 10;
    public int MapHeight { get { return mapHeight; } }
    public int MapWidth { get { return mapWidth; } }

    void Awake()
    {
        references = FindObjectOfType<References>();
        if(references == null) { Debug.LogError("References not found"); }
    }
    
	void Start () {
        BuildMap();
	}

    void BuildMap()
    {
        for (int i = 0; i < mapWidth; i++)
        {
            for (int j = 0; j < mapHeight; j++)
            {
                GameObject t = Instantiate(references.tilePrefab, new Vector3(-mapWidth / 2f + i + 0.5f, -mapHeight / 2f + j + 0.5f, 0f), Quaternion.identity);
                t.transform.SetParent(references.map.transform);
                t.transform.name = ("Tile:" + i + "," + j);
            }
        }
    }

    public GameObject ObjectAt(Vector3 pos)
    {
        GameObject GO = new GameObject() ;
        if (Physics.Raycast(new Vector3(pos.x, pos.y, -1), new Vector3(0, 0, 1)))
            Debug.Log("wokr");
        return GO;
    }
}
