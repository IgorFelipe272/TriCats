using UnityEngine;

public class ScaleChangingObject : MonoBehaviour
{
    public Vector3 minScale = new Vector3(1, 1, 1); // Escala mínima
    public Vector3 maxScale = new Vector3(2, 2, 2); // Escala máxima
    public float scaleSpeed = 2.0f;// Velocidade de alteração de escala

    private bool scalingUp = true;// Define se o objeto está aumentando ou diminuindo de escala

    void Update()
    {
        // Interpola a escala do objeto entre minScale e maxScale
        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, maxScale, Time.deltaTime * scaleSpeed);
            if (transform.localScale == maxScale)
                scalingUp = false;
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, minScale, Time.deltaTime * scaleSpeed);
            if (transform.localScale == minScale)
                scalingUp = true;
        }
    }
}
