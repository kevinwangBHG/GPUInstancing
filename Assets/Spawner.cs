using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefab;
    public int count = 100;
    // Use this for initialization
    void Start () 
    {
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                var instance = Instantiate(prefab) as GameObject;
                instance.transform.position = GetRandomPosition(i, j, count);
                instance.transform.localScale = GetRandomScale();
            }
        }
	}
	

    private Vector3 GetRandomScale()
    {
        float scale = Random.Range(1.2f, 2f);
        return new Vector3(scale, scale, scale);
    }

    private Vector3 GetRandomPosition(int i, int j, int maxX)
    {
        float scale = 1;
        float yOffset = 2;
        return new Vector3( i + Random.Range(-scale, scale) - maxX/2,
                            j + Random.Range(-scale, scale) + yOffset,
                            Random.Range(-scale, scale));
    }

	// Update is called once per frame
	void Update () {
		
	}

/*
 97  238  -227
 14.61  7.5 0


 */ 

}



