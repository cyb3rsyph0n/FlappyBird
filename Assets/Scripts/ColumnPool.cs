using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

public class ColumnPool : MonoBehaviour
{
    public int PoolSize = 5;

    public GameObject PreFabColumn;
    private List<GameObject> columnPool;

    private float timeSinceLastColumn = 0;

    private int currentColumn = 0;

    public float ColMin = -2;
    public float ColMax = 5;

    // Use this for initialization
    void Awake ()
	{
	    columnPool = new List<GameObject>();
        Vector2 offScreen = new Vector2(-20, -20);

		for(int i=0; i < PoolSize; i++)
		{
		    columnPool.Add((GameObject) Instantiate(PreFabColumn, offScreen, Quaternion.identity));
	    }
	}
	
	// Update is called once per frame
	void Update ()
	{
	    timeSinceLastColumn += Time.deltaTime;

	    if (!GameController.Instance.IsGameOver&& timeSinceLastColumn > GameController.Instance.ColumnTiming)
	    {
	        timeSinceLastColumn = 0;

	        columnPool[currentColumn].transform.position = new Vector2(10, Random.Range(ColMin, ColMax));
	        currentColumn++;

	        if (currentColumn >= PoolSize) currentColumn = 0;
	    }
	}
}
