using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalancePlayer : MonoBehaviour
{
    public float rotationSpeed = 0.1f;
    public float moveSpeed = 0.001f; // Velocidade de movimento no eixo X
    public Button increaseButton;
    public Button decreaseButton;

    private float minXPosition = 39.70f; // Limite mínimo do eixo X
    private float maxXPosition = 40.30f;  // Limite máximo do eixo X

    private void Start()
    {
        // Verifica a posição inicial para garantir que está dentro dos limites
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minXPosition, maxXPosition),
            transform.position.y,
            transform.position.z
        );

        increaseButton.onClick.AddListener(IncreaseRotation);
        decreaseButton.onClick.AddListener(DecreaseRotation);
    }

    void Update()
    {
        float zRotation = transform.eulerAngles.z;

        // Converte a rotação de 360 para -180 a 180 graus
        if (zRotation > 180)
        {
            zRotation -= 360;
        }

        // Controle da rotação
        if (zRotation > -1 && zRotation < 1)
        {
            zRotation++;
        }

        // Movimento no eixo X baseado na rotação
        float moveAmount = moveSpeed * Time.deltaTime;
        moveAmount = Mathf.Clamp(moveAmount, -0.05f, 0.05f); // Limita o movimento para evitar velocidades extremas

        if (zRotation >= 0)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime  * 5);
            transform.position += new Vector3(-moveAmount, 0, 0); // Move para a esquerda
        }
        else if (zRotation <= -1)
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime * 5);
            transform.position += new Vector3(moveAmount, 0, 0); // Move para a direita
        }

        // Restringe a posição do eixo X para estar entre -0.25 e 0.25
        float clampedX = Mathf.Clamp(transform.position.x, minXPosition, maxXPosition);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);



        // Condições de queda
        if (zRotation >= 50 || zRotation <= -50)
        {
            Debug.Log("Caiu");
        }
    }

    public void IncreaseRotation()
    {
        transform.Rotate(0, 0, 17f);
    }

    public void DecreaseRotation()
    {
        transform.Rotate(0, 0, -17f);
    }
}
