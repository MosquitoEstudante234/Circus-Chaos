using System.Collections;
using UnityEngine;

public class ClownSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;

    public void Start()
    {
        StartCoroutine(SpawnAfterDelay(0f));
    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            StartCoroutine(SpawnAfterDelay(5f));
        }
    }

    private IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(3f);

        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
