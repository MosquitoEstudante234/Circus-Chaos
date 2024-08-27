using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{   
    public GameObject LoadMap, MiniGame;
    public TMP_Text Timertxt;
    public int timer = 60;
     
    public void Start()
    {
        StartCoroutine("Tempo");
    }
    private void Update()
    {
        Timertxt.text = "Tempo restante: " + timer.ToString();
        if (timer <= 0)
        {
            LoadMap.SetActive(true);
            MiniGame.SetActive(false);
        }
       

    }
    public IEnumerator Tempo()
    {
        yield return new WaitForSeconds(1);
        timer--;
        StartCoroutine("Tempo");
    }
}
