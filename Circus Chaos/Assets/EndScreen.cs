using UnityEngine;
using UnityEngine.Events;

public class EndScreen : MonoBehaviour
{
    public int WonMinigames;
    public static EndScreen instance;
    public UnityEvent OnEndGame;
    private void Awake()
    {
        instance = this;
    }
    public void DetectEnd()
    {
        if(WonMinigames >= 5)
        {
            print("invoke");
            OnEndGame.Invoke();
        }
        else
        {
            WonMinigames++;
        }
    }
}
