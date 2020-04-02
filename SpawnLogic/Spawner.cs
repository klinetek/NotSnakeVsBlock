using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    ArrayChooser ArrayChooser;
    Vector3[] spawnPos = new Vector3[5] {new Vector3(-2.25f,6f,0),new Vector3(-1.125f, 6f,0),new Vector3(0f, 6f,0),new Vector3(1.125f, 6f,0),new Vector3(2.25f, 6f,0)};
    public List<GameObject> gameObjectsToSpawn;

    public void Awake()
    {
        ArrayChooser = GetComponent<ArrayChooser>();
    }

    public void SpawnMethod(int[] array)
    {
        int i = 0;
        for (i = 0; i < array.Length; i++)
        {
            
            if (array[i] == 1)
            {
                GameObject.Instantiate(gameObjectsToSpawn[0], spawnPos[i], transform.rotation);
            }
            else if(array[i] == 2)
            {
                GameObject.Instantiate(gameObjectsToSpawn[1], spawnPos[i], transform.rotation);
            }
            else
            {
                continue;
            }
        }
    }
}