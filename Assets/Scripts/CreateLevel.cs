using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLevel : MonoBehaviour
{
    public GameObject[] objects;
    public int min;
    public int max;
    private GameObject randomObject;
    public float distanceFromSpawn = 10;
    public float spawnInterval = 0;
    private int maxcount;
    private int count;

    void Start()
    {
        maxcount = Random.Range(min, max);
        if(spawnInterval == 0)
        {
            for(int i = 0; i < maxcount; i++)
            {
                Spawn();
            }
        }
        else
        {
            InvokeRepeating("Spawn", 0, spawnInterval);
        }
    }

    void Update()
    {
        if(count > maxcount)
        {
            CancelInvoke();
        }
    }

    void Spawn()
    {
        int index = Random.Range(0, objects.Length);
        randomObject = Instantiate(objects[index]);

        randomObject.transform.parent = transform;

        float xpos = Random.Range(transform.position.x - distanceFromSpawn, transform.position.x + distanceFromSpawn);
        float zpos = Random.Range(transform.position.z - distanceFromSpawn, transform.position.z + distanceFromSpawn);        
        
        randomObject.transform.localPosition = new Vector3(xpos, 0, zpos);

        count++;
    }
}