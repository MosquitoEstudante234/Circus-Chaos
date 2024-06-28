using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMiss : MonoBehaviour
{

    public void MissBalloon()
    {
        Destroy(gameObject);
        Score.score -= 100;
    }

}
