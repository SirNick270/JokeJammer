using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image bar;
    public Points pointsScript;
    public float ppsMax;

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = pointsScript.pps / ppsMax;
    }
}
