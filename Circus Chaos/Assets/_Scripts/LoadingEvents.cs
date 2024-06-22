using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingEvents : MonoBehaviour
{
    public GameObject Map, Tutorial, Minigame1, Minigame2, Minigame3;
   
   public void LoadMinigameOne()
   {
    Map.SetActive(false);
    Minigame1.SetActive(true);
   }
   public void LoadMinigameTwo()
   {
    Map.SetActive(false);
    Minigame2.SetActive(true);
   }
   public void LoadMinigameThree()
   {
    Map.SetActive(false);
    Minigame3.SetActive(true);
   }
   public void LoadMap()
   {
    Map.SetActive(true);
    Minigame1.SetActive(false);
    Minigame2.SetActive(false);
    Minigame3.SetActive(false);
    Tutorial.SetActive(false);
   }
   public void Deactivate()
   {
    gameObject.SetActive(false);
   }
}
