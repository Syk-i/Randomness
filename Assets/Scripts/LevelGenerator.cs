using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {
    public GameObject[] tiles;
    public GameObject wall;

    public List<Vector3> createdTiles;

    public int tileAmount;
    public int tileSize; //space between each movement of the generator which will be 16 units

	void Start () {
        StartCoroutine(GenerateLevel());
		
	}

    IEnumerator GenerateLevel() //used for debugging
    {
        yield return 0;
    }	
}
