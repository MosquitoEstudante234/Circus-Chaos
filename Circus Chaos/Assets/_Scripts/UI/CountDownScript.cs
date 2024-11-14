using UnityEngine;
using UnityEngine.Events;

public class CountDownScript : MonoBehaviour
{
    public float freezeDuration = 5f; // Duração em segundos para congelar
    private float countdownTime;

    public UnityEvent OnTimeEnd;

    public void animationEnd() 
    { 
        OnTimeEnd.Invoke();
    }

    void Start()
    {
        countdownTime = freezeDuration;
        Time.timeScale = 0f; // Congela o tempo ao iniciar a cena
    }

    void Update()
    {
        // Controla o countdown usando unscaledDeltaTime, que ignora o Time.timeScale
        if (countdownTime > 0)
        {
            countdownTime -= Time.unscaledDeltaTime;
        }
        else
        {
            Time.timeScale = 1f; // Restaura o tempo ao normal após o countdown
            enabled = false; // Desativa o script para evitar execução contínua
        }
    }
}
