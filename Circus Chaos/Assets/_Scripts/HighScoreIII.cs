using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScoreIII : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;



    public void Awake()
    {
        if (ScoreFinal <= ScoreMiniGameIII.score)
        {
            ScoreFinal = ScoreMiniGameIII.score;
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