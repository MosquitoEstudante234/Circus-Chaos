using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreIV : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;
    public GameObject Trophy;


    public void Awake()
    {
        if (ScoreFinal <= ScoreMiniGameIV.score)
        {
            ScoreFinal = ScoreMiniGameIV.score;
        }

    }
    void Start()
    {
        ScoreFinalTxt.text = ScoreFinal.ToString();
        if (ScoreFinal >= 7500)
        {
            Trophy.SetActive(true);
        }
    }




    void Update()
    {

    }
}
