using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Revisando2 : MonoBehaviour
{
    public TMP_Text text;
    public Touch touch;
    public int t;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            t += Input.touchCount;
            text.text = t.ToString();
        }
    }
}
