using UnityEngine;

public class OutroObjeto : MonoBehaviour
{
    public delegate void CliqueNoOutroObjeto();
    public event CliqueNoOutroObjeto OnOutroObjetoClicado;

    void OnMouseDown()
    {
        // Quando clicado, dispara o evento
        OnOutroObjetoClicado?.Invoke();
    }
}