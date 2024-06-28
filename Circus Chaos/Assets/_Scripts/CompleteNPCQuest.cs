using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteNPCQuest : MonoBehaviour
{
    public GameObject ActivatedObj, DesactivatedObj, DestroyedObj;
    public void Complete()
    {
        if ((Input.GetKey(KeyCode.Mouse0)))
        {
            ActivatedObj.SetActive(true);
            DesactivatedObj.SetActive(false);
            Destroy(DestroyedObj);
            Destroy(gameObject);
        }
    }
    private void OnMouseOver()
    {
        Complete();
    }

}
