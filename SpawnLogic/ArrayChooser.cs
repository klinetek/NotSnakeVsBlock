using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrayChooser : MonoBehaviour
{
    Spawner spawner;
    public int[] tarray;
    public float TimetoSpawn = 1.2f;
    public void Awake()
    {
        spawner = GetComponent<Spawner>();
    }
    public void Update()
    {
        TimetoSpawn -= Time.deltaTime;
        if(TimetoSpawn <= 0f)
        {
            TimetoSpawn = 1.2f;
            tarray = PopulateRow();
            //all blocks number is here JOE.
            spawner.SpawnMethod(tarray);
        }
    }

    public int[] PopulateRow()
    {
        int[] row = new int [5] { 0, 0, 0, 0, 0 };
        var shapeNum = Random.Range(0, 10);
        //if space (0), all row is spaces *dots random later*
        if (shapeNum == 0)
        {
            return row;
        }
        //if blocks (1), 20% chance to populate each row space with a block
        else if (shapeNum >0 && shapeNum <6)
        {
            int i = 0;
            for (i = 0; i < row.Length; i++)
            {
                var chooser = Random.Range(1,100);
                if (chooser < 50)
                {
                   row[i]=1;
                }
                else
                {
                    row[i]=0;
                }
            }
         return row;
        }
        else if (shapeNum >=6 && shapeNum<11)
        {
            int i = 0;
            for (i = 0; i < (row.Length -1); i++)
            {
                var chooser = Random.Range(1, 100);
                if (chooser < 50)
                {
                    row[i]=2;
                }
                else
                {
                    row[i]=0;
                }
            }
         return row;
        }
        else
        {
            return null;
        }
    }   
}
