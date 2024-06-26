using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyToOpenWorld : MonoBehaviour
{
    public GameObject Passage, Door, Key;
    public void OpenWorld()
    {
        if ((Input.GetKey(KeyCode.Mouse0)))
        {
            Destroy(gameObject);
            Passage.SetActive(true);
            Door.SetActive(false);
            Destroy(Key);
        }
    }
    private void OnMouseOver()
    {
        OpenWorld();
    }
}
