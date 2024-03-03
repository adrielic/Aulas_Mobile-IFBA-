using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Revisando1 : MonoBehaviour
{
    public TMP_Text text;
    public Touch touch;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    text.text = "Began";
                    break;
                case TouchPhase.Ended:
                    text.text = "Ended";
                    break;
                case TouchPhase.Canceled:
                    text.text = "Canceled";
                    break;
                case TouchPhase.Moved:
                    text.text = "Moved";
                    break;
                case TouchPhase.Stationary:
                    text.text = "Stationary";
                    break;
            }
        }
    }
}
