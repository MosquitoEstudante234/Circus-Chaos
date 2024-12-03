using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{

    public static float ScoreFinal;
    public TMP_Text ScoreFinalTxt;



    public void Awake()
    {
        if (ScoreFinal <= Score.score)
        {
            ScoreFinal = Score.score;
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
