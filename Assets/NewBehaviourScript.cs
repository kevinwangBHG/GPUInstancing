using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                var instance = Instantiate(prefab) as GameObject;
                instance.transform.position = new Vector3(j * 5, 0, i * 5);
                instance.transform.localScale = GetRandomScale();
            }
        }
	}

    Vector3 GetRandomScale()
    {
        float scale = Random.Range(1.2f, 4f);
        return new Vector3(scale, scale, scale);
    }

    // Update is called once per frame
    void Update () {
		
	}

/*
 97  238  -227
 14.61  7.5 0


 */ 

}



