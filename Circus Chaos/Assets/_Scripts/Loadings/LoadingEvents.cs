using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingEvents : MonoBehaviour
{
   
   public void LoadMinigameOne()
   {
        SceneManager.LoadScene("MiniGame1");
    }
   public void LoadMinigameTwo()
   {
        SceneManager.LoadScene("MiniGame2");
    }
   public void LoadMinigameThree()
   {
        SceneManager.LoadScene("MiniGame3");
    }
   public void LoadMinigameFour()
   {
        SceneManager.LoadScene("MiniGame4");
    }
   public void LoadMap()
   {
        SceneManager.LoadScene("Map");
 
   }
   public void Deactivate()
   {
    gameObject.SetActive(false);
   }
}
