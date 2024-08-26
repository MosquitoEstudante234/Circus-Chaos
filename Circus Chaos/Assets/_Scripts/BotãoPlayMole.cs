using UnityEngine;
using UnityEngine.UI;

public class BotãoPlayMole : MonoBehaviour
{
    public SpawnerManager spawnerManager;  // Referência ao script SpawnerManager
    public Button startButton;             // Referência ao botão de iniciar

    void Start()
    {
        // Adiciona o evento de clique ao botão
        if (startButton != null)
        {
            startButton.onClick.AddListener(IniciarJogo);
        }
    }

    void IniciarJogo()
    {
        // Verifica se o SpawnerManager foi atribuído e inicia o ciclo de spawn
        if (spawnerManager != null)
        {
            spawnerManager.StartCiclo();
        }
    }
}