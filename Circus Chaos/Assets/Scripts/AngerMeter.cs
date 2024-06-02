using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerMeter : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    
    void Update()
    {
        
    }

    IEnumerator Anger()
    {
        yield return new WaitForSeconds(5);
        spriteRenderer.color = Color.yellow;
        yield return new WaitForSeconds(5);
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(5);

    }
}
