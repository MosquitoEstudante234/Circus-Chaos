using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ArrowIdentifier : MonoBehaviour
{
    public Animator Animator;
    public string nomezinho;

    public GameObject Erro;
    public GameObject Acerto;

    public UnityEvent ArrowButton;

    public GameObject _arrow;

    public bool HasAnArrowInside;

    private void OnMouseDown()
    {
        if(HasAnArrowInside)
        {
            Animator.SetTrigger(nomezinho);
            ScoreMiniGameV.score += 300;
            ArrowButton.Invoke();
            Acerto.SetActive(true);
            StartCoroutine(DesactivateError());
            
        }
        else
        {
            Animator.SetTrigger("Miss");
            ScoreMiniGameV.score -= 150;
            print("errou bobão");
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
