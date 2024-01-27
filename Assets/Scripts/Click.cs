using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    public Points PointsScript;
    
    // Escala original del objeto
    private Vector3 escalaOriginal;

    // Escala deseada durante la animación
    private Vector3 escalaAgrandada;

    // Duración de la animación
    public float duracionAnimacion = 0.1f;

    // Flag para verificar si el clic está presionado
    private bool clicPresionado = false;

    private void Start()
    {
        escalaOriginal = transform.localScale;
        escalaAgrandada = escalaOriginal / 1.1f; // Ajusta el factor según sea necesario
    }

    // Método que se ejecuta cuando se pulsa el objeto
    private void OnMouseDown()
    {
        PointsScript.SumarPunto();

        // Inicia la animación de escala y salto al hacer clic
        clicPresionado = true;
    }

    // Método que se ejecuta cuando se suelta el clic del objeto
    private void OnMouseUp()
    {
        // Detiene la animación al soltar el clic
        clicPresionado = false;
    }

    private void Update()
    {
        // Verifica si el clic está presionado y realiza la animación
        if (clicPresionado)
        {
            AgrandarObjeto();
        }
        else
        {
            // Si el clic se ha soltado, revierte la animación a la escala original
            RestaurarEscalaOriginal();
        }
    }

    // Método para realizar la animación de agrandar
    private void AgrandarObjeto()
    {
        // Interpola suavemente hacia la escala agrandada
        transform.localScale = Vector3.Lerp(transform.localScale, escalaAgrandada, Time.deltaTime / duracionAnimacion);
    }

    // Método para restaurar la escala original
    private void RestaurarEscalaOriginal()
    {
        // Interpola suavemente hacia la escala original
        transform.localScale = Vector3.Lerp(transform.localScale, escalaOriginal, Time.deltaTime / duracionAnimacion);
    }
}
