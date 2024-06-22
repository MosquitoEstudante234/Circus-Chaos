using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    public FixedJoystick joystick;

    public static float speed = 3;

    public static float direction;

    public Animator animator;

    public static Transform posPlayer;
    public SpriteRenderer spriteRenderer;
    public static PlayerMovement Instance;

    //public Transform weapon;

    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        posPlayer = transform;
        body = GetComponent<Rigidbody2D>();
        speed = 3;
    }

    void Update()
    {

        if (joystick.Horizontal != 0)
        {
            direction = joystick.Horizontal;
        }

        if (joystick.Horizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
        if (joystick.Horizontal > 0)
        {
            spriteRenderer.flipX = false;
        }

        animator.SetBool("Walking", joystick.Horizontal != 0 || joystick.Vertical != 0);
        if (gameObject.transform.childCount > 1)
        {
            foreach (Transform Child in gameObject.transform)
            {
                Destroy(Child.gameObject);
            }
        }
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(joystick.Horizontal * speed, joystick.Vertical * speed);
    }
}