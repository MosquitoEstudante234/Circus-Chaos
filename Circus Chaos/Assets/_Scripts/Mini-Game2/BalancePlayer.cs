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
    public GameObject LoadMenu;

    private float minXPosition = 39.70f; // Limite m�nimo do eixo X
    private float maxXPosition = 40.30f;  // Limite m�ximo do eixo X
       

    private void Start()
    {
        // Verifica a posi��o inicial para garantir que est� dentro dos limites
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minXPosition, maxXPosition),
            transform.position.y,
            transform.position.z
        );

        increaseButton.onClick.AddListener(IncreaseRotation);
        decreaseButton.onClick.AddListener(DecreaseRotation);
        StartCoroutine(TimeBeforeGame());
    }

    void Update()
    {
        float zRotation = transform.eulerAngles.z; 

        // Converte a rota��o de 360 para -180 a 180 graus
        if (zRotation > 180)
        {
            zRotation -= 360;
        }

        // Controle da rota��o
        if (zRotation > -1 && zRotation < 1)
        {
            zRotation++;
        }

        // Movimento no eixo X baseado na rota��o
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

        // Restringe a posi��o do eixo X para estar entre -0.25 e 0.25
        float clampedX = Mathf.Clamp(transform.position.x, minXPosition, maxXPosition);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);



        // Condi��es de queda
        if (zRotation >= 50 || zRotation <= -50)
        {
            Debug.Log("Caiu");
            LoadMenu.SetActive(true);
        }
        if ((zRotation <= 15) && (zRotation >= -15))
        {
            ScoreMiniGameII.score++;
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
    public IEnumerator TimeBeforeGame()
    {
        //transform.rotation.x = 0;
        yield return new WaitForSeconds(5);

    }
}
