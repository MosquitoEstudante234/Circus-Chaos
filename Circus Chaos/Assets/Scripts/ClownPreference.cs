using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class ClownPreference : MonoBehaviour
{
    public List<int> clowns;
    public int chosenClown;
    public TMP_Text ClownText;
    void Start()
    {
        chosenClown = clowns[Random.Range(0, clowns[2] )]; 
        ClownText.text = chosenClown.ToString();
        ClownText.transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Clown"))
        {
            if (col.GetComponent<SetParentScript>().ClownID == chosenClown)
            {
                Score.score += 20;
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }

    }
}
