using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VefificaFase2 : MonoBehaviour
{
    [SerializeField] private VerificaPlayer portal1;
    [SerializeField] private VerificaPlayer portal2;

    private GameEndController gameEndController;
    private bool isWaiting; // Para evitar múltiplas chamadas da corrotina

    void Start()
    {
        gameEndController = FindFirstObjectByType<GameEndController>();
        isWaiting = false; // Inicializa como falso
    }

    void Update()
    {
        if (portal1.entrou && portal2.entrou && !isWaiting)
        {
            // Inicia a corrotina para esperar 5 segundos
            StartCoroutine(WaitAndChangeScene());
        }
    }

    private IEnumerator WaitAndChangeScene()
    {
        isWaiting = true; // Marca como aguardando
        Debug.Log("Entrou nos dois portais. Aguardando 5 segundos...");

        // Espera por 5 segundos
        yield return new WaitForSeconds(5f);

        // Chama o método para mudar a cena
        gameEndController.ChangeScene();
        Debug.Log("Cena alterada após 5 segundos.");
    }
}
