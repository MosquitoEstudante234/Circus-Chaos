using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardsScript : MonoBehaviour
{
    public static int CurrentRewards = 0;

    // Start is called before the first frame update
    void Start()
    {
        CurrentRewards++;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentRewards == 5)
        {
            SceneManager.LoadScene("cena0");
        }
    }
}
