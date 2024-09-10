using System.Collections;
using UnityEngine;

public class RhythmManager : MonoBehaviour
{
    [SerializeField] float spawnTime;
    [SerializeField] bool isPlaying;

    public GameObject[] arrowsSong = new GameObject[4];
    int randomArrow;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(!isPlaying)
            {
                isPlaying = true;
                StartCoroutine(spawnDelay());
            }
        }
    }
    private void Start()
    {
        StartCoroutine(spawnDelay());
    }
    IEnumerator spawnDelay()
    {
        if (!isPlaying)
        {
            yield return null;
        }
        while (isPlaying)
        {
            yield return new WaitForSeconds(spawnTime);
            randomArrow = Random.Range(0, arrowsSong.Length);
            Instantiate(arrowsSong[randomArrow]);
        }
    }
}
