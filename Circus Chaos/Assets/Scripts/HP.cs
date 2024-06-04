using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public static int Hearts = 3;
    void Start()
    {
        Hearts = 3;
    }
    public void Update()
    {
        if (Hearts <= 0)
        {
            SceneManager.LoadScene("cena1");
        }

    }

}