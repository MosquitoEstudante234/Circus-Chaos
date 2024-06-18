using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject prefab;
    public Vector2 spawnAreaMin = new Vector2(-100, -100);
    public Vector2 spawnAreaMax = new Vector2(100, 100);
    public int spawnCount = 10;

    void Start()
    {
        StartCoroutine(Spawns());
    }

    public IEnumerator Spawns()
    {
        PrefabSpawner();
        yield return new WaitForSeconds(10);
        StartCoroutine(Spawns());
    }

    void PrefabSpawner()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            float xPos = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float yPos = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
            Vector3 spawnPosition = new Vector3(xPos, yPos, 0);

            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
