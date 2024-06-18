using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public GameObject Heart1, Heart2, Heart3;
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
        if (Hearts == 0)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        if (Hearts == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        if (Hearts == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        }
        if (Hearts == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }

    }

}