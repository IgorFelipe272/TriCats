using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatePlayer : MonoBehaviour
{
    private GameObject manager; // Variável para armazenar o objeto manager
    private static int mortes =0;

    // Start is called before the first frame update
    void Start()
    {
        // Procura o objeto com a tag "Manager" e atribui à variável manager
        manager = GameObject.FindWithTag("manager");

        if (manager == null)
        {
            Debug.LogWarning("Nenhum objeto com a tag 'Manager' encontrado!");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Danger"))
        {
            mortes++;
            manager.GetComponent<ReloadScale>().reload(gameObject,mortes);
        }
    }

}
