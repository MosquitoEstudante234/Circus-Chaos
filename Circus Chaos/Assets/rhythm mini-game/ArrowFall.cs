using System.Collections;
using TMPro;
using UnityEngine;

public class ArrowFall : MonoBehaviour
{
    public enum WhatCollision
    {
        Bad, Good, Sick
    }
    Transform arrowTransfomr;
    [SerializeField]float arrowFallSpeed;

    public WhatCollision whatCollision;

    private void Awake()
    {
        arrowTransfomr = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
            whatCollision = WhatCollision.Bad;
        }
        if(other.gameObject.layer == 7)
        {
            whatCollision = WhatCollision.Good;
        }
        if(other.gameObject.layer == 8)
        {
            whatCollision = WhatCollision.Sick;
        }

    }
    private void FixedUpdate()
    {
        arrowTransfomr.Translate(transform.up * -arrowFallSpeed);
    }
    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
