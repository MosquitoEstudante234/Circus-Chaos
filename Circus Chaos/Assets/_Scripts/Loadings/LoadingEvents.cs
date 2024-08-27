using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingEvents : MonoBehaviour
{
    public GameObject Map, Tutorial, Minigame1, Minigame2, Minigame3, Minigame4;
   
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
   public void LoadMinigameFour()
   {
    Map.SetActive(false);
    Minigame4.SetActive(true);
   }
   public void LoadMap()
   {
    Map.SetActive(true);
    Tutorial.SetActive(false);
    Minigame1.SetActive(false);
    Minigame2.SetActive(false);
    Minigame3.SetActive(false);
    Minigame4.SetActive(false);
 
   }
   public void Deactivate()
   {
    gameObject.SetActive(false);
   }
}
