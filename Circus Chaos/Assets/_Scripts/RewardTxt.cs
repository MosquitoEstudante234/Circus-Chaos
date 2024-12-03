using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardTxt : MonoBehaviour
{

    public static float Rewardtxt;
    public TMP_Text RewardTmPro;



    public void Awake()
    {

    }
    void Start()
    {
        Rewardtxt = RewardsScript.CurrentRewards;
    }




    void Update()
    {
        RewardTmPro.text = "Recompensas: " + Rewardtxt.ToString() + "/5";
    }
}
