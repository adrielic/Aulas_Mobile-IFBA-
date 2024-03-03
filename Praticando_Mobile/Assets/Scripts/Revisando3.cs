using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Revisando3 : MonoBehaviour
{
    public TMP_Text text;
    public Touch touch;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (touch.position.x > Screen.width / 2)
                {
                    text.text = "Direita";
                }
                else
                {
                    text.text = "Esquerda";
                }
            }
        }
    }
}
