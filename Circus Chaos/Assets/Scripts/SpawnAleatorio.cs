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
            // Escolha um índice aleatório da lista
            int indiceAleatorio = Random.Range(0, Criancas.Count);

            // Pegue o GameObject correspondente ao índice aleatório
            GameObject objetoParaSpawnar = Criancas[indiceAleatorio];

            // Defina a posição e rotação desejada para o spawn (pode ser a posição do script ou outra)
            Vector3 posicaoDeSpawn = transform.position;
            Quaternion rotacaoDeSpawn = transform.rotation;

            // Instancie (spawn) o GameObject na posição e rotação desejada
            Instantiate(objetoParaSpawnar, posicaoDeSpawn, rotacaoDeSpawn);
        }
        else
        {
            Debug.LogWarning("A lista de crianças está vazia!");
        }
    }
}