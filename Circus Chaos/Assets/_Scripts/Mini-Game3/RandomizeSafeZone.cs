using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeSafeZone : MonoBehaviour
{
    public static RandomizeSafeZone instance;

    public GameObject pointA; // Refer�ncia ao Ponto A
    public GameObject pointB; // Refer�ncia ao Ponto B
    public GameObject safeZone; // Refer�ncia � SafeZone

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Inicia a safezone em uma posi��o e escala aleat�ria dentro dos limites
        RandomizerSafeZone();
    }

    public void OnPlayerHitsSafeZone()
    {
        // Quando o player acerta a safezone
        RandomizerSafeZone();
    }

    void RandomizerSafeZone()
    {
        // Obt�m as posi��es y dos pontos A e B
        float minY = pointA.transform.position.y;
        float maxY = pointB.transform.position.y;

        // Calcula uma nova posi��o y aleat�ria dentro dos limites
        float randomY = Random.Range(minY, maxY);

        // Define a nova posi��o y da safezone
        Vector3 newPosition = safeZone.transform.position;
        newPosition.y = randomY;
        safeZone.transform.position = newPosition;

        // Define uma nova escala y aleat�ria para a safezone
        float randomScaleY = Random.Range(-100.0f, -50.0f); // Ajuste esses valores conforme necess�rio
        Vector3 newScale = safeZone.transform.localScale;
        newScale.y = randomScaleY;
        safeZone.transform.localScale = newScale;
    }
}
