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



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(SpawnAfterDelay(5f));
        }
    }

    private IEnumerator SpawnAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
