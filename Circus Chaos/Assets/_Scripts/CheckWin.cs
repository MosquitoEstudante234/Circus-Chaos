using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckWin : MonoBehaviour
{
    public UnityEvent CheckIfWin;
    void Start()
    {
        StartCoroutine(CheckAfterSeconds());
    }

    public IEnumerator CheckAfterSeconds()
    {
        yield return new WaitForSeconds(1);
        CheckIfWin.Invoke();
    }
}
