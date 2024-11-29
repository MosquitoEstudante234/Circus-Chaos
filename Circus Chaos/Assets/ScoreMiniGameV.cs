using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ScoreMiniGameV : MonoBehaviour
{
    public TMP_Text scoreTxt;
    public static int score;
    private void Start()
    {

        score = 0;
    }


    private void Update()
    {
        scoreTxt.text = "Score: " + score.ToString();


    }
}