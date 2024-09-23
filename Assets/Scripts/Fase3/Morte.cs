using UnityEngine;
using UnityEngine.SceneManagement;  

public class Morte : MonoBehaviour
{
    // Verifica se o gato colidiu com algo perigoso
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            // Se colidir com algo perigoso, o gato morre e a cena é reiniciada
            Debug.Log("deu dano");
        }
    }
}
