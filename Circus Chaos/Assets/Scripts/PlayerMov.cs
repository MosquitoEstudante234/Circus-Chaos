using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float velocidade = 5.20f;
    Vector2 movement;
    public Rigidbody2D rb;

    public Transform pauseMenu;
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
        if (gameObject.transform.childCount > 1)
        {
            foreach(Transform Child in gameObject.transform)
            {
                Destroy(Child.gameObject);
            }
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * velocidade * Time.fixedDeltaTime);
    }
}
