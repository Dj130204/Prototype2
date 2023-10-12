using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public int spawnCount = 0;

    void Start()
    {
        spawnObjects();
    }

    public void spawnObjects()
    {
        destroyObjects();
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(-2,3);
            screenY = Random.Range(0,80);
            pos = new Vector2(screenX*10, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }
    private void destroyObjects()
    {
        foreach (GameObject o in GameObject.FindGameObjectsWithTag("spawnable"))
        {
            Destroy(o);
            spawnCount = 0;
        }
    }
    public void WhenToSpawn() 
    {
        if (spawnCount < 1)
        {
            spawnObjects();
        }
    }

    public void spawnOneObject()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;
        
        randomItem = Random.Range(0, spawnPool.Count);
        toSpawn = spawnPool[randomItem];

        screenX = Random.Range(-2, 3);
        screenY = Random.Range(0, 80);
        pos = new Vector2(screenX * 10, screenY);

        Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        
    }


}
