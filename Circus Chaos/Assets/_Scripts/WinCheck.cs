using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCheck : MonoBehaviour
{
    public bool Won;
    public GameObject WinPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Won)
        {
            WinPanel.SetActive(true);
        }
    }
    public void WinChecks()
    {
         Won = true;
    }
    public void RemoveWin()
    {
        Won = false;
    }
}
