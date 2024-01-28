using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image bar;
    public Points pointsScript;
    public float progressMax;

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = pointsScript.progress / progressMax;
    }
}