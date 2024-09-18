using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSafeZone : MonoBehaviour
{
    public static RandomizeSafeZone instance;

    public GameObject pointA; 
    public GameObject pointB; 
    public GameObject safeZone; 

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        RandomizerSafeZone();
    }

    public void OnPlayerHitsSafeZone()
    {
       
        RandomizerSafeZone();
    }

    void RandomizerSafeZone()
    {
        
        float minY = pointA.transform.position.y;
        float maxY = pointB.transform.position.y;

        float randomY = Random.Range(minY, maxY);

        Vector3 newPosition = safeZone.transform.position;
        newPosition.y = randomY;
        safeZone.transform.position = newPosition;


        float randomScaleY = Random.Range(0.5f, 1f); 

        Vector3 newScale = safeZone.transform.localScale;
        newScale.y = randomScaleY;
        safeZone.transform.localScale = newScale;
    }
}
