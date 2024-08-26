using System.Collections;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject objetoPrefab;  // Prefab do objeto a ser spawnado
    public Transform[] spawners;     // Array de posições dos spawners
    public float tempoParaDesaparecer = 3f;  // Tempo para o objeto desaparecer se não for clicado
    public float tempoCooldown = 0.5f; // Tempo de cooldown para o próximo objeto

    private GameObject objetoAtual;
    private Coroutine cicloSpawn;

    void Start()
    {
        // Não inicia o ciclo de spawn automaticamente aqui
    }

    public void StartCiclo()
    {
        if (cicloSpawn != null)
            StopCoroutine(cicloSpawn);

        cicloSpawn = StartCoroutine(CicloSpawn());
    }

    IEnumerator CicloSpawn()
    {
        while (true)
        {
            // Espera até que o objeto atual seja destruído
            while (objetoAtual != null)
            {
                yield return null;  // Aguarda um frame
            }

            if (spawners.Length == 0)
            {
                Debug.LogError("Nenhum spawner foi atribuído!");
                yield break; // Sai da corrotina se não houver spawners
            }

            SpawnObjeto();

            // Espera até que o objeto seja clicado ou desapareça automaticamente
            yield return new WaitForSeconds(tempoParaDesaparecer);

            if (objetoAtual != null) // Se o objeto ainda não foi clicado
            {
                Destroy(objetoAtual);
                objetoAtual = null; // Define objetoAtual como null após destruição
                yield return new WaitForSeconds(tempoCooldown); // Tempo de cooldown ajustado para 0.5 segundos
            }
        }
    }

    void SpawnObjeto()
    {
        if (spawners.Length == 0)
        {
            Debug.LogError("Nenhum spawner foi atribuído!");
            return;
        }

        int indice = Random.Range(0, spawners.Length);  // Seleciona um spawner aleatório

        if (objetoPrefab == null)
        {
            Debug.LogError("Objeto prefab não atribuído!");
            return;
        }

        objetoAtual = Instantiate(objetoPrefab, spawners[indice].position, Quaternion.identity);  // Spawna o objeto

        Objeto objetoComponente = objetoAtual.GetComponent<Objeto>();
        if (objetoComponente == null)
        {
            Debug.LogError("O prefab não tem o componente 'Objeto'.");
            return;
        }

        // Adiciona um listener para o evento de clique
        objetoComponente.OnObjetoClicado += ObjetoClicado;
    }

    void ObjetoClicado()
    {
        if (objetoAtual != null)
        {
            Destroy(objetoAtual);
            objetoAtual = null; // Define objetoAtual como null após destruição
            StartCoroutine(RespawnAfterDelay());
        }
    }

    IEnumerator RespawnAfterDelay()
    {
        yield return new WaitForSeconds(tempoCooldown); // Tempo de cooldown ajustado para 0.5 segundos
    }
}