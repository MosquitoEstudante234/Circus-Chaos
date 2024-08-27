using UnityEngine;
using UnityEngine.UI;

public class TimeToWin : MonoBehaviour
{
    public GameObject Map;
    public Image barTimer;

    [SerializeField]float runTime;
    [SerializeField]float timeToSpent = 1;

    private void Update()
    {
        barTimer.fillAmount = timeToSpent;

        timeToSpent -= runTime * Time.deltaTime;
        if(timeToSpent <= 0)
        {
            Map.SetActive(true);
        }
    }
}
