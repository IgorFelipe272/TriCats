using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScale : MonoBehaviour
{
    public List<ScaleChangingObject> objetosEscalados; // Lista de objetos que mudar�o de escala
    public GameObject playerPrefab; // Prefab do jogador
    public Transform localNascer; // Ponto de spawn do novo jogador

    // M�todo chamado quando um objeto entra no trigger
    public void reload(GameObject player, int deathCount)
    {
        // Randomiza as escalas com base no n�mero de mortes
        foreach (ScaleChangingObject objeto in objetosEscalados)
        {
            objeto.RandomizeScaleValues(deathCount);
        }

        // Destroi o jogador atual
        Destroy(player);

        // Instancia um novo jogador no localNascer
        Instantiate(playerPrefab, localNascer.position, localNascer.rotation);
    }

}
