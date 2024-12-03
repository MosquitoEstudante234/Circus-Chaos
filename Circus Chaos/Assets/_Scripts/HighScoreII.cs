using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreII : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;



    public void Awake()
    {
        if (ScoreFinal <= ScoreMiniGameII.score)
        {
            ScoreFinal = ScoreMiniGameII.score;
        }

    }
    void Start()
    {
        ScoreFinalTxt.text = ScoreFinal.ToString();;
    }




    void Update()
    {

    }
}
