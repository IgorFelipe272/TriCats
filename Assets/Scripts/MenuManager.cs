using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevel;

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevel);
        PlayerPrefs.SetInt("Fase1", 0);
        PlayerPrefs.SetInt("Fase2", 0);
        PlayerPrefs.SetInt("Fase3", 0);
        PlayerPrefs.SetFloat("timer", 0);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
