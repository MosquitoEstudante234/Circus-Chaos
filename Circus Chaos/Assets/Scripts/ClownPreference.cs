using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ClownPreference : MonoBehaviour
{
    public List<GameObject> clowns;
    public GameObject chosenClown;
    void Start()
    {
        chosenClown = clowns[Random.Range(0, clowns.Count - 1)]; 
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject == chosenClown)
        {
            Score.score += 20;
            Destroy(chosenClown);
            Destroy(gameObject);
        }

    }
}
