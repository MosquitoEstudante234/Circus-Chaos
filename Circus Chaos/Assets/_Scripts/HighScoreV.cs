using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreV : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;
    public GameObject Trophy;

    bool finished;

    public void Awake()
    {
        if (ScoreFinal <= ScoreMiniGameV.score)
        {
            ScoreFinal = ScoreMiniGameV.score;
        }

    }
    void Start()
    {
        ScoreFinalTxt.text = ScoreFinal.ToString();
        if (ScoreFinal >= 10000)
        {
            Trophy.SetActive(true);
            if (!finished)
            {
                EndScreen.instance.DetectEnd();
            }
            finished = true;
        }
    }




    void Update()
    {

    }
}
