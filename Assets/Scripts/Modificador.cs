using UnityEngine;
using TMPro;

public class Modificador : MonoBehaviour
{
    public Points PointsScripts;
    public int costeBase = 100;
    public float ppsObject = 1f;
    public TMP_Text TextoCoste;
    private float coste;
    public TMP_Text nameText;
    public string nombre;
    public int cantidad = 0;
    public TMP_Text TextoCantidad;

    private void Start()
    {
        coste = costeBase;
        nameText.text = nombre;
        ActualizarTextos();
    }

    // Método para comprar la mejora
    public void ComprarMejora()
    {
        // Verifica si hay suficientes puntos para comprar la mejora
        if (PointsScripts.points >= coste)
        {
            // Descuenta el costo base de la mejora
            PointsScripts.points -= coste;

            // Muestra la nueva cantidad de puntos
            PointsScripts.ActualizarTextoTMP();

            PointsScripts.ActualizarFrecuencia(ppsObject);

            coste = Mathf.Round(coste * 1.2f);

            cantidad++;

            ActualizarTextos();
        }
        else
        {
            Debug.Log("No tienes suficientes puntos para comprar la mejora.");
        }
    }

    public void ActualizarTextos()
    {
        if (TextoCoste != null)
        {
            TextoCoste.text = coste.ToString();
            TextoCantidad.text = cantidad.ToString();
        }
    }
}

