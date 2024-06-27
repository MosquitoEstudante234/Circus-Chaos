using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBalloonMiniGame : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if ((Input.GetKey(KeyCode.Mouse0)))
        {
            Panel.SetActive(true);
        }
    }
    
    
    
    
    
    private void OnMouseOver()
    {
            OpenPanel();
    }
}
