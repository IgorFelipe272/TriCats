using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsReset : MonoBehaviour
{
    // Função para resetar todos os PlayerPrefs
    public void Reset()
    {
        // Apaga todos os dados salvos nos PlayerPrefs
        PlayerPrefs.DeleteAll();

        // Garante que os dados foram apagados imediatamente
        PlayerPrefs.Save();

        Debug.Log("Todos os PlayerPrefs foram resetados.");
    }
}