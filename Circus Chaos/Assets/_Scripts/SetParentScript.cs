using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParentScript : MonoBehaviour
{
    public int ClownID;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            this.transform.SetParent(col.transform);
            transform.localPosition = new Vector3(0f, 1f, 0f);
        }
    }
}