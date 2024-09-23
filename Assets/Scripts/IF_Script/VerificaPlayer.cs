using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaPlayer : MonoBehaviour
{
    public bool entrou;

    // Start is called before the first frame update
    private void Start()
    {
        entrou = false; // Inicializa a variável como falsa
    }

    // Detecta quando o player entra no trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto que entrou tem a tag "Player"
        if (collision.CompareTag("Player"))
        {
            entrou = true;
        }
    }

    // Detecta quando o player sai do trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Verifica se o objeto que saiu tem a tag "Player"
        if (collision.CompareTag("Player"))
        {
            entrou = false;
        }
    }
}
