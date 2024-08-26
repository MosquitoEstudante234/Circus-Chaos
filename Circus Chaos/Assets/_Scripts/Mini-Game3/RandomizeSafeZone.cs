using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSafeZone : MonoBehaviour
{
    public static RandomizeSafeZone instance;

    public GameObject pointA; // Referência ao Ponto A
    public GameObject pointB; // Referência ao Ponto B
    public GameObject safeZone; // Referência à SafeZone

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Inicia a safezone em uma posição e escala aleatória dentro dos limites
        RandomizerSafeZone();
    }

    public void OnPlayerHitsSafeZone()
    {
        // Quando o player acerta a safezone
        RandomizerSafeZone();
    }

    void RandomizerSafeZone()
    {
        // Obtém as posições y dos pontos A e B
        float minY = pointA.transform.position.y;
        float maxY = pointB.transform.position.y;

        // Calcula uma nova posição y aleatória dentro dos limites
        float randomY = Random.Range(minY, maxY);

        // Define a nova posição y da safezone
        Vector3 newPosition = safeZone.transform.position;
        newPosition.y = randomY;
        safeZone.transform.position = newPosition;

        // Define uma nova escala y aleatória para a safezone
        float randomScaleY = Random.Range(-100.0f, -50.0f); // Ajuste esses valores conforme necessário
        Vector3 newScale = safeZone.transform.localScale;
        newScale.y = randomScaleY;
        safeZone.transform.localScale = newScale;
    }
}
