using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public GameObject Child;
   public void OnTriggerStay2D(Collider2D col)
   {
    if(col.CompareTag("Player"))
    {
        Child.SetActive(true);
    } else
   {
        Child.SetActive(false);
   }
    }
    public void OnTriggerExit2D(Collider2D col)
    {

    if(col.CompareTag("Player"))
    {
        Child.SetActive(false);
    }
}
}