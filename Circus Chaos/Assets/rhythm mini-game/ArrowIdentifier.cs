using UnityEngine;
using UnityEngine.Events;

public class ArrowIdentifier : MonoBehaviour
{
    public UnityEvent ArrowButton;

    public GameObject _arrow;

    public bool HasAnArrowInside;

    private void OnMouseDown()
    {
        if(!HasAnArrowInside)
        {
            return;
        }
        ArrowButton.Invoke();
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
