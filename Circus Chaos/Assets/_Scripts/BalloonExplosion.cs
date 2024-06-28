using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonExplosion : MonoBehaviour
{

    private void OnMouseOver()
    {
        DestroyBalloon();
    }

    public void DestroyBalloon()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Destroy(gameObject);
            Score.score += 250;
        }
        
    }
}
