using System.Collections;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public GameObject objetoPrefab;  // Prefab da marmota
    public GameObject outroObjetoPrefab;  // Novo prefab do segundo objeto
    public Transform[] spawners;     // Array de posi��es dos spawners
    public float tempoParaDesaparecer = 3f;  // Tempo para o objeto desaparecer se n�o for clicado
    public float tempoCooldown = 0.5f; // Tempo de cooldown para o pr�ximo objeto

    private GameObject objetoAtual;
    private Coroutine cicloSpawn;

    void Start()
    {
        // N�o inicia o ciclo de spawn automaticamente aqui
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
            // Espera at� que o objeto atual seja destru�do
            while (objetoAtual != null)
            {
                yield return null;  // Aguarda um frame
            }

            if (spawners.Length == 0)
            {
                Debug.LogError("Nenhum spawner foi atribu�do!");
                yield break; // Sai da corrotina se n�o houver spawners
            }

            SpawnObjeto();

            // Espera at� que o objeto seja clicado ou desapare�a automaticamente
            yield return new WaitForSeconds(tempoParaDesaparecer);

            if (objetoAtual != null) // Se o objeto ainda n�o foi clicado
            {
                Destroy(objetoAtual);
                objetoAtual = null; // Define objetoAtual como null ap�s destrui��o
                yield return new WaitForSeconds(tempoCooldown); // Tempo de cooldown ajustado para 0.5 segundos
            }
        }
    }

    void SpawnObjeto()
    {
        if (spawners.Length == 0)
        {
            Debug.LogError("Nenhum spawner foi atribu�do!");
            return;
        }

        int indice = Random.Range(0, spawners.Length);  // Seleciona um spawner aleat�rio

        if (objetoPrefab == null || outroObjetoPrefab == null)
        {
            Debug.LogError("Objeto prefab n�o atribu�do!");
            return;
        }

        // Decide aleatoriamente qual prefab spawnar com 30% de chance para o outro objeto
        bool spawnOutroObjeto = Random.value < 0.3f; // 30% de chance para o outro objeto
        GameObject prefabParaSpawnar = spawnOutroObjeto ? outroObjetoPrefab : objetoPrefab;

        objetoAtual = Instantiate(prefabParaSpawnar, spawners[indice].position, Quaternion.identity);  // Spawna o objeto

        // Adiciona o componente de clique adequado
        if (prefabParaSpawnar == objetoPrefab)
        {
            Objeto objetoComponente = objetoAtual.GetComponent<Objeto>();
            if (objetoComponente != null)
            {
                objetoComponente.OnObjetoClicado += ObjetoClicado;
            }
        }
        else if (prefabParaSpawnar == outroObjetoPrefab)
        {
            OutroObjeto outroObjetoComponente = objetoAtual.GetComponent<OutroObjeto>();
            if (outroObjetoComponente != null)
            {
                outroObjetoComponente.OnOutroObjetoClicado += OutroObjetoClicado;
            }
        }
    }

    void ObjetoClicado()
    {
        if (objetoAtual != null)
        {
            ScoreMiniGameIV.score += 500;
            Destroy(objetoAtual);
            objetoAtual = null; // Define objetoAtual como null ap�s destrui��o
            StartCoroutine(RespawnAfterDelay());
        }
    }

    void OutroObjetoClicado()
    {
        if (objetoAtual != null)
        {
            ScoreMiniGameIV.score -= 1000;
            Debug.Log("Perdeu");
            Destroy(objetoAtual);
            objetoAtual = null; // Define objetoAtual como null ap�s destrui��o
            StartCoroutine(RespawnAfterDelay());
        }
    }

    IEnumerator RespawnAfterDelay()
    {
        yield return new WaitForSeconds(tempoCooldown); // Tempo de cooldown ajustado para 0.5 segundos
    }
}