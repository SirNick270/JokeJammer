using UnityEngine;
using TMPro;

public class Modificador : MonoBehaviour
{
    // Referencia al script del clic para acceder a la variable "cantidad"
    public Points PointsScripts;

    // Variable para almacenar el costo base de la mejora
    public int costeBase = 100;

    // Variable para almacenar la cantidad de puntos agregados por segundo base después de comprar
    public float ppsObject = 1f;

    public TMP_Text TextoCoste;

    private int coste;

    private void Start()
    {
        coste = costeBase;
    }

    // Método que se ejecuta al hacer clic en el objeto
    private void OnMouseDown()
    {
        ComprarMejora();
    }

    // Método para comprar la mejora
    private void ComprarMejora()
    {
        // Verifica si hay suficientes puntos para comprar la mejora
        if (PointsScripts.points >= coste)
        {
            // Descuenta el costo base de la mejora
            PointsScripts.points -= coste;

            // Muestra la nueva cantidad de puntos
            PointsScripts.ActualizarTextoTMP();

            PointsScripts.ActualizarFrecuencia(ppsObject);

            //coste = int.Parse(coste * 1.1f);
        }
        else
        {
            Debug.Log("No tienes suficientes puntos para comprar la mejora.");
        }
    }

    /*public void ActualizarTextoTMP()
    {
        if (cantidadText != null)
        {
            cantidadText.text = points.ToString();
        }
    }*/
}

