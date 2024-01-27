using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    // TextMeshPro para mostrar la cantidad
    public TMP_Text cantidadText;
    public TMP_Text ppstx;
    public int points = 0;
    public float pps = 0f;

    public void ActualizarFrecuencia(float ppsp)
    {
        pps +=  ppsp;

        CancelInvoke("SumarPuntoPorFrecuencia");
        InvokeRepeating("SumarPuntoPorFrecuencia", 0.0f, 1f / pps);
    } 

    public void ActualizarTextoTMP()
    {
        if (cantidadText != null)
        {
            cantidadText.text = points.ToString();
        }
    }

    public void ActualizarTextoTMPpps()
    {
        if (ppstx != null)
        {
            ppstx.text = "Lps: " + pps;
        }
    }

    private void SumarPuntoPorFrecuencia()
    {
        points++;
        ActualizarTextoTMP();
        ActualizarTextoTMPpps();
    }

    public void SumarPunto()
    {
        points++;
        ActualizarTextoTMP();
    } 
}
