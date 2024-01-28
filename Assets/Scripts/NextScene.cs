using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambiarEscena : MonoBehaviour
{
    public int escenaSiguiente;
    public Points points;
    public ProgressBar progressBar;
    private Button bt;

    private void Start()
    {
        bt = GetComponent<Button>();
        bt.interactable = false;
    }

    private void Update()
    {
        if (points.progress >= progressBar.progressMax)
        {
            bt.interactable = true;
        }
        else
        {
            bt.interactable = false;
        }
    }

    public void NextScene()
    {
        // Cambia a la escena llamada "Escena2"
        SceneManager.LoadScene("Escena" + escenaSiguiente);
    }
}

