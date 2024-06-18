using System.Collections.Generic;
using UnityEngine;

public class SpawnAleatorio : MonoBehaviour
{
    public List<GameObject> Criancas = new List<GameObject>(3);

    void Start()
    {
        // Certifique-se de que a lista tenha pelo menos um GameObject
        if (Criancas.Count > 0)
        {
            // Escolha um �ndice aleat�rio da lista
            int indiceAleatorio = Random.Range(0, Criancas.Count);

            // Pegue o GameObject correspondente ao �ndice aleat�rio
            GameObject objetoParaSpawnar = Criancas[indiceAleatorio];

            // Defina a posi��o e rota��o desejada para o spawn (pode ser a posi��o do script ou outra)
            Vector3 posicaoDeSpawn = transform.position;
            Quaternion rotacaoDeSpawn = transform.rotation;

            // Instancie (spawn) o GameObject na posi��o e rota��o desejada
            Instantiate(objetoParaSpawnar, posicaoDeSpawn, rotacaoDeSpawn);
        }
        else
        {
            Debug.LogWarning("A lista de crian�as est� vazia!");
        }
    }
}