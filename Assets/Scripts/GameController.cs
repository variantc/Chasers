﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    References references;

    private int mapHeight = 10;
    private int mapWidth = 10;
    public int MapHeight { get { return mapHeight; } }
    public int MapWidth { get { return mapWidth; } }

    public GameObject[,] map;

    void Awake()
    {
        references = FindObjectOfType<References>();
        if(references == null) { Debug.LogError("References not found"); }
    }
    
	void Start () {
        map = new GameObject[mapWidth, mapHeight];
        //BuildMap();
	}

    void BuildMap()
    {
        for (int i = 0; i < mapWidth; i++)
        {
            for (int j = 0; j < mapHeight; j++)
            {
                GameObject t = Instantiate(references.tilePrefab, new Vector3(-mapWidth / 2f + i + 0.5f, -mapHeight / 2f + j + 0.5f, 0f), Quaternion.identity);
                map[i, j] = t;
                t.transform.SetParent(references.mapContainer.transform);
                t.transform.name = ("Tile:" + i + "," + j);
            }
        }
    }
    
}
