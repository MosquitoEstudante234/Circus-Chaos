using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerMeter : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        //SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        StartCoroutine(Anger());
    }

    
    void Update()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    IEnumerator Anger()
    {
        yield return new WaitForSeconds(3);
        spriteRenderer.color = Color.yellow;
        yield return new WaitForSeconds(5);
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
        HP.Hearts--;
    }
}
