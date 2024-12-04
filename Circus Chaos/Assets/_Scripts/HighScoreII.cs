using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreII : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;
    public GameObject Trophy;

    bool finished;


    public void Awake()
    {
        if (ScoreFinal <= ScoreMiniGameII.score)
        {
            ScoreFinal = ScoreMiniGameII.score;
        }

    }
    void Start()
    {
        ScoreFinalTxt.text = ScoreFinal.ToString();
        if (ScoreFinal >= 4000)
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
