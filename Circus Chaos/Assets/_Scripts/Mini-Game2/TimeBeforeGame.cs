using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBeforeGame : MonoBehaviour
{
    public GameObject Bar, Player;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeToPlay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator TimeToPlay()
    {
        yield return new WaitForSeconds(5);
        Bar.SetActive(true);
        Player.SetActive(true);
    }
}
