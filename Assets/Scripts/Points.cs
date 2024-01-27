using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Points : MonoBehaviour
{
    // TextMeshPro para mostrar la cantidad
    public TMP_Text cantidadText;
    public TMP_Text ppstx;
    public float points = 0;
    public float pps = 0f;

    public void ActualizarFrecuencia(float ppsp)
    {
        pps +=  (float)Math.Round(ppsp, 1);
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
            ppstx.text = "Lps: " + pps.ToString("0.0");
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
