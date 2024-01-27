using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    private Button bt;
    private bool firstTime = true;
    private Image btImage;
    private TextMeshProUGUI[] TextosHijos;


    private void Start()
    {
        coste = costeBase;
        nameText.text = nombre;
        ActualizarTextos();
        bt = GetComponent<Button>();
        bt.interactable = false;
        btImage = GetComponent<Image>();
        btImage.enabled = false;
        TextosHijos = GetComponentsInChildren<TextMeshProUGUI>();
        foreach (TextMeshProUGUI textoHijo in TextosHijos)
        {
            textoHijo.enabled = false;
        }
    }

    private void Update()
    {
        if (firstTime && PointsScripts.points > coste * 0.5)
        {
            btImage.enabled = true;
            foreach (TextMeshProUGUI textoHijo in TextosHijos)
            {
                textoHijo.enabled = true;
            }
        }

        if (PointsScripts.points >= coste)
        {
            bt.interactable = true;
        }
        else
        {
            bt.interactable = false;
        }
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

            coste = Mathf.Round(coste * 1.15f);

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

