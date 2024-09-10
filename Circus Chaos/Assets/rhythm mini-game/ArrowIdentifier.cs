using UnityEngine;
using TMPro;

public class ArrowIdentifier : MonoBehaviour
{
    public bool[] arrowBool = new bool[0];

    public GameObject[] arrows = new GameObject[0];
    public ArrowFall[] qualityCode = new ArrowFall[0];
    public AudioSource[] arrowAudio = new AudioSource[0];
    //public RoundTimer roundTimer;

    public TextMeshProUGUI showText;

    public bool lastOne;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ArrowRed"))
        {
            arrowBool[0] = true;
            arrows[0] = collision.gameObject;
            qualityCode[0] = collision.gameObject.GetComponent<ArrowFall>();
        }
        if (collision.CompareTag("ArrowYellow"))
        {
            arrowBool[1] = true;
            arrows[1] = collision.gameObject;
            qualityCode[1] = collision.gameObject.GetComponent<ArrowFall>();
        }
        if (collision.CompareTag("ArrowGreen"))
        {
            arrowBool[2] = true;
            arrows[2] = collision.gameObject;
            qualityCode[2] = collision.gameObject.GetComponent<ArrowFall>();
        }
        if (collision.CompareTag("ArrowBlue"))
        {
            arrowBool[3] = true;
            arrows[3] = collision.gameObject;
            qualityCode[3] = collision.gameObject.GetComponent<ArrowFall>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!lastOne)
        {
            return;
        }
        if (Input.anyKeyDown)
        {
            return;
        }
        Destroy(collision.gameObject);
        if (collision.CompareTag("ArrowRed"))
        {
            arrowBool[0] = false;
            arrows[0] = null;
        }
        if (collision.CompareTag("ArrowYellow"))
        {
            arrowBool[1] = false;
            arrows[1] = null;
        }
        if (collision.CompareTag("ArrowGreen"))
        {
            arrowBool[2] = false;
            arrows[2] = null;
        }
        if (collision.CompareTag("ArrowBlue"))
        {
            arrowBool[3] = false;
            arrows[3] = null;
        }
        //roundTimer.roundToFill.fillAmount += .05f;
    }
    private void Update()
    {
        if (arrowBool[0])
        {
            if (Input.GetButtonDown("ArrowLeft"))
            {
                arrowAudio[0].Play();
                switch (qualityCode[0].whatCollision)
                {
                    case ArrowFall.WhatCollision.Bad:
                        showText.text = "Bad";
                        break;
                    case ArrowFall.WhatCollision.Good:
                        showText.text = "Good";
                        break;
                    case ArrowFall.WhatCollision.Sick:
                        showText.text = "Sick!";
                        break;
                }
                Destroy(arrows[0]);
                arrowBool[0] = false;
            }
        }

        if (arrowBool[1])
        {
            if (Input.GetButtonDown("ArrowRight"))
            {
                arrowAudio[1].Play();
                switch (qualityCode[1].whatCollision)
                {
                    case ArrowFall.WhatCollision.Bad:
                        showText.text = "Bad";
                        break;
                    case ArrowFall.WhatCollision.Good:
                        showText.text = "Good";
                        break;
                    case ArrowFall.WhatCollision.Sick:
                        showText.text = "Sick!";
                        break;
                }
                Destroy(arrows[1]);
                arrowBool[1] = false;
            }
        }
        if (arrowBool[2])
        {
            if (Input.GetButtonDown("ArrowUp"))
            {
                arrowAudio[2].Play();
                switch (qualityCode[2].whatCollision)
                {
                    case ArrowFall.WhatCollision.Bad:
                        showText.text = "Bad";
                        break;
                    case ArrowFall.WhatCollision.Good:
                        showText.text = "Good";
                        break;
                    case ArrowFall.WhatCollision.Sick:
                        showText.text = "Sick!";
                        break;
                }
                Destroy(arrows[2]);
                arrowBool[2] = false;
            }
        }
        if (arrowBool[3])
        {
            if (Input.GetButtonDown("ArrowDown"))
            {
                arrowAudio[3].Play();
                switch (qualityCode[3].whatCollision)
                {
                    case ArrowFall.WhatCollision.Bad:
                        showText.text = "Bad";
                        break;
                    case ArrowFall.WhatCollision.Good:
                        showText.text = "Good";
                        break;
                    case ArrowFall.WhatCollision.Sick:
                        showText.text = "Sick!";
                        break;
                }
                Destroy(arrows[3]);
                arrowBool[3] = false;
            }
        }
    }
}
