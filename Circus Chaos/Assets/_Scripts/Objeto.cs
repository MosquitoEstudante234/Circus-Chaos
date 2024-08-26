using UnityEngine;

public class Objeto : MonoBehaviour
{
    public delegate void ObjetoClicadoHandler();
    public event ObjetoClicadoHandler OnObjetoClicado;

    void OnMouseDown()
    {
        if (OnObjetoClicado != null)
            OnObjetoClicado.Invoke();
    }
}