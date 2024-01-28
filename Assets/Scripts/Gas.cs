using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class Gas : MonoBehaviour
{
    public Points points;
    public ProgressBar progressBar;
    public int multiplicador;
    public int seconds;
    private Image btImage;
    private Image[] childImages;
    private float ppsActual;
    private bool ft;

    private void Start()
    {
        btImage = GetComponent<Image>();
        childImages = GetComponentsInChildren<Image>();
        btImage.enabled = false;
        foreach (Image childImage in childImages)
        {
            childImage.enabled = false;
        }
    }

    private void Update()
    {
        if (points.progress >= progressBar.progressMax)
        {
            btImage.enabled = true;
            foreach (Image childImage in childImages)
            {
                childImage.enabled = true;
            }
        }
        else
        {
            btImage.enabled = false;
            foreach (Image childImage in childImages)
            {
                childImage.enabled = false;
            }
        }
    }

    public void Activar()
    {
        StartCoroutine(Activo());
    }

    private IEnumerator Activo()
    {
        ppsActual = points.pps;
        ft = true;
        InvokeRepeating("Actualizar", 0.0f, 0.1f);
        points.progress = 0;

        yield return new WaitForSeconds(seconds);

        CancelInvoke("Actualizar");
        points.pps = points.pps / multiplicador;
    }

    private void Actualizar()
    {
        if (points.pps != ppsActual || ft == true)
        {
            points.pps = points.pps * multiplicador;
            points.ActualizarFrecuencia(0);
            points.ActualizarTextoTMPpps();

            ft = false;
            ppsActual = points.pps;
        }
    }
}

