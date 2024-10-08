using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ArrowIdentifier : MonoBehaviour
{
    public GameObject Erro;
    public GameObject Acerto;

    public UnityEvent ArrowButton;

    public GameObject _arrow;

    public bool HasAnArrowInside;

    private void OnMouseDown()
    {
        if(HasAnArrowInside)
        {
            ArrowButton.Invoke();
            Acerto.SetActive(true);
            StartCoroutine(DesactivateError());
        }
        else
        {
            print("errou bob�o");
            Erro.SetActive(true);
            StartCoroutine(DesactivateError());
        }
    }
    IEnumerator DesactivateError()
    {
        yield return new WaitForSeconds(0.5f);
        Erro.SetActive(false);
        Acerto.SetActive(false);
    }
    public void DestroyArrow()
    {
        Destroy(_arrow);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            _arrow = collision.gameObject;
            HasAnArrowInside = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            _arrow = null;
            HasAnArrowInside = false;
        }
    }

}
