using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObject : MonoBehaviour
{
    public Vector3 minScale = new Vector3(1, 1, 1); // Escala mínima
    public Vector3 maxScale = new Vector3(2, 2, 2); // Escala máxima
    public float scaleSpeed = 2.0f; // Velocidade de alteração de escala
    public float minVariation = 0.5f; // Variação mínima da escala
    public float maxVariation = 1.5f; // Variação máxima da escala

    private bool scalingUp = true; // Define se o objeto está aumentando ou diminuindo de escala

    void Start()
    {
        RandomizeScaleValues(1); // Inicializa os valores aleatórios
    }

    void Update()
    {
        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, Time.deltaTime * scaleSpeed);
            if (Vector3.Distance(transform.localScale, maxScale) < 0.01f)
            {
                transform.localScale = maxScale;
                scalingUp = false;
            }
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, Time.deltaTime * scaleSpeed);
            if (Vector3.Distance(transform.localScale, minScale) < 0.01f)
            {
                transform.localScale = minScale;
                scalingUp = true;
            }
        }
    }

    // Função pública para randomizar os valores de escala com base no número de mortes
    public void RandomizeScaleValues(int deathCount)
    {
        // Calcula a nova variação com base no número de mortes
        float variationFactor = Mathf.Clamp(1.0f - (deathCount * 0.1f), 0.1f, 1.0f);

        if (variationFactor < 1f)
        {
            variationFactor = 1;
        }

        minScale = new Vector3(
            Random.Range(1 * variationFactor, 1 * variationFactor + minVariation),
            Random.Range(1 * variationFactor, 1 * variationFactor + minVariation),
            Random.Range(1 * variationFactor, 1 * variationFactor + minVariation));

        maxScale = new Vector3(
            Random.Range(1 * variationFactor + minVariation, 2 * variationFactor),
            Random.Range(1 * variationFactor + minVariation, 2 * variationFactor),
            Random.Range(1 * variationFactor + minVariation, 2 * variationFactor));

        // Exibe os novos valores de escala para depuração
        Debug.Log($"Novos valores - minScale: {minScale}, maxScale: {maxScale}");
    }
}
